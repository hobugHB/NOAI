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
using System.CodeDom.Compiler;
using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis;

namespace NOAI.l0Connection
{
    public class NOAI_l0Connection_ConnGenContext : IDisposable
    {
        public Guid ContextGuid { get; set; } = Guid.NewGuid();

        public DateTime ContextDate { get; set; } = DateTime.Now;

        public CSharpCodeProvider CSharpCodeProvider { get; set; } = new CSharpCodeProvider();

        public TypeInfo[] InputSetReflectableObjects { get; set; } = new TypeInfo[0];

        public Dictionary<TypeInfo, List<TypeInfo>> InputTypeReferenceSet { get; set; } =
            new Dictionary<TypeInfo, List<TypeInfo>>();

        public NOAI_l0Connection_TypeConnGenProperties[] OutputSetConnGenProperties { get; set; } =
            new NOAI_l0Connection_TypeConnGenProperties[0];

        public string OutputCodeFileBaseDirectory { get; set; } = "";

        public string OutputCodeAssemblyDirectory { get; set; } = "";

        private string _AssemblyXmlDocFileDirectory;

        public string AssemblyXmlDocFileDirectory
        {
            get
            {
                return _AssemblyXmlDocFileDirectory;
            }
            set
            {
                _AssemblyXmlDocFileDirectory = value;
            }
        }

        public Dictionary<string, NOAI_l0Connection_AssemblyConnOutputContext> OutputAssemblyContextSet =
            new Dictionary<string, NOAI_l0Connection_AssemblyConnOutputContext>();

        private List<NOAI_l0Connection_TypeConnOutputContext> outputContextList = new List<NOAI_l0Connection_TypeConnOutputContext>();
        private Dictionary<string, List<int>> outputDiskPathLengthDeltaList = new Dictionary<string, List<int>>();

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
            {
                pathOutputContext = Path.Combine(
                    this.FixWin32PathSymbol(Guid.NewGuid().ToString()));
                pathOutputContextWin32CSharpCode = Path.Combine(
                    pathOutputContext,
                    this.FixWin32PathSymbol("OutputContextWin32CSharpCode"));
            }

            if (Directory.Exists(pathOutputContextWin32CSharpCode))
            {
                Directory.Delete(pathOutputContextWin32CSharpCode, true);
            }
            if (!Directory.Exists(pathOutputContextWin32CSharpCode))
            {
                Directory.CreateDirectory(pathOutputContextWin32CSharpCode);
            }

            {
                var root = @"C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref";
                if (Directory.Exists(root))
                {
                    root = Path.Combine(root, FindSubDirectoryWithMaxVersionName(root));
                }
                if (Directory.Exists(root))
                {
                    root = Path.Combine(root, "ref");
                }
                if (Directory.Exists(root))
                {
                    root = Path.Combine(root, FindSubDirectoryWithMaxVersionName(root));
                }
                if (Directory.Exists(root))
                {
                    _AssemblyXmlDocFileDirectory = root;
                }
            }

        }

        private string FindSubDirectoryWithMaxVersionName(string dir)
        {
            return Directory.GetDirectories(dir).OrderBy(i => i.Sum(ii => (int)ii)).Reverse().FirstOrDefault();
        }

        public string GetFullName(TypeInfo typeInfo)
        {
            if (!string.IsNullOrEmpty(typeInfo.FullName))
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
                    "TypeInfoJson=\"" + JsonSerialize(properties).Replace("\"", "\\\"") + "\" \r\n" +
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
            if(string.IsNullOrEmpty(typeInfo.FullName))
            {
                return true;
            }

            return typeInfo.IsPrimitive ||
                typeInfo.FullName == "System.Void" ||
                typeInfo.FullName == "System.Object" ||
                typeInfo.FullName == "System.String" ||
                (typeInfo.IsByRef && typeInfo.FullName.StartsWith("System.") && 
                    Type.GetType(typeInfo.FullName.Substring(0, typeInfo.FullName.IndexOf("&"))).IsPrimitive);
        }

        public string CodeTypeNameInConnGenWithContext(TypeInfo typeInfo,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
        {
            var fullName = typeInfo.FullName;
            var shortName = typeInfo.Name;
            if (string.IsNullOrEmpty(fullName))
            {
                fullName = "System." + shortName;
            }

            var codeName = fullName;
            if (!IsConnGenHiddenCodeType(typeInfo))
            {
                codeName = shortName;
            }

            if (typeInfo.IsByRef)
            {
                codeName = codeName.Substring(0, codeName.IndexOf("&"));
            }

            if (typeInfo.GenericTypeArguments.Length > 0)
            {
                codeName = codeName.Substring(0, codeName.IndexOf("`")) + "<" + String.Join(", ",
                    typeInfo.GenericTypeArguments.Select(i =>
                        CodeTypeNameInConnGenWithContext(i.GetTypeInfo(), codeConnGenTypeHandler))) + ">";
            }

            if (typeInfo.IsByRef)
            {
                codeName = "out " + codeName;
            }

            return codeName;
        }

        public string CodeTypeNameInUnderlyingTypeBase(TypeInfo typeInfo,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
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

        public void CodeMemberAttributeBlockCSharpCode(MemberInfo i, int indent, StringBuilder builder,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
        {
            foreach (var attribute in i.CustomAttributes)
            {
                CodeMemberAttributeBlockCSharpCode(attribute, indent, builder,
                    CodeTypeNameInUnderlyingTypeBase, codeConnGenTypeHandler);
            }
        }

        public void CodeMemberAttributeBlockCSharpCode(CustomAttributeData i, int indent, StringBuilder builder,
            Func<TypeInfo, Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties>, string> codeTypeNameHandler,
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler)
        {
            var header = CodeIndentBlankHeader(indent);

            builder.AppendLine(header +
                "[" + codeTypeNameHandler(i.Constructor.DeclaringType.GetTypeInfo(), codeConnGenTypeHandler) + "(" +

                string.Join(",", i.ConstructorArguments.Select(arg =>
                    new Tuple<TypeInfo, object>(arg.ArgumentType.GetTypeInfo(), arg.Value)).Select(arg =>
                    {
                        return CodeObjectCSharpValueExpression(codeConnGenTypeHandler, arg);
                    }
            )) +

            ")]");
        }

        private string CodeObjectCSharpValueExpression(
            Func<TypeInfo, NOAI_l0Connection_TypeConnGenProperties> codeConnGenTypeHandler,
            Tuple<TypeInfo, object> arg)
        {
            using (var writer = new StringWriter())
            {
                if (arg.Item2 == null)
                {
                    writer.Write("null");
                }
                else if (arg.Item1 == typeof(Type).GetTypeInfo())
                {
                    writer.Write("typeof(" + CodeTypeNameInConnGenWithContext(((Type)arg.Item2).GetTypeInfo(), codeConnGenTypeHandler) + ")");
                }
                else if (arg.Item1 != typeof(string).GetTypeInfo() && typeof(System.Collections.IEnumerable).IsAssignableFrom(arg.Item1))
                {
                    CSharpCodeProvider.GenerateCodeFromExpression(
                         new CodeArrayCreateExpression(
                             arg.Item1,
                             ((System.Collections.IEnumerable)arg.Item2).AsQueryable().Cast<CustomAttributeTypedArgument>().AsEnumerable().
                                 Select(typeArg =>
                                 {
                                     return new CodePrimitiveExpression(typeArg.Value);
                                 }).
                                 ToArray()),
                        writer, null);
                }
                else
                {
                    CSharpCodeProvider.GenerateCodeFromExpression(
                        new CodePrimitiveExpression(arg.Item2), writer, null);
                }

                return writer.ToString();
            }
        }

        public void SaveOutputWin32AssemblyFiles()
        {
            var root = new FileInfo(typeof(object).Assembly.Location).Directory.FullName;
            var refers = new[]
            {
                //"System.Core.dll",
                "System.Private.CoreLib.dll",
                "System.Runtime.dll",
            }.
            Select(i => Path.Combine(root, i)).
            ToArray();

            foreach (var key in OutputAssemblyContextSet.Keys)
            {
                var outputContext = OutputAssemblyContextSet[key];

                CSharpCompilation compilation = CSharpCompilation.Create(key,
                    syntaxTrees: outputContext.InputCodeFileDirectorySet.SelectMany(i =>
                        new DirectoryInfo(Path.Combine(OutputCodeFileBaseDirectory, i)).
                            GetFiles("*.cs").Select(ii => CSharpSyntaxTree.ParseText(
                                File.ReadAllText(ii.FullName)))).ToArray(),
                    references: refers.Concat(new[]
                        {
                            "NOAI.l0Connection.dll",
                        }).
                        Concat(outputContext.InputCodeReferAssemblyFiles).
                        Select(i => Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(i)).
                        ToArray(),
                    options: new CSharpCompilationOptions(
                        Microsoft.CodeAnalysis.OutputKind.DynamicallyLinkedLibrary));

                using (var ms = new MemoryStream())
                {
                    outputContext.EmitResult = compilation.Emit(ms);

                    if (outputContext.EmitResult.Success)
                    {
                        //    Assembly assembly = AssemblyLoadContext.Default.LoadFromStream(ms);

                        using (var file = new FileStream(
                            Path.Combine(OutputCodeAssemblyDirectory, key + ".dll"),
                            FileMode.Create, FileAccess.Write))
                        {
                            ms.WriteTo(file);
                        }
                    }
                }
            }
        }

        public string FixWin32PathSymbol(string path)
        {
            return (path ?? "").
                Replace(">", "__").
                Replace("<", "__").
                Replace(" ", "__").
                Replace(".", "__").
                Replace(",", "__").
                Replace("=", "__").
                Replace(":", "__").
                Replace("*", "__");
        }

        public void SaveOutputContextWin32CSharpCode(NOAI_l0Connection_TypeConnOutputContext outputContext)
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
                    this.OutputCodeFileBaseDirectory,
                    contextPathNamespace,
                    this.FixWin32PathSymbol(outputContext.Properties.Name) + ".cs"));
            var contextPathLength = contextPath.Length;
            var diskPathLength = contextPathLength;
            var diskPathLengthDelta = contextPathLength - 255;
            outputContext.ContextPathNamespace = contextPathNamespace;

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
                var path = this.OutputCodeFileBaseDirectory;
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
                    var diskPathNamespace = outputContext.ContextPathNamespace;
                    if (diskPathLengthDelta > 0)
                    {
                        diskPathNamespace = outputContext.ContextPathNamespace.Substring(0,
                            outputContext.ContextPathNamespace.Length - diskPathLengthDelta);
                    }

                    {
                        var path = Path.Combine(
                                this.OutputCodeFileBaseDirectory,
                                diskPathNamespace);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                    }

                    {
                        var assemblyName = i.First().Properties.AssemblyName;
                        if (!OutputAssemblyContextSet.ContainsKey(assemblyName))
                        {
                            OutputAssemblyContextSet.Add(assemblyName, new NOAI_l0Connection_AssemblyConnOutputContext()
                            {
                                AssemblyName = assemblyName,
                            });
                        }
                        var outputAssemblyContext = OutputAssemblyContextSet[assemblyName];
                        if (!outputAssemblyContext.InputCodeFileDirectorySet.Contains(diskPathNamespace))
                        {
                            outputAssemblyContext.InputCodeFileDirectorySet.Add(diskPathNamespace);
                        }

                        if (!outputAssemblyContext.InputCodeReferAssemblyFiles.Contains(outputContext.TypeInfo.Assembly.Location))
                        {
                            outputAssemblyContext.InputCodeReferAssemblyFiles.Add(outputContext.TypeInfo.Assembly.Location);
                        }
                        if (InputTypeReferenceSet.ContainsKey(outputContext.TypeInfo))
                        {
                            foreach (var r in InputTypeReferenceSet[outputContext.TypeInfo])
                            {
                                outputAssemblyContext.InputCodeReferAssemblyFiles.Add(r.Assembly.Location);
                            }
                        }

                        var path = Path.Combine(
                                this.OutputCodeFileBaseDirectory,
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
