using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOAI.l0Connection
{
    public class NOAI_l1Runtime_IOCenterContext
    {
        public static readonly NOAI_l1Runtime_IOCenterContext Instance = new NOAI_l1Runtime_IOCenterContext();

        public void Write(Action action)
        {
            EnterIOMonitorFlow(action);
        }

        public T Read<T>(Func<T> action)
        {
            return EnterIOMonitorFlow(action);
        }

        private void EnterIOMonitorFlow(Action action)
        {
            var context = new NOAI_l1Runtime_IOExecuteContext()
            {
                IOAction = action,
            };
            context.Execute();
        }

        private T EnterIOMonitorFlow<T>(Func<T> action)
        {
            var context = new NOAI_l1Runtime_IOExecuteContext()
            {
                IOFunc0 = () => action,
            };
            return (T)context.Execute();
        }
    }
}
