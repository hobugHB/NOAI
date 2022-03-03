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
        public void CodeReflectableCSharpCode(
            NOAI_l0Connection_ConnGenContext context)
        {
            var outputSet = new List<NOAI_l0Connection_TypeConnGenProperties>();
            Parallel.ForEach(context.InputSetReflectableObjects, i =>
            {
                var p = CodeReflectableCSharpCode(i, context);
                lock (outputSet)
                {
                    outputSet.Add(p);
                }

            });

            context.OutputSetConnGenProperties = outputSet.ToArray();
        }

        private NOAI_l0Connection_TypeConnGenProperties CodeReflectableCSharpCode(
            TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context)
        {
            if (context.IsConnGenHiddenCodeType(typeInfo))
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            if (typeInfo.IsArray)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            //if (typeInfo.Name.EndsWith("&"))
            if (typeInfo.IsByRef)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            //if (typeInfo.Name.EndsWith("*"))
            if (typeInfo.IsPointer)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            if (typeInfo.GenericTypeArguments.Length > 0)
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            if (string.IsNullOrEmpty(typeInfo.AssemblyQualifiedName))
            {
                return new NOAI_l0Connection_TypeConnGenProperties();
            }

            if (typeInfo.CustomAttributes.Any(i => i.Constructor.DeclaringType ==
                typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute)))
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
                properties.AssemblyName = "NOAI_" +
                    context.FixWin32PathSymbol(typeInfo.Assembly.FullName ?? "") + "_" +
                    context.FixWin32PathSymbol(context.ContextDate.ToUniversalTime().ToLongTimeString());

                properties.Namespace = "NOAI_" +
                    context.FixWin32PathSymbol(typeInfo.Namespace ?? "") + "_" +
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
            var codeConnGenTypeHandler = new Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties>(
                type => CodeReferReflectableCSharpCode(typeInfo,
                    type.GetTypeInfo(), referCodedReflectableNamespace, referConnGenNamespaceBuilder, context));

            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);
                context.CodeMemberDocumentBlockCSharpCode(typeInfo, indent, typeConnGenBodyBuilder);
                context.CodeMemberAttributeBlockCSharpCode(typeInfo, indent, typeConnGenBodyBuilder, codeConnGenTypeHandler);
                typeConnGenBodyBuilder.AppendLine(header + "" + context.
                    CodeTypeConnGenPropertiesCSharpCode(typeInfo, out srcTypeProperties));

                var isHandled = false;
                if (srcTypeProperties.IsEnum)
                {
                    isHandled = true;
                    typeConnGenBodyBuilder.AppendLine(header + "public " + "enum " + typeInfo.Name);
                }
                if (srcTypeProperties.IsInterface)
                {
                    isHandled = true;
                    typeConnGenBodyBuilder.AppendLine(header + "public " + "interface " + typeInfo.Name + " : " + context.GetFullName(typeInfo));
                }
                if (srcTypeProperties.IsClass)
                {
                    isHandled = true;
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name);
                }
                if (srcTypeProperties.IsValueType && !srcTypeProperties.IsEnum)
                {
                    isHandled = true;
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") + "struct " + typeInfo.Name);
                }
                if (!isHandled)
                {

                }

                typeConnGenBodyBuilder.AppendLine(header + "{");
                if (srcTypeProperties.IsEnum)
                {
                    indent++;
                    foreach (var i in typeInfo.GetEnumValues())
                    {
                        var name = i.ToString();
                        var fieldInfo = typeInfo.GetField(name);
                        context.CodeMemberDocumentBlockCSharpCode(fieldInfo, indent, typeConnGenBodyBuilder);
                        context.CodeMemberAttributeBlockCSharpCode(fieldInfo, indent, typeConnGenBodyBuilder, codeConnGenTypeHandler);
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) + name + " = " +
                            Convert.ChangeType(i, typeof(int)) + ",");
                    }
                    indent--;
                }
                if (srcTypeProperties.IsInterface)
                {

                }
                if (srcTypeProperties.IsClass)
                {
                    CodeClassBody(typeInfo, context, referConnGenNamespaceBuilder, typeConnGenBodyBuilder, indent,
                        srcTypeProperties, referCodedReflectableNamespace, codeConnGenTypeHandler);
                }
                {
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                }
            }

            indent--;
            {
                var header = context.CodeIndentBlankHeader(indent);

                typeConnGenBodyBuilder.AppendLine("}");
            }

            context.SaveOutputContextWin32CSharpCode(new NOAI_l0Connection_TypeConnOutputContext()
            {
                TypeInfo = typeInfo,
                Properties = properties,
                ReferConnGenNamespaceBuilder = referConnGenNamespaceBuilder,
                TypeConnGenBodyBuilder = typeConnGenBodyBuilder,
            });

            return properties;
        }

        private void CodeClassBody(TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context,
            StringBuilder referConnGenNamespaceBuilder, StringBuilder typeConnGenBodyBuilder, int indent,
            NOAI_l0Connection_TypeConnGenProperties srcTypeProperties, List<string> referCodedReflectableNamespace,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
        {
            indent++;
            {
                var header = context.CodeIndentBlankHeader(indent);
                if (srcTypeProperties.IsStatic)
                {
                    typeConnGenBodyBuilder.AppendLine(header + "private " + ("static ") + context.GetFullName(typeInfo) +
                        " _NOAI_l0Connection_UnderlyingTypeBaseInstance = " + context.GetFullName(typeInfo) + ";");
                    typeConnGenBodyBuilder.AppendLine("");
                    typeConnGenBodyBuilder.AppendLine(header + "public " + ("static ") + context.GetFullName(typeInfo) +
                        " NOAI_l0Connection_UnderlyingTypeBaseInstance\r\n" +
                        header + "{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }");
                }
                else
                {
                    typeConnGenBodyBuilder.AppendLine(header + "private " + ("/*static*/ ") + srcTypeProperties.Namespace + "." +
                        srcTypeProperties.Name + " _NOAI_l0Connection_UnderlyingTypeBaseInstance;");
                    typeConnGenBodyBuilder.AppendLine("");

                    var underlyingTypeBaseInstanceConstructorParameterName = "NOAI_l0Connection_Constructor_UnderlyingTypeBaseInstance";
                    typeConnGenBodyBuilder.AppendLine(header + "public " + ("/*static*/ ") + srcTypeProperties.Name +
                        "(" + context.GetFullName(typeInfo) + " " + underlyingTypeBaseInstanceConstructorParameterName + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        "_NOAI_l0Connection_UnderlyingTypeBaseInstance = " + underlyingTypeBaseInstanceConstructorParameterName + ";");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                    typeConnGenBodyBuilder.AppendLine(header + "public " + ("/*static*/ ") + context.GetFullName(typeInfo) +
                        " NOAI_l0Connection_UnderlyingTypeBaseInstance\r\n" +
                        header + "{ get { return _NOAI_l0Connection_UnderlyingTypeBaseInstance; } }");
                }
                typeConnGenBodyBuilder.AppendLine("");

                foreach (var i in typeInfo.DeclaredConstructors.Where(ii => ii.IsPublic))
                {
                    var parameters = i.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(typeInfo,
                            parameter.ParameterType.GetTypeInfo(), referCodedReflectableNamespace,
                            referConnGenNamespaceBuilder, context);
                    }

                    context.CodeMemberDocumentBlockCSharpCode(i, indent, typeConnGenBodyBuilder);
                    context.CodeMemberAttributeBlockCSharpCode(i, indent, typeConnGenBodyBuilder, codeConnGenTypeHandler);
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") + srcTypeProperties.Name +
                        "(\r\n" + header + context.CodeIndentBlankHeader(1) +
                        string.Join(",\r\n" + header + context.CodeIndentBlankHeader(1), parameters.Select(p =>
                        context.CodeTypeNameInConnGenWithContext(p.ParameterType.GetTypeInfo(), codeConnGenTypeHandler) + " " +
                        context.CodeObjectNameInConnGenWithContext(p.Name))) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        "_NOAI_l0Connection_UnderlyingTypeBaseInstance = new " + context.GetFullName(typeInfo) +
                        "(\r\n" + header + context.CodeIndentBlankHeader(2) +
                        string.Join(",\r\n" + header + context.CodeIndentBlankHeader(2), parameters.Select(p =>
                        context.CodeObjectNameInConnGenWithContext(p.Name))) + ");");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
            }
            {
                var header = context.CodeIndentBlankHeader(indent);

                foreach (var i in typeInfo.DeclaredProperties//.Where(ii => ii.IsPublic)
                )
                {
                    CodeMemberMetaBlockCSharpCode(typeInfo,
                        i, indent, context, referConnGenNamespaceBuilder,
                        typeConnGenBodyBuilder, referCodedReflectableNamespace, codeConnGenTypeHandler);

                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(typeInfo,
                            i.PropertyType.GetTypeInfo(), referCodedReflectableNamespace,
                            referConnGenNamespaceBuilder, context);

                        typeConnGenBodyBuilder.AppendLine(header + "public " + (srcTypeProperties.IsStatic ? "static " : "/*static*/ ") +
                            context.CodeTypeNameInConnGenWithContext(i.PropertyType.GetTypeInfo(), codeConnGenTypeHandler) + " " + i.Name);
                    }

                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    if (i.CanRead)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                            "get { return NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>" + (
                            context.IsConnGenHiddenCodeType(i.PropertyType.GetTypeInfo()) ? "" : ("new " +
                                context.CodeTypeNameInConnGenWithContext(i.PropertyType.GetTypeInfo(), codeConnGenTypeHandler) + "(")) + "\r\n" +
                                header + context.CodeIndentBlankHeader(2) +
                                "_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name + (
                                context.IsConnGenHiddenCodeType(i.PropertyType.GetTypeInfo()) ? "" : ")") + "); }");
                    }
                    if (i.CanWrite)
                    {
                        typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                            "set { NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>\r\n" +
                                header + context.CodeIndentBlankHeader(2) +
                                "_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name + " = value\r\n" +
                                header + context.CodeIndentBlankHeader(3) +
                                (context.IsConnGenHiddenCodeType(i.PropertyType.GetTypeInfo()) ? "" :
                                ".NOAI_l0Connection_UnderlyingTypeBaseInstance") + "); }");
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
                        var referConnGenProperties = CodeReferReflectableCSharpCode(typeInfo,
                                parameter.ParameterType.GetTypeInfo(), referCodedReflectableNamespace,
                                referConnGenNamespaceBuilder, context);
                    }
                    {
                        var referConnGenProperties = CodeReferReflectableCSharpCode(typeInfo,
                                i.ReturnType.GetTypeInfo(), referCodedReflectableNamespace,
                                referConnGenNamespaceBuilder, context);
                    }

                    CodeMemberMetaBlockCSharpCode(typeInfo,
                        i, indent, context, referConnGenNamespaceBuilder,
                        typeConnGenBodyBuilder, referCodedReflectableNamespace, codeConnGenTypeHandler);
                    typeConnGenBodyBuilder.AppendLine(header + "public " + (i.IsStatic ? "static " : "/*static*/ ") +
                        (i.ReturnType.FullName == "System.Void" ? "void" :
                        context.CodeTypeNameInConnGenWithContext(i.ReturnType.GetTypeInfo(), codeConnGenTypeHandler)) +
                        " " + i.Name + "(\r\n" + header + context.CodeIndentBlankHeader(1) +
                        string.Join(",\r\n" + header + context.CodeIndentBlankHeader(1), parameters.Select(p =>
                        context.CodeTypeNameInConnGenWithContext(p.ParameterType.GetTypeInfo(), codeConnGenTypeHandler) + " " +
                        context.CodeObjectNameInConnGenWithContext(p.Name))) + ")");
                    typeConnGenBodyBuilder.AppendLine(header + "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        (i.ReturnType.FullName == "System.Void" ? "" : ("return ")) +
                        "NOAI_l1Runtime_IOCenterContext.Instance.Enter(()=>\r\n" +
                        header + context.CodeIndentBlankHeader(2) +
                        (i.ReturnType.FullName == "System.Void" ? "" : (
                        (context.IsConnGenHiddenCodeType(i.ReturnType.GetTypeInfo()) ? "" : ("new " +
                            context.CodeTypeNameInConnGenWithContext(i.ReturnType.GetTypeInfo(), codeConnGenTypeHandler) + "(")))) +
                            "_NOAI_l0Connection_UnderlyingTypeBaseInstance." + i.Name +
                        "(\r\n" + header + context.CodeIndentBlankHeader(3) +
                        string.Join(",\r\n" + header + context.CodeIndentBlankHeader(3),
                            parameters.Select(p =>
                            context.CodeObjectNameInConnGenWithContext(p.Name) + 
                            (context.IsConnGenHiddenCodeType(p.ParameterType.GetTypeInfo()) ? "" :
                            ".NOAI_l0Connection_UnderlyingTypeBaseInstance"))) + ")" +
                        (i.ReturnType.FullName == "System.Void" ? "" : (context.IsConnGenHiddenCodeType(i.ReturnType.GetTypeInfo()) ? "" : (")"))) +
                        ");");
                    typeConnGenBodyBuilder.AppendLine(header + "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
                {
                    typeConnGenBodyBuilder.AppendLine(header +
                        "public override int GetHashCode()");
                    typeConnGenBodyBuilder.AppendLine(header +
                        "{");
                    typeConnGenBodyBuilder.AppendLine(header + context.CodeIndentBlankHeader(1) +
                        "return _NOAI_l0Connection_UnderlyingTypeBaseInstance.GetHashCode();");
                    typeConnGenBodyBuilder.AppendLine(header +
                        "}");
                    typeConnGenBodyBuilder.AppendLine("");
                }
            }
            indent--;
        }

        private void CodeMemberMetaBlockCSharpCode(
            TypeInfo currentTypeInfo, MemberInfo i, int indent,
            NOAI_l0Connection_ConnGenContext context,
            StringBuilder referConnGenNamespaceBuilder,
            StringBuilder typeConnGenBodyBuilder,
            List<string> referCodedReflectableNamespace,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
        {
            context.CodeMemberDocumentBlockCSharpCode(i, indent, typeConnGenBodyBuilder);
            context.CodeMemberAttributeBlockCSharpCode(i, indent, typeConnGenBodyBuilder, codeConnGenTypeHandler);
            foreach (var attribute in i.CustomAttributes)
            {
                var referConnGenProperties = CodeReferReflectableCSharpCode(
                    currentTypeInfo,
                    attribute.Constructor.DeclaringType.GetTypeInfo(), referCodedReflectableNamespace,
                    referConnGenNamespaceBuilder, context);

                context.CodeMemberAttributeBlockCSharpCode(attribute, indent, typeConnGenBodyBuilder,
                    context.CodeTypeNameInConnGenWithContext, codeConnGenTypeHandler);
            }
        }

        private NOAI_l0Connection_TypeConnGenProperties CodeReferReflectableCSharpCode(
            TypeInfo currentTypeInfo, TypeInfo referTypeInfo,
            List<string> referCodedReflectableNamespace,
            StringBuilder referConnGenNamespaceBuilder,
            NOAI_l0Connection_ConnGenContext context)
        {
            if (!context.InputTypeReferenceSet.ContainsKey(currentTypeInfo))
            {
                context.InputTypeReferenceSet.Add(currentTypeInfo, new List<TypeInfo>());
            }

            var referConnGenProperties = CodeReflectableCSharpCode(referTypeInfo, context);
            if (string.IsNullOrEmpty(referConnGenProperties.Name))
            {
                return referConnGenProperties;
            }

            if (!context.InputTypeReferenceSet[currentTypeInfo].Contains(referTypeInfo))
            {
                context.InputTypeReferenceSet[currentTypeInfo].Add(referTypeInfo);
            }

            if (referCodedReflectableNamespace.Contains(referConnGenProperties.Namespace))
            {
                return referConnGenProperties;
            }

            referCodedReflectableNamespace.Add(referConnGenProperties.Namespace);
            referConnGenNamespaceBuilder.AppendLine("using " + referConnGenProperties.Namespace + ";");

            return referConnGenProperties;
        }

    }
}
