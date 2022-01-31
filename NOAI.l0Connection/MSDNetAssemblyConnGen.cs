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
            if (typeInfo.IsArray)
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
                properties.Name = typeInfo.Name;

                context.RequestedCodeTypeSet.Add(typeInfo, properties);
            }
            {
                properties.Namespace = "NOAI_" +
                    context.FixWin32PathSymbol(typeInfo.Assembly.FullName ?? "") + "_" +
                    context.FixWin32PathSymbol(context.ContextDate.ToUniversalTime().ToLongTimeString());
            }

            var referConnGenNamespaceBuilder = new StringBuilder();
            referConnGenNamespaceBuilder.AppendLine(context.CodeTypeConnGenRefNameCSharpCode());
            var typeConnGenBodyBuilder = new StringBuilder();
            var indent = 0;
            {
                var header = context.CodeIndentBlankHeader(indent);
                typeConnGenBodyBuilder.AppendLine(header + "namespace " + properties.Namespace);
                typeConnGenBodyBuilder.AppendLine(header + "{");
            }

            NOAI_l0Connection_TypeConnGenProperties srcTypeProperties;
            var referCodedReflectableNamespace = new List<string>();
            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);

                context.CodeMemberDocumentBlockCSharpCode(typeInfo, indent, typeConnGenBodyBuilder);

                typeConnGenBodyBuilder.AppendLine(header + "" + context.CodeTypeConnGenPropertiesCSharpCode(typeInfo, out srcTypeProperties));
                typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
                typeConnGenBodyBuilder.AppendLine(header + "{");
            }

            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);

                typeConnGenBodyBuilder.AppendLine(header + "private " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Namespace + "." +
                    srcTypeProperties.Name + " _NOAI_l0Connection_BaseInstance;");
                typeConnGenBodyBuilder.AppendLine("");


                foreach (var i in typeInfo.DeclaredConstructors.Where(ii => ii.IsPublic))
                {
                    var parameters = i.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(
                            referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                            parameter.ParameterType.GetTypeInfo(), context);
                    }

                    context.CodeMemberDocumentBlockCSharpCode(i, indent, typeConnGenBodyBuilder);

                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Name +
                        "(" + string.Join(", ", parameters.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) + 
                        "_NOAI_l0Connection_BaseInstance = new " + srcTypeProperties.Namespace + "." + srcTypeProperties.Name +
                        "(" + string.Join(", ", parameters.Select(p => p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
            }
            {
                var header = context.CodeIndentBlankHeader(indent);

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

                    typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + i.PropertyType.FullName + " " + i.Name);
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    if (i.CanRead)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) + 
                            "get { return _NOAI_l0Connection_BaseInstance." + i.Name + "; }");
                    }
                    if (i.CanWrite)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) + 
                            "set { _NOAI_l0Connection_BaseInstance." + i.Name + " = value; }");
                    }
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
            }
            {
                var header = context.CodeIndentBlankHeader(indent);

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

                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") +
                        (i.ReturnType.FullName == "System.Void" ? "void" : i.ReturnType.FullName) +
                        " " + i.Name + "(" + string.Join(", ", parameters.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) + 
                        "return _NOAI_l0Connection_BaseInstance." + i.Name +
                        "(" + string.Join(", ", parameters.Select(p => p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
            }

            indent--;
            {
                var header = context.CodeIndentBlankHeader(indent);

                typeConnGenBodyBuilder.AppendLine(header + "}");
            }

            indent--;
            {
                var header = context.CodeIndentBlankHeader(indent);

                typeConnGenBodyBuilder.AppendLine("}");
            }

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
            if (string.IsNullOrEmpty(referConnGenProperties.Name))
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
