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
            using (var context = new TestCases.CodeReflectableCSharpCode.ContextClasses().
                FactorContext_SystemConsole_Type_Renew(this, true,  true))
            {
            }
        }

        [TestMethod]
        public void Test_SystemReflectionAssemblyHashAlgorithm_Type_Renew()
        {
            using (var context = new TestCases.CodeReflectableCSharpCode.ContextClasses().
                FactorContext_SystemReflectionAssemblyHashAlgorithm_Type_Renew(this, true, true))
            {
            }
        }

        [TestMethod]
        public void Test_ClassWithTuple2_Type_Renew()
        {
            using (var context = new TestCases.CodeReflectableCSharpCode.ContextClasses().
                FactorContext_ClassWithTuple2_Type_Renew(this, true, true))
            {
            }
        }

        [TestMethod]
        public void Test_ClassWithOut1_Type_Renew()
        {
            using (var context = new TestCases.CodeReflectableCSharpCode.ContextClasses().
                FactorContext_ClassWithOut1_Type_Renew(this, true, true))
            {
            }
        }
    }
}