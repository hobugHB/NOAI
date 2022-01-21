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
        public void TestCodeConnMembers_System_String_Assembly()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(string).Assembly, context);
        }

        [TestMethod]
        public void TestCodeConnMembers_System_Console()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(Console).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(Console).GetTypeInfo(), context);
        }
    }
}