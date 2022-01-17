using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public string CodeConnGenAttribute(TypeInfo typeInfo)
        {
            var builder = new StringBuilder();
            builder.Append("[ConnGen(\r\n" +
                "AssemblyQualifiedName:\"" + (typeInfo.AssemblyQualifiedName ?? "") + "\"), \r\n" +
                "AssemblyCodeBase:\"" + (typeInfo.Assembly.CodeBase ?? "") + "\", \r\n" +
                "Namespace:\"" + (typeInfo.Namespace ?? "") + "\")]");
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
