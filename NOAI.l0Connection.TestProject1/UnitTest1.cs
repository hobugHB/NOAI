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
        public void TestCodeConnMembers_System_Private_CoreLib()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(string).Assembly, context);
        }

        [TestMethod]
        public void TestCodeConnMembers_System_Private_CoreLib_First()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(string).Assembly.GetExportedTypes().First().GetTypeInfo(), context);
        }

        [TestMethod]
        public void TestCodeConnMembers_System_Private_CoreLib_Console()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(string).Assembly.GetExportedTypes().Where(i=>i.Name.Contains("Console")).First().GetTypeInfo(), context);
        }
    }
}