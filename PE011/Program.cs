using System;

namespace PE011
{
    class A
    {
        private int a=10;
        public int B { get; set; }
        public virtual int Test()
        {
            return a;
        }
    }
    class B:A
    {
        public string GetStringFromObject(object o)=>o.ToString();
        public int A { get; set; }
        public override int Test()
        {
            return 25;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            i =i + 10;

            #region Виводимо на екран
            Console.WriteLine("Hello World!");
            #endregion

            var b = new B();
            b.Test();
            var a = (A)b;
            a.Test();
        }
    }
}
