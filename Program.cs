using System;

namespace KD_Testing
{
    class Program
    {
        int a = 1;
        long b = 123L;
        float c = 1.1f;
        double d = 1.123d;
        bool e = true;
        char f = 'A';
        string g = "ANDY";

        public void int_datatype()
        {
            Console.WriteLine("int = " + a);
        }
        public void long_datatype()
        { Console.WriteLine("long = " + b); }
        public void float_datatype()
        { Console.WriteLine("float = " + c); }
        public void double_datatype()
        { Console.WriteLine("double = " + d); }
        public void bool_datatype()
        { Console.WriteLine("bool = " + e); }
        public void char_datatype()
        { Console.WriteLine("char = " + f); }
        public void string_datatype()
        { Console.WriteLine("string = " + g); }

        public void read_type()
        {
           
           string c=  Console.ReadLine();
            int h = Convert.ToInt32(c);
            Console.WriteLine(h +a );
        }

       

       




    }
}
