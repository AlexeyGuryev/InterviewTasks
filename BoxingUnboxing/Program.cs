using System;

namespace BoxingUnboxing
{
    class Program
    {
        struct Foo
        {
            int _value;
            public override string ToString()
            {
                if (_value == 2)
                {
                    return "Baz";
                }
                else
                {
                    return _value++ == 0 ? "Foo" : "Bar";
                }
            }
        }

        static void Main()
        {
            var foo = new Foo();        // value = 0
            Console.WriteLine(foo);     // Foo
            Console.WriteLine(foo);     // Foo
            object bar = foo;
            object qux = foo;
            object baz = bar;
            Console.WriteLine(baz);     // Foo
            Console.WriteLine(bar);     // Bar
            Console.WriteLine(baz);     // Baz
            Console.WriteLine(qux);     // Foo

            Console.ReadKey();
        }
    }
}
