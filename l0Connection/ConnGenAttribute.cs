using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class ConnGenAttribute : Attribute
    {
        public string AssemblyQualifiedName { get; set; } = "";
        public string AssemblyCodeBase { get; set; } = "";
        public string Namespace { get; set; } = "";
    }
}
