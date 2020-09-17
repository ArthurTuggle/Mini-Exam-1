using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Weight in lb: ");
            int lb;
            lb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in inches: ");
            int inches;
            inches = Convert.ToInt32(Console.ReadLine());

          
            double BMI;
            BMI = ((lb * 703) / (inches * inches));

            
           


            if (BMI < 18.5)
            { Console.WriteLine("Underweight"); }
            
            if (BMI > 30)
            { Console.WriteLine("Obese"); }

            if (BMI > 18.5 & BMI < 24.9)
            { Console.WriteLine(" Normal"); }

            if (BMI > 25 & BMI  < 29.9)
            {
            Console.WriteLine("Overweight");
            }
            
            
            Console.Write("Your BMI is" + BMI );

            Console.ReadLine();
  }
}
  
