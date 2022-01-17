using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace NOAI.l0Connection.TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeConnMembers(
                typeof(string).Assembly, context);
        }
    }
}