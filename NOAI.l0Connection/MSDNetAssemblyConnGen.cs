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

            var typeConnGenRefNameBuilder = new StringBuilder();
            typeConnGenRefNameBuilder.AppendLine(context.CodeTypeConnGenRefNameCSharpCode());

            var typeConnGenBodyBuilder = new StringBuilder();
            properties.Namespace = "NOAI_" +
                context.FixWin32PathSymbol(typeInfo.AssemblyQualifiedName ?? "") + "_" +
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

            foreach (var i in typeInfo.DeclaredConstructors)
            {
                context.CodeMemberDocumentBlockCSharpCode(i, 2, typeConnGenBodyBuilder);

                var ps = i.GetParameters();
                typeConnGenBodyBuilder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Name +
                    "(" + string.Join(", ", ps.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t{");
                typeConnGenBodyBuilder.AppendLine("\t\t\t_NOAI_l0Connection_BaseInstance = new " + srcTypeProperties.Namespace + "." + srcTypeProperties.Name +
                    "(" + string.Join(", ", ps.Select(p => p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t}");
                typeConnGenBodyBuilder.AppendLine("");
            }

            var codedAttributeNamespace = new List<string>();
            foreach (var i in typeInfo.DeclaredProperties)
            {
                context.CodeMemberDocumentBlockCSharpCode(i, 2, typeConnGenBodyBuilder);
                context.CodeMemberAttributeBlockCSharpCode(i, 2, typeConnGenBodyBuilder);
                foreach (var attribute in i.CustomAttributes)
                {
                    var attributeConnGenProperties = CodeReflectableCSharpCode(
                        attribute.Constructor.DeclaringType.GetTypeInfo(), context);
                    if (!codedAttributeNamespace.Contains(attributeConnGenProperties.Namespace))
                    {
                        codedAttributeNamespace.Add(attributeConnGenProperties.Namespace);
                        typeConnGenRefNameBuilder.AppendLine("using " + attributeConnGenProperties.Namespace + ";");
                    }

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

            foreach (var i in typeInfo.DeclaredMethods)
            {
                if (i.Name.StartsWith("get_"))
                {
                    continue;
                }
                if (i.Name.StartsWith("set_"))
                {
                    continue;
                }

                var ps = i.GetParameters();
                typeConnGenBodyBuilder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") +
                    (i.ReturnType.FullName == "System.Void" ? "void" : i.ReturnType.FullName) +
                    " " + i.Name + "(" + string.Join(", ", ps.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                typeConnGenBodyBuilder.AppendLine("\t\t{");
                typeConnGenBodyBuilder.AppendLine("\t\t\treturn _NOAI_l0Connection_BaseInstance." + i.Name +
                    "(" + string.Join(", ", ps.Select(p => p.Name)) + ")");
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
            builder.AppendLine(typeConnGenRefNameBuilder.ToString());
            builder.AppendLine("");
            builder.AppendLine(typeConnGenBodyBuilder.ToString());

            var path = context.FixWin32PathSymbol(Path.Combine(context.OutputCodeFileDirectory,
                properties.Namespace + "_" + typeInfo.Name));
            File.WriteAllTextAsync(
                context.FixWin32PathLength(path, ".cs"),
                builder.ToString());

            return properties;
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
