namespace DelegatesDemo;
public class Program
{
   public static void Main()
    {
//         // DelegatesDemo app = new DelegatesDemo();
//         // Delegates make code flexible by allowing methods to be passed, stored, and invoked dynamically, enabling loose coupling and event-driven programming.
//         // app.Run();
//         // EventDemo.Run();
//         // LinqDemo.Run();
        JoinQuery.Run();

    }
}

// // void Add(int a,int b)
// // delegate void MathOperation(int a, int b); //for below operations
// delegate int MathOperation(int a, int b);

// // generic delegates 
// // delegate TResult GenericTwoParameterFunction<TFirst,TSecond,TResult>(TFirst a ,TSecond b);

// delegate void GenericTwoParameterFunction<TFirst, TSecond>(TFirst a, TSecond b);

// class DelegateDemo
// {
//     public void HigherOrderFunctionDemo()
//     {
//         var result = CalculateArea(AreaOfTriangle);
//         Console.WriteLine($"area :{result}");
//     }

//     int CalculateArea(Func<int, int, int> areaFunction)
//     {
//         return areaFunction(5, 10);
//     }
//     int AreaOfRectangle(int length, int width)
//     {
//         return length * width;
//     }
//     int AreaOfTriangle(int baseLength, int height)
//     {
//         return (baseLength * height) / 2;
//     }


//     void PrintMessage(string message)
//     {
//         Console.WriteLine(message);
//     }

//     bool IsEven(int number)
//     {
//         return number % 2 == 0;
//     }


//     //  keywaord     methodname      a,b variable int-datatype inside()is parameter
//     public void Run()
//     {
//         HigherOrderFunctionDemo();
//         // multiple delegates :adding more to invocation
//         // MathOperation operation = Add;
//         // // GenericTwoParameterFunction<int, int, int> genericOperation = Add;
//         Func<int, int, int> genericOperation = Add;

//         Action<string> action = PrintMessage;//
//         action("Hello from Action delegate");

//         Predicate<int> predicate = IsEven;
//         int testNumber = 4;

//         Console.WriteLine($"Is{testNumber} even? {predicate(testNumber)}");

//         Func<string, string, string> stringOperation = Concatenate;

//         var x = stringOperation("Hello, ", "World!");
//         Console.WriteLine($"Concatenation result: {x}");

//         // Multicast Func (works, but last return wins
//         genericOperation += Subtract;
//         genericOperation += Multiply;
//         genericOperation += Divide;

//         genericOperation -= Subtract;//removing subtract method from invocation

//         var result = genericOperation(5, 3);
//         Console.WriteLine($"final result:{result}");

//     }
//     public string Concatenate(string a, string b)
//     {
//         return a + b;
//     }

//     public int Add(int a, int b)
//     {
//         Console.WriteLine($"sum of {a} and {b} is: {a + b}");
//         return (a + b);
//     }

//     public int Subtract(int a, int b)
//     {
//         Console.WriteLine($"difference between {a}and {b} is:{a - b}");
//         return (a - b);
//     }
//     public int Multiply(int a, int b)
//     {
//         Console.WriteLine($" multiply between {a}and {b} is:{a * b}");
//         return (a * b);
//     }
//     public int Divide(int a, int b)
//     {
//         if (b != 0)
//         {
//             Console.WriteLine($"The quotient of {a} and {b} is: {a / b}");
//             return a / b;
//         }
//         else
//         {
//             Console.WriteLine("Cannot divide by zero.");
//         }
//         return 0;
//     }

// }

// // builtin delegates >> func,action,predictive