using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    public class ReferenceType
    {
        public int Counter { get; set; }
    }

    public struct ValueType
    {
        public int Counter { get; set; }
    }
    
    class Program
    {
        static void Method(ReferenceType a)
        {
            a.Counter++;
            a = new ReferenceType();
        }

        static void MethodRef(ref ReferenceType a)
        {
            a.Counter++;
            a = new ReferenceType();
        }

        static void Method(ValueType a)
        {
            a.Counter++;
            a = new ValueType();
        }

        static void MethodRef(ref ValueType a)
        {
            a.Counter++;
            var b = new ValueType {Counter = 10};
            a = b;
        }

        static void Main()
        {
            var referenceType = new ReferenceType();
            Method(referenceType);
            Console.WriteLine(referenceType.Counter);

            referenceType = new ReferenceType();
            MethodRef(ref referenceType);
            Console.WriteLine(referenceType.Counter);

            var valueType = new ValueType();
            Method(valueType);
            Console.WriteLine(valueType.Counter);

            valueType = new ValueType();
            MethodRef(ref valueType);
            Console.WriteLine(valueType.Counter);

            Console.ReadKey();
        }
    }
}
