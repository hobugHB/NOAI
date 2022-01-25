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
        public void CodeReflectableObject(TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context)
        {
            var builder = new StringBuilder();
            builder.AppendLine(context.CodeRefNamespace());
            builder.AppendLine("");

            var ns = "NOAI_" +
                context.FixPathSymbol(typeInfo.AssemblyQualifiedName ?? "") + "_" +
                context.FixPathSymbol(context.ContextDate.ToUniversalTime().ToLongTimeString());
            builder.AppendLine("namespace " + ns);
            builder.AppendLine("{");

            CodeDocumentation(context, builder, typeInfo, 1);

            NOAI_l0Connection_TypeConnGenProperties properties;
            builder.AppendLine("\t" + context.CodeConnGenTypeProperties_MSDNetTypeAttribute(typeInfo, out properties));
            builder.AppendLine("\tpublic " + (properties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
            builder.AppendLine("\t{");

            builder.AppendLine("\t\tprivate " + (properties.IsStatic ? "static " : "/*static*/ ") + properties.Namespace + "." +
                properties.Name + " _NOAI_l0Connection_BaseInstance;");
            builder.AppendLine("");

            foreach (var i in typeInfo.DeclaredConstructors)
            {
                CodeDocumentation(context, builder, i, 2);

                var ps = i.GetParameters();
                builder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") + properties.Name +
                    "(" + string.Join(", ", ps.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                builder.AppendLine("\t\t{");
                builder.AppendLine("\t\t\t_NOAI_l0Connection_BaseInstance = new " + properties.Namespace + "." + properties.Name +
                    "(" + string.Join(", ", ps.Select(p => p.Name)) + ")");
                builder.AppendLine("\t\t}");
                builder.AppendLine("");
            }

            foreach (var i in typeInfo.DeclaredProperties)
            {
                CodeDocumentation(context, builder, i, 2);

                builder.AppendLine("\t\tpublic " + (properties.IsStatic ? "static " : "/*static*/ ") + i.PropertyType.FullName + " " + i.Name);
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
                builder.AppendLine("");
            }

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

                var ps = i.GetParameters();
                builder.AppendLine("\t\tpublic " + (i.IsStatic ? "static " : "/*static*/ ") +
                    (i.ReturnType.FullName == "System.Void" ? "void" : i.ReturnType.FullName) +
                    " " + i.Name + "(" + string.Join(", ", ps.Select(p => p.ParameterType.FullName + " " + p.Name)) + ")");
                builder.AppendLine("\t\t{");
                builder.AppendLine("\t\t\treturn _NOAI_l0Connection_BaseInstance." + i.Name +
                    "(" + string.Join(", ", ps.Select(p => p.Name)) + ")");
                builder.AppendLine("\t\t}");
                builder.AppendLine("");
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

        private static void CodeDocumentation(NOAI_l0Connection_ConnGenContext context, StringBuilder builder, MemberInfo i, int deep)
        {
            var header = string.Join("", new int[deep].Select(z => "\t")) + "/// ";

            builder.AppendLine(header +
                String.Join(Environment.NewLine+ header,
                (i.GetDocumentation(context.AssemblyXmlDocFilesStore) ?? "").
                Trim('\r').Trim('\n').Trim('\t').Trim(' ').Trim('\r').Trim('\n').
                Replace('\n', '\r').Replace("\r\r", "\r").Replace("\r", Environment.NewLine).
                Split(Environment.NewLine).Select(z=>z.Trim())));
        }

        public void CodeReflectableObject(Assembly assembly, NOAI_l0Connection_ConnGenContext context)
        {
            Parallel.ForEach(assembly.ExportedTypes, i =>
             {
                 CodeReflectableObject(i.GetTypeInfo(), context);

             });

        }
    }
}
