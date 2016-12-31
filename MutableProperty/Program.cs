using System;

namespace MutableProperty
{
    public struct Foo
    {
        public int Value;

        public void Change(int newValue)
        {
            Value = newValue;
        }
    }

    public class Bar
    {
        public Foo Foo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bar = new Bar() {Foo = new Foo()};
            bar.Foo.Change(5);
            Console.WriteLine(bar.Foo.Value);
            Console.ReadKey();
        }
    }
}
