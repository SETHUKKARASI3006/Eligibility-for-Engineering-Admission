using System;
namespace admission
{
    class Eligibility
    {
        static void Main(string[] args)
        {
           int maths, physics, chemistry;

            Console.Write("Enter Math marks: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics marks: ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            int totalMarks = maths + physics + chemistry;

            if (maths >= 75 && physics >= 65 && chemistry >= 60 && (totalMarks >= 180 || totalMarks >= 140))
            {
               Console.WriteLine("Congratulations! You are eligible for admission.");
            }
            else
            Console.WriteLine("Sorry, you are not eligible for admission.");
        }
    }
}
