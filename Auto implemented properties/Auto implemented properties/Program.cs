using System;

namespace Auto_implemented_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect shape = new Rect { Length = 10.00, Width = 10.00 };

            Console.WriteLine(shape.getArea());
        }
    }
}
