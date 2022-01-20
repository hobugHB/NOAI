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

            TypeConnGenAttribute attribute;
            builder.AppendLine("\t" + context.CodeConnGenAttribute(typeInfo, out attribute));
            builder.AppendLine("\tpublic " + (attribute.IsStaticType ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
            builder.AppendLine("\t{");

            builder.AppendLine("\t\tprivate " + attribute.Namespace + "." + attribute.Name + " _NOAI_l0Connection_BaseInstance;");
            builder.AppendLine("");

            builder.AppendLine("\t\tpublic " + attribute.Name + "()");
            builder.AppendLine("\t\t{");
            builder.AppendLine("\t\t\t_NOAI_l0Connection_BaseInstance = new " + attribute.Namespace + "." + attribute.Name + "();");
            builder.AppendLine("\t\t}");
            builder.AppendLine("");

            foreach (var i in typeInfo.DeclaredProperties)
            {
                builder.AppendLine("\t\tpublic " + i.PropertyType.FullName + " " + i.Name);
                builder.AppendLine("\t\t{");
                if (i.CanRead)
                {
                    builder.AppendLine("\t\t\tget { return _NOAI_l0Connection_BaseInstance." + i.Name + "; }");
                }
                if (i.CanWrite)
                {
                    builder.AppendLine("\t\t\tset { _NOAI_l0Connection_BaseInstance." + i.Name + " = value; }");
                }
                builder.AppendLine("\t\t}");
            }
            builder.AppendLine("");

            foreach (var i in typeInfo.DeclaredMethods)
            {
                if (i.Name.StartsWith("get_"))
                {
                    continue;
                }
                if (i.Name.StartsWith("set_"))
                {
                    continue;
                }

                builder.AppendLine("\t\tpublic " + 
                    (i.ReturnType.FullName == "System.Void" ? "void" : i.ReturnType.FullName) +
                    " " + i.Name + "()");
                builder.AppendLine("\t\t{");
                builder.AppendLine("\t\t\treturn _NOAI_l0Connection_BaseInstance();");
                builder.AppendLine("\t\t}");
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
            Parallel.ForEach(assembly.ExportedTypes, i =>
             {
                 CodeConnMembers(i.GetTypeInfo(), context);

             });

        }
    }
}
