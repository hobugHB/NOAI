using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.CSharp;
using System.CodeDom;

namespace NOAI.l0Connection
{
    public class NOAI_l0Connection_ConnGenContext : IDisposable
    {
        public Guid ContextGuid { get; set; } = Guid.NewGuid();

        public DateTime ContextDate { get; set; } = DateTime.Now;

        public CSharpCodeProvider CSharpCodeProvider { get; set; } = new CSharpCodeProvider();

        public string OutputCodeFileDirectory { get; set; } = "";

        public string AssemblyXmlDocFileDirectory { get; set; } = "";

        public string CodeTypeConnGenRefNameCSharpCode()
        {
            var builder = new StringBuilder();
            builder.Append("using " + typeof(NOAI_l0Connection_ConnGenAttribute).Namespace + ";");
            return builder.ToString();
        }

        public Dictionary<string, NOAI_l0Connection_TypeConnGenProperties> RequestedCodeTypeSet { get; set; } =
            new Dictionary<string, NOAI_l0Connection_TypeConnGenProperties>();

        private string pathOutputContext;
        private string pathOutputContextWin32CSharpCode;

        public NOAI_l0Connection_ConnGenContext()
        {
            pathOutputContext = Path.Combine(
                this.FixWin32PathSymbol(Guid.NewGuid().ToString()));
            pathOutputContextWin32CSharpCode = Path.Combine(
                pathOutputContext,
                this.FixWin32PathSymbol("OutputContextWin32CSharpCode"));

            if (Directory.Exists(pathOutputContextWin32CSharpCode))
            {
                Directory.Delete(pathOutputContextWin32CSharpCode, true);
            }
            if (!Directory.Exists(pathOutputContextWin32CSharpCode))
            {
                Directory.CreateDirectory(pathOutputContextWin32CSharpCode);
            }

        }

        public string GetFullName(TypeInfo typeInfo)
        {
            if(!string.IsNullOrEmpty(typeInfo.FullName))
            {
                return typeInfo.FullName;
            }

            return typeInfo.Assembly.FullName + "+" + typeInfo.Name;
        }

        public string CodeTypeConnGenPropertiesCSharpCode(TypeInfo typeInfo, out NOAI_l0Connection_TypeConnGenProperties properties)
        {
            properties = new NOAI_l0Connection_TypeConnGenProperties(typeInfo);
            properties.ContextGuid = ContextGuid;
            properties.ContextDate = ContextDate;
            var builder = new StringBuilder();
            var errors = new List<Exception>();

            builder.Append(
                "[" + typeof(NOAI_l0Connection_ConnGenAttribute).Name + "(\r\n" +
                    "TypeInfoJson:\"" + JsonSerialize(properties).Replace("\"", "\\\"") + "\", \r\n" +
                ")]");
            return builder.ToString();
        }

        private static string JsonSerialize(NOAI_l0Connection_TypeConnGenProperties properties)
        {
            try
            {
                return JsonSerializer.Serialize(properties, options: new JsonSerializerOptions()
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                });
            }
            catch (Exception ex)
            {
                return "{\"JsonSerializeErrors\":\"" + ex.ToString() + "\"}";
            }
        }

        public string CodeIndentBlankHeader(int indent)
        {
            return string.Join("", new int[indent].Select(z => "\t"));
        }

        public bool IsConnGenHiddenCodeType(TypeInfo typeInfo)
        {
            var isHiddenByValueFormInCodeManagedByUnderlyingTypeInfo = typeInfo.IsPrimitive;
            var isHiddenByValueFormInCodeManagedByUnderlyingCodeCompiler = typeInfo.FullName == "System.String";
            return isHiddenByValueFormInCodeManagedByUnderlyingTypeInfo ||
                isHiddenByValueFormInCodeManagedByUnderlyingCodeCompiler;
        }

        public string CodeTypeConnGenCodeBodyName(TypeInfo typeInfo)
        {
            if (IsConnGenHiddenCodeType(typeInfo))
            {
                return typeInfo.FullName;
            }

            return typeInfo.Name;
        }

        public string CodeTypeBaseInstanceCodeBodyName(TypeInfo typeInfo)
        {
            return typeInfo.FullName;
        }

        public void CodeMemberDocumentBlockCSharpCode(MemberInfo i, int indent, StringBuilder builder)
        {
            var header = CodeIndentBlankHeader(indent) + "/// ";

            builder.AppendLine(header +
                String.Join(Environment.NewLine + header,
                (i.GetDocumentation(AssemblyXmlDocFileDirectory) ?? "").
                Trim('\r').Trim('\n').Trim('\t').Trim(' ').Trim('\r').Trim('\n').
                Replace('\n', '\r').Replace("\r\r", "\r").Replace("\r", Environment.NewLine).
                Split(Environment.NewLine).Select(z => z.Trim())));
        }

        public void CodeMemberAttributeBlockCSharpCode(MemberInfo i, int indent, StringBuilder builder)
        {
            foreach (var attribute in i.CustomAttributes)
            {
                CodeMemberAttributeBlockCSharpCode(attribute, indent, builder,
                    CodeTypeBaseInstanceCodeBodyName);
            }
        }

        public void CodeMemberAttributeBlockCSharpCode(CustomAttributeData i, int indent, StringBuilder builder,
            Func<TypeInfo, string> getDeclaringTypeName)
        {
            var header = CodeIndentBlankHeader(indent);

            builder.AppendLine(header +
                "[" + getDeclaringTypeName(i.Constructor.DeclaringType.GetTypeInfo()) + "(" +

               string.Join(",", i.ConstructorArguments.Select(arg =>
               {
                   using (var writer = new StringWriter())
                   {
                       if (!(arg.Value is string) && typeof(System.Collections.IEnumerable).IsAssignableFrom(arg.Value.GetType()))
                       {
                           CSharpCodeProvider.GenerateCodeFromExpression(
                                new CodeArrayCreateExpression(
                                    arg.ArgumentType,
                                    ((System.Collections.IEnumerable)arg.Value).AsQueryable().Cast<CustomAttributeTypedArgument>().AsEnumerable().
                                        Select(v =>
                                        {
                                            return new CodePrimitiveExpression(v.Value);
                                        }).
                                        ToArray()),
                               writer, null);
                       }
                       else
                       {
                           CSharpCodeProvider.GenerateCodeFromExpression(
                               new CodePrimitiveExpression(arg.Value), writer, null);
                       }

                       return writer.ToString();
                   }
               }
            )) +

            ")]");
        }

        public string FixWin32PathSymbol(string path)
        {
            return (path ?? "").
                Replace(" ", "__").
                Replace(".", "__").
                Replace(",", "__").
                Replace("=", "__").
                Replace(":", "__").
                Replace("*", "__");
        }

        private List<NOAI_l0Connection_ConnGenOutputContext> outputContextList = new List<NOAI_l0Connection_ConnGenOutputContext>();
        private Dictionary<string, List<int>> outputDiskPathLengthDeltaList = new Dictionary<string, List<int>>();

        public void SaveOutputContextWin32CSharpCode(NOAI_l0Connection_ConnGenOutputContext outputContext)
        {
            outputContext.OutputFileContextPath = this.FixWin32PathSymbol(Path.Combine(
                pathOutputContextWin32CSharpCode,
                outputContext.ContextGuid.ToString() + ".cs"));
            var builder = new StringBuilder();
            builder.AppendLine(outputContext.ReferConnGenNamespaceBuilder.ToString());
            //builder.AppendLine("");
            builder.AppendLine(outputContext.TypeConnGenBodyBuilder.ToString());
            File.WriteAllTextAsync(outputContext.OutputFileContextPath, builder.ToString());

            var contextPathNamespace = this.FixWin32PathSymbol(outputContext.Properties.Namespace);
            var contextPath = Path.GetFullPath(Path.Combine(
                    this.OutputCodeFileDirectory,
                    contextPathNamespace,
                    this.FixWin32PathSymbol(outputContext.Properties.Name) + ".cs"));
            var contextPathLength = contextPath.Length;
            var diskPathLength = contextPathLength;
            var diskPathLengthDelta = contextPathLength - 255;
            outputContext.contextPathNamespace = contextPathNamespace;

            outputContextList.Add(outputContext);
            if (!outputDiskPathLengthDeltaList.ContainsKey(outputContext.Properties.Namespace))
            {
                outputDiskPathLengthDeltaList[outputContext.Properties.Namespace] = new List<int>();
            }
            outputDiskPathLengthDeltaList[outputContext.Properties.Namespace].Add(diskPathLengthDelta);
        }

        public void SaveOutputWin32CSharpCode()
        {
            {
                var path = this.OutputCodeFileDirectory;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }

            var group = outputContextList.GroupBy(i => i.Properties.Namespace);
            foreach (var i in group)
            {
                var diskPathLengthDelta = outputDiskPathLengthDeltaList[i.Key].Max();
                foreach (var outputContext in i)
                {
                    var diskPathNamespace = outputContext.contextPathNamespace;
                    if (diskPathLengthDelta > 0)
                    {
                        diskPathNamespace = outputContext.contextPathNamespace.Substring(0,
                            outputContext.contextPathNamespace.Length - diskPathLengthDelta);
                    }

                    {
                        var path = Path.Combine(
                                this.OutputCodeFileDirectory,
                                diskPathNamespace);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                    }

                    {
                        var path = Path.Combine(
                                this.OutputCodeFileDirectory,
                                diskPathNamespace,
                                this.FixWin32PathSymbol(outputContext.Properties.Name) + ".cs");

                        File.Move(outputContext.OutputFileContextPath, path);
                    }
                }
            }
        }

        public void Dispose()
        {
            CSharpCodeProvider.Dispose();

            if (Directory.Exists(pathOutputContext))
            {
                Directory.Delete(pathOutputContext, true);
            }
        }
    }
}
