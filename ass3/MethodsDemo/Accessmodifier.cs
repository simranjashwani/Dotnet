using System;
class BaseClass
{
    protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method");
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }
    }
// derived class
 // Derived class
    class DerivedClass : BaseClass
    {
        public static void Run()
        {
            DerivedClass d = new DerivedClass();
        // d.Run();

            Console.WriteLine("Inside DerivedClass Run():");

            d.ProtectedInternalMethod();  // ✅ allowed
            d.PrivateProtectedMethod();   // ✅ allowed
        }
    }

    // Non-derived class
    class NonDerivedClass
    {
        public static void Run()
        {
             NonDerivedClass n = new NonDerivedClass();
        // n.Run();
            Console.WriteLine("Inside NonDerivedClass Run():");

            BaseClass obj = new BaseClass();
            obj.ProtectedInternalMethod(); // ✅ allowed

            // obj.PrivateProtectedMethod(); ❌ NOT allowed
        }
    }