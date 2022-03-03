using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection.TestProject1.TestCases.CodeReflectableCSharpCode
{
    public class ContextClasses
    {
        public NOAI_l0Connection_ConnGenContext FactorContext_SystemConsole_Type_Renew(
            UnitTest testInstance, bool testCodeSample, bool testAssemblySample)
        {
            var root = testInstance.GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            var context = new NOAI_l0Connection_ConnGenContext();
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(Console).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);

                if (testCodeSample)
                {
                    context.SaveOutputWin32CSharpCode();

                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                        Where(i => new DirectoryInfo(i).Name.Contains("Console")).Single(), "Console.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\Console_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                if (testAssemblySample)
                {
                    context.SaveOutputWin32AssemblyFiles();
                }

                return context;
            }
        }

        public NOAI_l0Connection_ConnGenContext FactorContext_SystemReflectionAssemblyHashAlgorithm_Type_Renew(
            UnitTest testInstance, bool testCodeSample, bool testAssemblySample)
        {
            var root = testInstance.GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            var context = new NOAI_l0Connection_ConnGenContext();
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(AssemblyHashAlgorithm).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);

                if (testCodeSample)
                {
                    context.SaveOutputWin32CSharpCode();

                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("Metadata")).Single(), "AssemblyHashAlgorithm.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\AssemblyHashAlgorithm_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                if (testAssemblySample)
                {
                    context.SaveOutputWin32AssemblyFiles();
                }

                return context;
            }
        }

        public NOAI_l0Connection_ConnGenContext FactorContext_ClassWithTuple2_Type_Renew(
            UnitTest testInstance, bool testCodeSample, bool testAssemblySample)
        {
            var root = testInstance.GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            var context = new NOAI_l0Connection_ConnGenContext();
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(ClassWithTuple2).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);

                if (testCodeSample)
                {
                    context.SaveOutputWin32CSharpCode();

                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("CodeReflectableCSharpCode")).Single(), "ClassWithTuple2.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\ClassWithTuple2_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                if (testAssemblySample)
                {
                    context.SaveOutputWin32AssemblyFiles();
                }

                return context;
            }
        }

        public NOAI_l0Connection_ConnGenContext FactorContext_ClassWithOut1_Type_Renew(
            UnitTest testInstance, bool testCodeSample, bool testAssemblySample)
        {
            var root = testInstance.GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            var context = new NOAI_l0Connection_ConnGenContext();
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(ClassWithOut1).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);

                if (testCodeSample)
                {
                    context.SaveOutputWin32CSharpCode();

                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("CodeReflectableCSharpCode")).Single(), "ClassWithOut1.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\ClassWithOut1_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                if (testAssemblySample)
                {
                    context.SaveOutputWin32AssemblyFiles();
                }

                return context;
            }
        }

        public NOAI_l0Connection_ConnGenContext FactorContext_ClassWithObject1_Type_Renew(
            UnitTest testInstance, bool testCodeSample, bool testAssemblySample)
        {
            var root = testInstance.GetAvialibleTestMethodOutputRoot();
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }

            var context = new NOAI_l0Connection_ConnGenContext();
            {
                context.ContextGuid = Guid.Empty;
                context.ContextDate = DateTime.MinValue;

                context.OutputCodeFileBaseDirectory = root;
                context.OutputCodeAssemblyDirectory = root;

                context.InputSetReflectableObjects = new TypeInfo[]
                {
                    typeof(ClassWithObject1).GetTypeInfo(),
                };
                new MSDNetAssemblyConnGen().CodeReflectableCSharpCode(context);

                if (testCodeSample)
                {
                    context.SaveOutputWin32CSharpCode();

                    var result = File.ReadAllText(Path.Combine(root, Directory.GetDirectories(root).
                    Where(i => new DirectoryInfo(i).Name.Contains("CodeReflectableCSharpCode")).Single(), "ClassWithObject1.cs"));
                    var sample = File.ReadAllText(@"TestCases\CodeReflectableCSharpCode\ClassWithObject1_1.cs");
                    if (!result.SequenceEqual(sample))
                    {
                        throw new Exception("result is not equals to sample.");
                    }
                }

                if (testAssemblySample)
                {
                    context.SaveOutputWin32AssemblyFiles();
                }

                return context;
            }
        }
    }
}
