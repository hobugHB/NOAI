using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NOAI.l0Connection
{
    public class ConnGenContext
    {
        public string Output { get; set; } = "";

        public string CodeRefNamespace()
        {
            var builder = new StringBuilder();
            builder.Append("using NOAI.l0Connection;");
            return builder.ToString();
        }

        private object ExtractData(Func<object> extract)
        {
            try
            {
                return extract();
            }
            catch
            {
                return null;
            }
        }

        public string CodeConnGenAttribute(TypeInfo typeInfo)
        {
            var builder = new StringBuilder();
            var errors = new List<Exception>();

            var typeAssemblyName = typeInfo.Assembly.GetName();
            builder.Append(
                "[ConnGen(\r\n" +
                    "TypeInfoJson:\"" + JsonConvert.SerializeObject(new
                    {
                        Namespace = ExtractData(() => typeInfo.Namespace),

                        GUID = ExtractData(() => typeInfo.GUID),
                        Attributes = ExtractData(() => typeInfo.Attributes),

                        GenericParameterAttributes = ExtractData(() => typeInfo.GenericParameterAttributes),
                        GenericParameterPosition = ExtractData(() => typeInfo.GenericParameterPosition),
                        GenericTypeArguments = ExtractData(() => typeInfo.GenericTypeArguments),
                        GenericTypeParameters = ExtractData(() => typeInfo.GenericTypeParameters),

                        HasElementType = ExtractData(() => typeInfo.HasElementType),
                        IsAbstract = ExtractData(() => typeInfo.IsAbstract),
                        IsAnsiClass = ExtractData(() => typeInfo.IsAnsiClass),
                        IsArray = ExtractData(() => typeInfo.IsArray),
                        IsAutoClass = ExtractData(() => typeInfo.IsAutoClass),
                        IsAutoLayout = ExtractData(() => typeInfo.IsAutoLayout),
                        IsByRef = ExtractData(() => typeInfo.IsByRef),
                        IsByRefLike = ExtractData(() => typeInfo.IsByRefLike),
                        IsClass = ExtractData(() => typeInfo.IsClass),

                        AssemblyName = new
                        {
                            Name = ExtractData(() => typeAssemblyName.Name),
                        },
                    }).Replace("\"", "\\\"") + "\", \r\n" +
                ")]");
            return builder.ToString();
        }

        public string FixPathSymbol(string path)
        {
            return (path ?? "").Replace(" ", "__").
                Replace(".", "__").Replace(",", "__").
                Replace("=", "__").Replace(":", "__");
        }

        public string FixPathLength(string path, string extension)
        {
            if (string.IsNullOrEmpty(path))
            {
                return extension;
            }

            var maxSubLength = 255 - (extension ?? "").Length;
            var fullPath = Path.GetFullPath(path);

            return fullPath.Substring(0, fullPath.Length < maxSubLength ? fullPath.Length : maxSubLength) + extension;
        }
    }
}
