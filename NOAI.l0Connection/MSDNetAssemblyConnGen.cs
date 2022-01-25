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
        public void CodeReflectableCSharpCode(TypeInfo typeInfo, NOAI_l0Connection_ConnGenContext context)
        {
            var builder = new StringBuilder();
            builder.AppendLine(context.CodeGlobalConnGenRefNameCSharpCode());
            builder.AppendLine("");

            var ns = "NOAI_" +
                context.FixWin32PathSymbol(typeInfo.AssemblyQualifiedName ?? "") + "_" +
                context.FixWin32PathSymbol(context.ContextDate.ToUniversalTime().ToLongTimeString());
            builder.AppendLine("namespace " + ns);
            builder.AppendLine("{");

            context.CodeMemberDocumentBlockCSharpCode(typeInfo, 1, builder);

            NOAI_l0Connection_TypeConnGenProperties properties;
            builder.AppendLine("\t" + context.CodeTypeConnGenPropertiesCSharpCode(typeInfo, out properties));
            builder.AppendLine("\tpublic " + (properties.IsStatic ? "static " : "/*static*/ ") + "class " + typeInfo.Name + "");
            builder.AppendLine("\t{");

            builder.AppendLine("\t\tprivate " + (properties.IsStatic ? "static " : "/*static*/ ") + properties.Namespace + "." +
                properties.Name + " _NOAI_l0Connection_BaseInstance;");
            builder.AppendLine("");

            foreach (var i in typeInfo.DeclaredConstructors)
            {
                context.CodeMemberDocumentBlockCSharpCode(i, 2, builder);

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
                context.CodeMemberDocumentBlockCSharpCode(i, 2, builder);
                context.CodeMemberAttributeBlockCSharpCode(i, 2, builder);

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

            if (!Directory.Exists(context.FixWin32PathSymbol(context.OutputCodeFileDirectory)))
            {
                Directory.CreateDirectory(context.FixWin32PathSymbol(context.OutputCodeFileDirectory));
            }

            var path = context.FixWin32PathSymbol(Path.Combine(context.OutputCodeFileDirectory, ns + "_" + typeInfo.Name));
            File.WriteAllTextAsync(
                context.FixWin32PathLength(path, ".cs"),
                builder.ToString());
        }

        public void CodeReflectableCSharpCode(Assembly assembly, NOAI_l0Connection_ConnGenContext context)
        {
            Parallel.ForEach(assembly.ExportedTypes, i =>
             {
                 CodeReflectableCSharpCode(i.GetTypeInfo(), context);

             });

        }
    }
}
