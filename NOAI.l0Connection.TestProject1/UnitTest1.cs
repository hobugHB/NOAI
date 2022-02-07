using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NOAI.l0Connection.TestProject1
{
    [TestClass]
    public class CodeReflectableCSharpCode_UnitTest1 : UnitTest
    {
        [TestMethod]
        public void Test_SystemString_Assembly()
        {
            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                var root = GetAvialibleTestMethodOutputRoot();
                context.OutputCodeFileDirectory = root;

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(string).Assembly, context);
                context.SaveOutputWin32CSharpCode();
            }
        }

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

                context.OutputCodeFileDirectory = root;

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(Console).GetTypeInfo(), context);
                context.SaveOutputWin32CSharpCode();
            }
        }
    }
}