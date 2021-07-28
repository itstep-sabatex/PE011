using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE011
{
    public class DemoClass
    {
        public int MaxPower;
        private int _maxPower;
        public int Add(ref string a,params object[] maxPower)
        {
            a = "Hello";
            return 1;
        }
        public int Add(ref string a) => Add(ref a, 10);
 

    }
    public abstract class ADemoClass
    {
        public abstract int A { get; set; }
    }
    public interface IDemoClass
    {
        int A { get; set; }
    }
    public class B:IDemoClass
    {
        int a;
        public int A { get=>a; set=>a=value; }
    }



}
