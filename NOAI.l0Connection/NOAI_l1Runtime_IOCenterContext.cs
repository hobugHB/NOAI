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

        public void Enter(Action action)
        {
            EnterIOMonitorFlow(action);
        }

        public T Enter<T>(Func<T> action)
        {
            return EnterIOMonitorFlow(action);
        }

        private object EnterIOMonitorFlow(Action action)
        {
            var context = new NOAI_l1Runtime_IOExecuteContext()
            {
                IOAction = action,
            };
            return context.Execute();
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
