using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class NOAI_l0Connection_TypeConnOutputContext
    {
        public Guid ContextGuid { get; set; } = Guid.NewGuid();
        public string OutputFileContextPath { get; set; }
        public string ContextPathNamespace { get; set; }
        public System.Reflection.TypeInfo TypeInfo { get; set; }
        public NOAI_l0Connection_TypeConnGenProperties Properties { get; set; }
        public StringBuilder ReferConnGenNamespaceBuilder { get; set; }
        public StringBuilder TypeConnGenBodyBuilder { get; set; }
    }
}
