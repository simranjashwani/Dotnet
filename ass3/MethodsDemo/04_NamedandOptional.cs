using System;
// Optional parameters → default values, can be omitted.

// Named parameters → call by name, order can change.

// Can mix positional + named, but positional must come first.

// Makes calls clearer and reduces overloads.

class ParametersExample
 {
       // So verbose is just a flag to turn extra output on or off.
       public static void Configure (int retries=3,bool verbose =false, string mode ="normal")
       {
              Console.WriteLine($"Retries={retries} ,Verbose={verbose} , Mode={mode}");
       }
       public static void Run()
       {
              Configure();//Using all defaults
              Configure(verbose:true);//Named parameter, skipping other
              Configure(mode :"Advanced",retries:7);//Mixing named + positional in different order
            Configure(5, verbose: true);//Positional + named
      
       }
}