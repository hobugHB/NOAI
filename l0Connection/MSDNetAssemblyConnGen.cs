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
        public void CodeConnMembers(TypeInfo typeInfo, ConnGenContext context)
        {
            var builder = new StringBuilder();
            builder.AppendLine(context.CodeRefNamespace());
            builder.AppendLine("");

            var ns = "NOAI_" +
                context.FixPathSymbol(typeInfo.AssemblyQualifiedName ?? "") + "_" +
                context.FixPathSymbol(DateTime.Now.ToUniversalTime().ToLongTimeString());
            builder.AppendLine("namespace " + ns);
            builder.AppendLine("{");

            builder.AppendLine("\t" + context.CodeConnGenAttribute(typeInfo));
            builder.AppendLine("\tpublic class " + typeInfo.Name + "");
            builder.AppendLine("\t{");
            foreach (var i in typeInfo.DeclaredMembers)
            {

            }
            builder.AppendLine("\t}");

            builder.AppendLine("}");

            if (!Directory.Exists(context.FixPathSymbol(context.Output)))
            {
                Directory.CreateDirectory(context.FixPathSymbol(context.Output));
            }

            var path = context.FixPathSymbol(Path.Combine(context.Output, ns + "_" + typeInfo.Name));
            File.WriteAllTextAsync(
                context.FixPathLength(path, ".cs"),
                builder.ToString());
        }

        public void CodeConnMembers(Assembly assembly, ConnGenContext context)
        {
            foreach (var i in assembly.ExportedTypes)
            {
                CodeConnMembers(i.GetTypeInfo(), context);

            }

        }
    }
}
