using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class ConnGenPropeties
    {
        public string Output { get; set; }

        public string FixPathSymbol(string path)
        {
            return (path ?? "").Replace(" ", "__").
                Replace(".", "__").Replace(",", "__").
                Replace("=", "__").Replace(":", "__");
        }
    }

    public class MSDNetAssemblyConnGen
    {
        public void CodeConnMembers(TypeInfo typeInfo, ConnGenPropeties prop)
        {
            StringBuilder builder = new StringBuilder();

            var ns = "NOAI_" +
                prop.FixPathSymbol(typeInfo.AssemblyQualifiedName) + "_" +
                prop.FixPathSymbol(DateTime.Now.ToUniversalTime().ToLongTimeString());
            builder.AppendLine("namespace " + ns);
            builder.AppendLine("{");

            builder.AppendLine("\tpublic class " + typeInfo.Name + "");
            builder.AppendLine("\t{");
            foreach (var i in typeInfo.DeclaredMembers)
            {

            }
            builder.AppendLine("\t}");

            builder.AppendLine("}");

            if (!Directory.Exists(prop.FixPathSymbol(prop.Output)))
            {
                Directory.CreateDirectory(prop.FixPathSymbol(prop.Output));
            }

            var path = prop.FixPathSymbol(Path.Combine(prop.Output, ns + "_" + typeInfo.Name));
            File.WriteAllTextAsync(
                path.Substring(0, path.Length < 250 ? path.Length : 250) + ".cs",
                builder.ToString());
        }

        public void CodeConnMembers(Assembly assembly, ConnGenPropeties prop)
        {
            foreach (var i in assembly.ExportedTypes)
            {
                CodeConnMembers(i.GetTypeInfo(), prop);

            }

        }
    }
}
