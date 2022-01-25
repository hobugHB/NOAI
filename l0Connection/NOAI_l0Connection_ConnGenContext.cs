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
    public class NOAI_l0Connection_ConnGenContext
    {
        public string Output { get; set; } = "";

        public string AssemblyXmlDocFilesStore { get; set; } = "";

        public DateTime ContextDate { get; set; } = DateTime.Now;

        public string CodeRefNamespace()
        {
            var builder = new StringBuilder();
            builder.Append("using " + typeof(NOAI_l0Connection_ConnGenAttribute).Namespace + ";");
            return builder.ToString();
        }

        public string CodeConnGenTypeProperties_MSDNetTypeAttribute(TypeInfo typeInfo, out NOAI_l0Connection_TypeConnGenProperties properties)
        {
            properties = new NOAI_l0Connection_TypeConnGenProperties(typeInfo);
            properties.ContextDate = ContextDate;
            var builder = new StringBuilder();
            var errors = new List<Exception>();

            builder.Append(
                "[" + typeof(NOAI_l0Connection_ConnGenAttribute).Name + "(\r\n" +
                    "TypeInfoJson:\"" + JsonSerializer.Serialize(properties, options: new JsonSerializerOptions()
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
