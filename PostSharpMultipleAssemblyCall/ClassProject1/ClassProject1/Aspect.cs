using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using System.Diagnostics;
 
using System.Reflection;
 
using System.Web;
 

namespace ClassProject1
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method)]
    public class TestAspect : OnMethodBoundaryAspect
    {

        // This method is executed before the execution of target methods of this aspect.
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.Write("OnEntry Called");
        }

        // This method is executed upon successful completion of target methods of this aspect.
        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.Write("OnSuccess Called");
        }
    }
}
