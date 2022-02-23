using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class NOAI_l0Connection_AssemblyConnOutputContext
    {
        public string AssemblyName { get; set; }

        public List<string> InputCodeFileDirectorySet { get; set; } = new List<string>();

        public List<string> InputCodeReferAssemblySet { get; set; } = new List<string>();
    }
}
