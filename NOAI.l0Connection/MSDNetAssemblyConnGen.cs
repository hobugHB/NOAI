using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class MSDNetAssemblyConnGen
    {
        public NOAI_l0Connection_TypeConnGenProperties CodeReflectableCSharpCode(TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context)
        {
            if(typeInfo.IsArray)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }
            
            //if (typeInfo.Name.EndsWith("&"))
            if (typeInfo.IsByRef)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            NOAI_l0Connection_TypeConnGenProperties properties;

            lock (context.RequestedCodeTypeSet)
            {
                if (context.RequestedCodeTypeSet.ContainsKey(typeInfo))
                {
                    return context.RequestedCodeTypeSet[typeInfo];
                }

                properties = new NOAI_l0Connection_TypeConnGenProperties();
                context.RequestedCodeTypeSet.Add(typeInfo, properties);
            }

            var referConnGenNamespaceBuilder = new StringBuilder();
            referConnGenNamespaceBuilder.AppendLine(context.CodeTypeConnGenRefNameCSharpCode());

            var typeConnGenBodyBuilder = new StringBuilder();
            properties.Namespace = "NOAI_" +
                context.FixWin32PathSymbol(typeInfo.Assembly.FullName ?? "") + "_" +
                context.FixWin32PathSymbol(context.ContextDate.ToUniversalTime().ToLongTimeString());
            typeConnGenBodyBuilder.AppendLine("namespace " + properties.Namespace);
            typeConnGenBodyBuilder.AppendLine("{");

            context.CodeMemberDocumentBlockCSharpCode(typeInfo, 1, typeConnGenBodyBuilder);

            NOAI_l0Connection_TypeConnGenProperties srcTypeProperties;
            typeConnGenBodyBuilder.AppendLine("\t" + context.CodeTypeConnGenPropertiesCSharpCode(typeInfo, out srcTypeProperties));
            typeConnGenBodyBuilder.AppendLine("\tpublic " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
            typeConnGenBodyBuilder.AppendLine("\t{");

            typeConnGenBodyBuilder.AppendLine("\t\tprivate " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Namespace + "." +
                srcTypeProperties.Name + " _NOAI_l0Connection_BaseInstance;");
            typeConnGenBodyBuilder.AppendLine("");

            foreach (var i in typeInfo.DeclaredConstructors.Where(ii => ii.IsPublic))
            {
                context.CodeMemberDocumentBlockCSharpCode(i, 2, typeConnGenBodyBuilder);

                var parameters = i.GetParameters();
                typeConnGenBodyBuilder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Name +
                    "(" + string.Join(", ", parameters.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t{");
                typeConnGenBodyBuilder.AppendLine("\t\t\t_NOAI_l0Connection_BaseInstance = new " + srcTypeProperties.Namespace + "." + srcTypeProperties.Name +
                    "(" + string.Join(", ", parameters.Select(p => p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t}");
                typeConnGenBodyBuilder.AppendLine("");
            }

            var referCodedReflectableNamespace = new List<string>();
            foreach (var i in typeInfo.DeclaredProperties//.Where(ii => ii.IsPublic)
                )
            {
                context.CodeMemberDocumentBlockCSharpCode(i, 2, typeConnGenBodyBuilder);
                context.CodeMemberAttributeBlockCSharpCode(i, 2, typeConnGenBodyBuilder);
                foreach (var attribute in i.CustomAttributes)
                {
                    var referConnGenProperties = CodeReferReflectableCSharpCode(
                        referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                        attribute.Constructor.DeclaringType.GetTypeInfo(), context);

                    context.CodeMemberAttributeBlockCSharpCode(attribute, 2, typeConnGenBodyBuilder,
                        typeInfo => typeInfo.Name);
                }

                typeConnGenBodyBuilder.AppendLine("\t\tpublic " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + i.PropertyType.FullName + " " + i.Name);
                typeConnGenBodyBuilder.AppendLine("\t\t{");
                if (i.CanRead)
                {
                    typeConnGenBodyBuilder.AppendLine("\t\t\tget { return _NOAI_l0Connection_BaseInstance." + i.Name + "; }");
                }
                if (i.CanWrite)
                {
                    typeConnGenBodyBuilder.AppendLine("\t\t\tset { _NOAI_l0Connection_BaseInstance." + i.Name + " = value; }");
                }
                typeConnGenBodyBuilder.AppendLine("\t\t}");
                typeConnGenBodyBuilder.AppendLine("");
            }

            foreach (var i in typeInfo.DeclaredMethods.Where(ii => ii.IsPublic))
            {
                if (i.Name.StartsWith("get_"))
                {
                    continue;
                }
                if (i.Name.StartsWith("set_"))
                {
                    continue;
                }

                var parameters = i.GetParameters();
                foreach (var parameter in parameters)
                {
                    var referConnGenProperties = CodeReferReflectableCSharpCode(
                    referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                    parameter.ParameterType.GetTypeInfo(), context);
                }

                typeConnGenBodyBuilder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") +
                    (i.ReturnType.FullName == "System.Void" ? "void" : i.ReturnType.FullName) +
                    " " + i.Name + "(" + string.Join(", ", parameters.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t{");
                typeConnGenBodyBuilder.AppendLine("\t\t\treturn _NOAI_l0Connection_BaseInstance." + i.Name +
                    "(" + string.Join(", ", parameters.Select(p => p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t}");
                typeConnGenBodyBuilder.AppendLine("");
            }

            typeConnGenBodyBuilder.AppendLine("\t}");

            typeConnGenBodyBuilder.AppendLine("}");

            if (!Directory.Exists(context.FixWin32PathSymbol(context.OutputCodeFileDirectory)))
            {
                Directory.CreateDirectory(context.FixWin32PathSymbol(context.OutputCodeFileDirectory));
            }

            var builder = new StringBuilder();
            builder.AppendLine(referConnGenNamespaceBuilder.ToString());
            //builder.AppendLine("");
            builder.AppendLine(typeConnGenBodyBuilder.ToString());

            var path = context.FixWin32PathSymbol(Path.Combine(context.OutputCodeFileDirectory,
                 typeInfo.Name + "_" + properties.Namespace));
            File.WriteAllTextAsync(
                context.FixWin32PathLength(path, ".cs"),
                builder.ToString());

            return properties;
        }

        private NOAI_l0Connection_TypeConnGenProperties CodeReferReflectableCSharpCode(
            List<string> referCodedReflectableNamespace, StringBuilder referConnGenNamespaceBuilder,
            TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context)
        {
            var referConnGenProperties = CodeReflectableCSharpCode(typeInfo, context);
            if(string.IsNullOrEmpty(referConnGenProperties.Name))
            {
                return referConnGenProperties;
            }

            if (!referCodedReflectableNamespace.Contains(referConnGenProperties.Namespace))
            {
                referCodedReflectableNamespace.Add(referConnGenProperties.Namespace);
                referConnGenNamespaceBuilder.AppendLine("using " + referConnGenProperties.Namespace + ";");
            }

            return referConnGenProperties;
        }

        public void CodeReflectableCSharpCode(Assembly assembly, NOAI_l0Connection_ConnGenContext context)
        {
            Parallel.ForEach(assembly.ExportedTypes, i =>
             {
                 CodeReflectableCSharpCode(i.GetTypeInfo(), context);

             });

        }
    }
}
