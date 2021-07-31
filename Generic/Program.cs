using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Taner");
            Console.WriteLine(isimler.Length);
            isimler.Add("Haşim");
            Console.WriteLine(isimler.Length);
            foreach(var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
