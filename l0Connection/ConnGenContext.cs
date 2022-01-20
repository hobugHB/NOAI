using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public string CodeConnGenAttribute(TypeInfo typeInfo, out TypeConnGenAttribute attribute)
        {
            attribute = new TypeConnGenAttribute(typeInfo);
            var builder = new StringBuilder();
            var errors = new List<Exception>();

            builder.Append(
                "[ConnGen(\r\n" +
                    "TypeInfoJson:\"" + JsonSerializer.Serialize(attribute, options: new JsonSerializerOptions()
                    {
                        ReferenceHandler = ReferenceHandler.Preserve,
                    }).
                    Replace("\"", "\\\"") + "\", \r\n" +
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
