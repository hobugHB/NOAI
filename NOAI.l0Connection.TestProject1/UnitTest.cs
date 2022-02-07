using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NOAI.l0Connection.TestProject1
{
    [TestClass]
    public class UnitTest
    {
        public TestContext TestContext { get; set; }

        public string GetAvialibleTestMethodOutputRoot()
        {
            var root = DriveInfo.GetDrives().OrderBy(i => i.AvailableFreeSpace).Reverse().First().RootDirectory.Name;
            root = Path.Combine(root,
                TestContext.FullyQualifiedTestClassName.Substring(
                TestContext.FullyQualifiedTestClassName.LastIndexOf('.') + 1),
                TestContext.TestName);
            return root;
        }
    }
}