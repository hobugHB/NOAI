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
        public void TestCodeReflectable_System_String_Assembly()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeReflectable(
                typeof(string).Assembly, context);
        }

        [TestMethod]
        public void TestReflectable_System_Console()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(Console).Assembly.CodeBase);
            context.AssemblyXmlDocFilesStore = @"C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.1\ref\net6.0";

            new MSDNetAssemblyConnGen().CodeReflectable(
                typeof(Console).GetTypeInfo(), context);
        }
    }
}