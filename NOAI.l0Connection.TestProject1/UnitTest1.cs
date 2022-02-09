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

                var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("Console")).Single(), "Console.cs"));
                var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode_UnitTest1\Console_1.cs");
                if(!result.SequenceEqual(sample))
                {
                    throw new Exception("result is not equals to sample.");
                }
            }
        }

        [TestMethod]
        public void Test_MicrosoftWin32SafeHandlesSafeFileHandle_Type_Renew()
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
                    typeof(Microsoft.Win32.SafeHandles.SafeFileHandle).GetTypeInfo(), context);
                context.SaveOutputWin32CSharpCode();

                var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("SafeHandles")).Single(), "SafeFileHandle.cs"));
                var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode_UnitTest1\SafeFileHandle_1.cs");
                if (!result.SequenceEqual(sample))
                {
                    throw new Exception("result is not equals to sample.");
                }
            }
        }

        [TestMethod]
        public void Test_SystemReflectionAssemblyHashAlgorithm_Type_Renew()
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
                    typeof(AssemblyHashAlgorithm).GetTypeInfo(), context);
                context.SaveOutputWin32CSharpCode();

                var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("Metadata")).Single(), "AssemblyHashAlgorithm.cs"));
                var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode_UnitTest1\AssemblyHashAlgorithm_1.cs");
                if (!result.SequenceEqual(sample))
                {
                    throw new Exception("result is not equals to sample.");
                }
            }
        }

        [TestMethod]
        public void Test_SystemCollectionsIComparer_Type_Renew()
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
                    typeof(System.Collections.IComparer).GetTypeInfo(), context);
                context.SaveOutputWin32CSharpCode();

                var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("Collections")).Single(), "IComparer.cs"));
                var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode_UnitTest1\IComparer_1.cs");
                if (!result.SequenceEqual(sample))
                {
                    throw new Exception("result is not equals to sample.");
                }
            }
        }
    }
}