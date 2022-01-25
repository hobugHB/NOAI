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
        public void Test_CodeReflectableObject_SystemString_Assembly()
        {
            var context = new NOAI_l0Connection_ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(string).Assembly.CodeBase);

            new MSDNetAssemblyConnGen().CodeReflectableObject(
                typeof(string).Assembly, context);
        }

        [TestMethod]
        public void Test_CodeReflectableObject_SystemConsole_Type()
        {
            var context = new NOAI_l0Connection_ConnGenContext();
            context.Output = "Test_CodeConnMembers_" +
                Path.GetFileName(typeof(Console).Assembly.CodeBase);
            context.AssemblyXmlDocFilesStore = @"C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.1\ref\net6.0";

            new MSDNetAssemblyConnGen().CodeReflectableObject(
                typeof(Console).GetTypeInfo(), context);
        }
    }
}