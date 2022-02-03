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

            if (typeInfo.GenericTypeArguments.Length > 0)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            NOAI_l0Connection_TypeConnGenProperties properties;

            lock (context.RequestedCodeTypeSet)
            {
                if (context.RequestedCodeTypeSet.ContainsKey(context.GetFullName(typeInfo)))
                {
                    return context.RequestedCodeTypeSet[context.GetFullName(typeInfo)];
                }

                properties = new NOAI_l0Connection_TypeConnGenProperties();
                properties.Name = typeInfo.Name;

                context.RequestedCodeTypeSet.Add(context.GetFullName(typeInfo), properties);
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
            var codeConnGenType = new Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties>(type => CodeReferReflectableCSharpCode(
                        referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                        type.GetTypeInfo(), context));

            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);
                context.CodeMemberDocumentBlockCSharpCode(typeInfo, indent, typeConnGenBodyBuilder);
                context.CodeMemberAttributeBlockCSharpCode(typeInfo, indent, typeConnGenBodyBuilder, codeConnGenType);
                typeConnGenBodyBuilder.AppendLine(header + "" + context.CodeTypeConnGenPropertiesCSharpCode(typeInfo, out srcTypeProperties));
                typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
                typeConnGenBodyBuilder.AppendLine(header + "{");
            }

            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);

                typeConnGenBodyBuilder.AppendLine(header + "private " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Namespace + "." +
                    srcTypeProperties.Name + " _NOAI_l0Connection_UnderlyingTypeBaseInstance;");
                typeConnGenBodyBuilder.AppendLine("");

                if (!srcTypeProperties.IsStatic)
                {
                    var underlyingTypeBaseInstanceMethodParameterName = srcTypeProperties.Namespace + "." +
                            srcTypeProperties.Name + " _NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance;";
                    typeConnGenBodyBuilder.AppendLine(header + "public " + ("/*static*/ ") + srcTypeProperties.Name +
                        "(" + underlyingTypeBaseInstanceMethodParameterName + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        "_NOAI_l0Connection_UnderlyingTypeBaseInstance = " + underlyingTypeBaseInstanceMethodParameterName + ";");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }

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
                    context.CodeMemberAttributeBlockCSharpCode(i, indent, typeConnGenBodyBuilder, codeConnGenType);
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Name +
                        "(" + string.Join(", ", parameters.Select(p =>
                        context.CodeTypeNameInConnGenWithContext(p.ParameterType.GetTypeInfo(), codeConnGenType) + " " + p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        "_NOAI_l0Connection_UnderlyingTypeBaseInstance = new " + srcTypeProperties.Namespace + "." + srcTypeProperties.Name +
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
                    context.CodeMemberDocumentBlockCSharpCode(i, indent, typeConnGenBodyBuilder);
                    context.CodeMemberAttributeBlockCSharpCode(i, indent, typeConnGenBodyBuilder, codeConnGenType);
                    foreach (var attribute in i.CustomAttributes)
                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(
                            referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                            attribute.Constructor.DeclaringType.GetTypeInfo(), context);

                        context.CodeMemberAttributeBlockCSharpCode(attribute, 2, typeConnGenBodyBuilder,
                            context.CodeTypeNameInConnGenWithContext, codeConnGenType);
                    }

                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(
                            referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                            i.PropertyType.GetTypeInfo(), context);

                        typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") +
                            context.CodeTypeNameInConnGenWithContext(i.PropertyType.GetTypeInfo(), codeConnGenType) + " " + i.Name);
                    }

                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    if (i.CanRead)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                            "get { return NOAI_l1Runtime_IOCenterContext.Instance.Read(()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name + "); }");
                    }
                    if (i.CanWrite)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                            "set { NOAI_l1Runtime_IOCenterContext.Instance.Write(()=>_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name + " = value}; }");
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
                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(
                                referCodedReflectableNamespace, referConnGenNamespaceBuilder,
                                i.ReturnType.GetTypeInfo(), context);
                    }

                    context.CodeMemberDocumentBlockCSharpCode(i, indent, typeConnGenBodyBuilder);
                    context.CodeMemberAttributeBlockCSharpCode(i, indent, typeConnGenBodyBuilder, codeConnGenType);
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") +
                        (i.ReturnType.FullName == "System.Void" ? "void" :
                        context.CodeTypeNameInConnGenWithContext(i.ReturnType.GetTypeInfo(), codeConnGenType)) +
                        " " + i.Name + "(" + string.Join(", ", parameters.Select(p =>
                        context.CodeTypeNameInConnGenWithContext(p.ParameterType.GetTypeInfo(), codeConnGenType) + " " + p.Name)) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        (i.ReturnType.FullName == "System.Void" ? "" : ("return " + (context.IsConnGenHiddenCodeType(i.ReturnType.GetTypeInfo()) ? "" : ("new " +
                            context.CodeTypeNameInConnGenWithContext(i.ReturnType.GetTypeInfo(), codeConnGenType) + "(")))) +
                        "_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name +
                        "(" + string.Join(", ", parameters.Select(p => p.Name)) + ")" +
                        (i.ReturnType.FullName == "System.Void" ? "" : (context.IsConnGenHiddenCodeType(i.ReturnType.GetTypeInfo()) ? "" : (")"))) +
                        ";");
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

            context.SaveOutputContextWin32CSharpCode(new NOAI_l0Connection_ConnGenOutputContext()
            {
                TypeInfo = typeInfo,
                Properties = properties,
                ReferConnGenNamespaceBuilder = referConnGenNamespaceBuilder,
                TypeConnGenBodyBuilder = typeConnGenBodyBuilder,
            });

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
