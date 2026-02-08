using System;

       class Age
{
       public static void Run()
       {
              int age =22;
// “Decide a value for group based on the value of age.”
        string group = age switch
        {
               < 13 =>"child",
               >= 13 and < 20=>"teen",
               >= 20 and < 60 =>"adult",
               _=> "senior"
              
              
        };
         Console.WriteLine(group);
        
       }
        
}
