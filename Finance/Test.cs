using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
   public class parent
    {
        public virtual void print()
        {
            Console.WriteLine("Parent");
        }
    }
    public class child:parent
    {
        public override void print()
        {
            Console.WriteLine("child");
        }
    }
}
