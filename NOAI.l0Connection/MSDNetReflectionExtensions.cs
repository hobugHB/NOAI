using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace NOAI.l0Connection
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// https://docs.microsoft.com/en-us/archive/msdn-magazine/2019/october/csharp-accessing-xml-documentation-via-reflection
    /// </remarks>
    public static class MSDNetReflectionExtensions
    {
        internal static Dictionary<string, string> loadedXmlDocumentation =
     new Dictionary<string, string>();

        public static void LoadXmlDocumentation(string xmlDocumentation)
        {
            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlDocumentation)))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "member")
                    {
                        string raw_name = xmlReader["name"];
                        loadedXmlDocumentation[raw_name] = xmlReader.ReadInnerXml();
                    }
                }
            }
        }

        // Helper method to format the key strings
        private static string XmlDocumentationKeyHelper(
          string typeFullNameString,
          string memberNameString)
        {
            string key = Regex.Replace(
              typeFullNameString, @"\[.*\]",
              string.Empty).Replace('+', '.');
            if (memberNameString != null)
            {
                key += "." + memberNameString;
            }
            return key;
        }

        public static string GetDocumentation(this TypeInfo typeInfo, string assemblyXmlDocFilesStore)
        {
            LoadXmlDocumentation(typeInfo.Assembly, assemblyXmlDocFilesStore);
            //+		typeInfo	{Name = "IEnumerable`1" FullName = null}	System.Reflection.TypeInfo {System.RuntimeType}
            if (string.IsNullOrEmpty(typeInfo.FullName))
            {
                return "";
            }

            string key = "T:" + XmlDocumentationKeyHelper(typeInfo.FullName, null);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this FieldInfo fieldInfo, string assemblyXmlDocFilesStore)
        {
            if (string.IsNullOrEmpty(fieldInfo.DeclaringType.FullName))
            {
                return "";
            }

            string key = "F:" + XmlDocumentationKeyHelper(
              fieldInfo.DeclaringType.FullName, fieldInfo.Name);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this PropertyInfo propertyInfo, string assemblyXmlDocFilesStore)
        {
            if (string.IsNullOrEmpty(propertyInfo.DeclaringType.FullName))
            {
                return "";
            }

            string key = "P:" + XmlDocumentationKeyHelper(
              propertyInfo.DeclaringType.FullName, propertyInfo.Name);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this EventInfo eventInfo, string assemblyXmlDocFilesStore)
        {
            if (string.IsNullOrEmpty(eventInfo.DeclaringType.FullName))
            {
                return "";
            }

            string key = "E:" + XmlDocumentationKeyHelper(
              eventInfo.DeclaringType.FullName, eventInfo.Name);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this ConstructorInfo constructorInfo, string assemblyXmlDocFilesStore)
        {
            if (string.IsNullOrEmpty(constructorInfo.DeclaringType.FullName))
            {
                return "";
            }

            string key = "C:" + XmlDocumentationKeyHelper(
              constructorInfo.DeclaringType.FullName, constructorInfo.Name);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this MethodInfo methodInfo, string assemblyXmlDocFilesStore)
        {
            if (string.IsNullOrEmpty(methodInfo.DeclaringType.FullName))
            {
                return "";
            }

            string key = "M:" + XmlDocumentationKeyHelper(
              methodInfo.DeclaringType.FullName, methodInfo.Name);
            loadedXmlDocumentation.TryGetValue(key, out string documentation);
            return documentation;
        }

        public static string GetDocumentation(this MemberInfo memberInfo, string assemblyXmlDocFilesStore)
        {
            if (memberInfo.DeclaringType != null)
            {
                LoadXmlDocumentation(memberInfo.DeclaringType.Assembly, assemblyXmlDocFilesStore);
            }

            if (memberInfo.MemberType.HasFlag(MemberTypes.Field))
            {
                return ((FieldInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else if (memberInfo.MemberType.HasFlag(MemberTypes.Property))
            {
                return ((PropertyInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else if (memberInfo.MemberType.HasFlag(MemberTypes.Event))
            {
                return ((EventInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else if (memberInfo.MemberType.HasFlag(MemberTypes.Constructor))
            {
                return ((ConstructorInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else if (memberInfo.MemberType.HasFlag(MemberTypes.Method))
            {
                return ((MethodInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else if (memberInfo.MemberType.HasFlag(MemberTypes.TypeInfo) ||
              memberInfo.MemberType.HasFlag(MemberTypes.NestedType))
            {
                return ((TypeInfo)memberInfo).GetDocumentation(assemblyXmlDocFilesStore);
            }
            else
            {
                return null;
            }

        }

        public static string GetDocumentation(this ParameterInfo parameterInfo, string assemblyXmlDocFilesStore,
            NOAI_l0Connection_ConnGenContext context)
        {
            string memberDocumentation = parameterInfo.Member.GetDocumentation(assemblyXmlDocFilesStore);
            if (memberDocumentation != null)
            {
                string regexPattern =
                    Regex.Escape(@"<param name=" + "\"" +
                    context.CodeObjectNameInConnGenWithContext(parameterInfo.Name) + "\"" + @">") +
                    ".*?" +
                    Regex.Escape(@"</param>");
                Match match = Regex.Match(memberDocumentation, regexPattern);
                if (match.Success)
                {
                    return match.Value;
                }
            }
            return null;
        }
        public static string GetDirectoryPath(this Assembly assembly)
        {
            string codeBase = assembly.CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }

        internal static HashSet<Assembly> loadedAssemblies = new HashSet<Assembly>();

        internal static void LoadXmlDocumentation(Assembly assembly, string assemblyXmlDocFilesStore)
        {
            if (loadedAssemblies.Contains(assembly))
            {
                return; // Already loaded
            }
            string directoryPath = string.IsNullOrEmpty(assemblyXmlDocFilesStore) ? assembly.GetDirectoryPath() : assemblyXmlDocFilesStore;
            string xmlFilePath = Path.Combine(directoryPath, assembly.GetName().Name + ".xml");
            if (File.Exists(xmlFilePath))
            {
                LoadXmlDocumentation(File.ReadAllText(xmlFilePath));
                loadedAssemblies.Add(assembly);
            }
        }
    }
}
