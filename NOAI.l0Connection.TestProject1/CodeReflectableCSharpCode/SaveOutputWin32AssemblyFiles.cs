using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NOAI.l0Connection.TestProject1.CodeReflectableCSharpCode
{
    [TestClass]
    public class SaveOutputWin32AssemblyFiles : UnitTest
    {
        [TestMethod]
        public void Test_SystemConsole_Type_Renew()
        {
            var root = GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(Console).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);
                context.SaveOutputWin32CSharpCode();

                {
                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                        Where(i => new DirectoryInfo(i).Name.Contains("Console")).Single(), "Console.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\Console_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                {
                    context.SaveOutputWin32AssemblyFiles();
                }
            }
        }
    }
}