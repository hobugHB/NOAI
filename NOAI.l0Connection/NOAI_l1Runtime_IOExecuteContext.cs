using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class NOAI_l1Runtime_IOExecuteContext
    {
        public static readonly object Empty = new object();

        public Action IOAction { get; set; }

        public Func<object> IOFunc0 { get; set; }

        public object Execute()
        {
            if(IOAction != null)
            {
                IOAction();

                return Empty;
            }

            if (IOFunc0 != null)
            {
                return IOFunc0();
            }

            throw new ArgumentException("IO executable is not found.");
        }
    }
}
