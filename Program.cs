using System;

namespace ConsoleAppCSharpRefresh
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");  // various datatypes
            byte b = 75; //character k=75
            float.Parse(b.ToString(""));  // parsing value to string
            Console.WriteLine(b);
            char c = 'K';
            Console.WriteLine(c);
            string s = "KLM";
            Console.WriteLine(s);

            Int16 n16 = 123;
            Console.WriteLine(n16);
            //UInt16 nInt16 = 123;
            //Int32 n32 = 243;
            //UInt32 nInt32 = 1223;
            //Int64 n64 = 456;
            //UInt64 nInt64 = 3434;


            Method();
            Console.ReadLine();
        }

        //class Foo       // variables example for categories
        //{
        //    public static int a; // static field
        //    string b; // instance field

        //    public void Bar(object obj, ref string x, out long y)
        //    // obj - value paramter
        //    // x - reference parameter 
        //    // y - output parameter
        //    {
        //        int[] i = new int[10]; // array elements
        //        int l; // local variable
        //    }
        //    //‘a’ is a static field
        //    //‘b’ is an instance field
        //    //‘obj’ is a value parameter
        //    //‘x’ is a reference parameter
        //    //‘y’ is an output parameter
        //    //‘i[0]’ is an array element
        //    //‘l’ is a local variable
        //}
        public static void Method()
        {
            var X = Foo.X;
        }
        class Foo
        {
            static object o;
            static Foo()
            {
                Console.WriteLine("The value of variable 'o' is " + (o ?? "null"));
            }
            public static int X { get; set; }
        }
    }
}
