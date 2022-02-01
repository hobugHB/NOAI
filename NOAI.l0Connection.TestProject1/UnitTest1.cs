using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NOAI.l0Connection.TestProject1
{
    [TestClass]
    public class CodeReflectableCSharpCode_UnitTest1
    {
        [TestMethod]
        public void Test_SystemString_Assembly()
        {
            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                context.OutputCodeFileDirectory = Path.Combine(
                    "e:\\Test_CodeReflectableCSharpCode",
                    Path.GetFileName(typeof(string).Assembly.CodeBase));

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(string).Assembly, context);
                context.SaveOutputWin32CSharpCode();
            }
        }

        [TestMethod]
        public void Test_SystemConsole_Type_Renew()
        {
            var root = 
                "e:\\Test_CodeReflectableCSharpCode_SystemConsole_Type_Renew";
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileDirectory = Path.Combine(root,
                    Path.GetFileName(typeof(Console).Assembly.CodeBase));
                context.AssemblyXmlDocFileDirectory = @"C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.1\ref\net6.0";

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(Console).GetTypeInfo(), context);
                context.SaveOutputWin32CSharpCode();
            }
        }
    }
}