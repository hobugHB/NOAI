using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NOAI.l0Connection.TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CodeReflectableCSharpCode_SystemString_Assembly()
        {
            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                context.OutputCodeFileDirectory = "Test_CodeReflectableCSharpCode_" +
                    Path.GetFileName(typeof(string).Assembly.CodeBase);

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(string).Assembly, context);
            }
        }

        [TestMethod]
        public void Test_CodeReflectableCSharpCode_SystemConsole_Type()
        {
            using (var context = new NOAI_l0Connection_ConnGenContext())
            {
                context.OutputCodeFileDirectory = "Test_CodeReflectableCSharpCode_" +
                Path.GetFileName(typeof(Console).Assembly.CodeBase);
                context.AssemblyXmlDocFileDirectory = @"C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.1\ref\net6.0";

                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(
                    typeof(Console).GetTypeInfo(), context);
            }
        }
    }
}