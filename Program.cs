using System;
/*
 * Using C# Application, write a program that perform the following tasks:
 * a) Ask user to input marks of 4 subjects(Math, Physics, Chemistry and Computer Science) out of a maximum of 100
 * b) Use a function to calculate the avarage of the 4 marks and return it
 * c) Use a function to find out the grade of the student using the avarage marks following the criteria listed below
 * Marks>=80 :GradeA
 * Marks>=70and<80:GradeB
 * Marks>=60and<70:GradeC
 * Marks>=50and<60:GradeD
 * Marks<50: GtadeF
 * d) Using a switch statement, pring remarks listed below based on the grade
 * GradeA:'Excellent! Your grade isA'
 * GradeB:'Good! Your grade is B'
 * GradeC:'Satisfactory. Your grade is C'
 * GradeD:'Pass. Your grade is D'
 * GradeF:'Fail. Your grade is F'
 * */
namespace A_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1, score2, score3, score4;
            decimal avarage;
            //string grade="";
            //string mark="";

            Console.WriteLine("enter math score "); score1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("enter physics score ");score2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter Chemistry score ");score3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Computer Science score ");score4 = Convert.ToInt32(Console.ReadLine());

            avarage=avarageoperation(score1, score2, score3, score4);
            Console.WriteLine("");
            Console.WriteLine("avarage score of 4 subjects are  " + avarage);

           
            if (avarage >= 80 && avarage <= 100)
            {
                Console.WriteLine("avarage is A");Console.WriteLine("Excellent! your grade is A");
            }
            else if (avarage >= 70 && avarage < 80)
            {
                Console.WriteLine("avarage is B");Console.WriteLine("Good! Your grade is B");
            }
            else if (avarage >= 60 && avarage < 70)
            {
                Console.WriteLine("avarage is C");Console.WriteLine("Satisfactory. Your grade is C");
            }
            else if (avarage >= 50 && avarage < 60)
            {
                Console.WriteLine("avarage is D");Console.WriteLine("Pass.Your grade is D");
            }
            else if (avarage < 50)
            {
                Console.WriteLine("avarage is F");Console.WriteLine("Fail. Your grade is F");
            }
        }
        public static decimal avarageoperation(int score1, int score2, int score3, int score4)
        {
            decimal avarage;
            avarage = Convert.ToDecimal(score1 + score2 + score3 + score4) / 4;
            return avarage;
        }
        
        /*
        public static string gradeoperation(decimal avarage)
        {            
            if(avarage >= 80 && avarage <= 100)
                    {
                Console.WriteLine("avarage is A");//Console.WriteLine("Excellent! your grade is A");
                    }
            else if(avarage >= 70 && avarage< 80)
                    {
                Console.WriteLine("avarage is B");//Console.WriteLine("Good! Your grade is B");
                    }
            else if(avarage >= 60 && avarage < 70)
                    {
                Console.WriteLine("avarage is C");// Console.WriteLine("Satisfactory. Your grade is C");
                    }
             else if(avarage >= 50 && avarage < 60)
                    {
                Console.WriteLine("avarage is D");//Console.WriteLine("Pass.Your grade is D");
                    }
              else if(avarage< 50)
                    {
                Console.WriteLine("avarage is F");// Console.WriteLine("Fail. Your grade is F");
                    }
           return avarage;       
         }
        */

        /*
         {
             case A:
                 Console.WriteLine("Excellent! your grade is A");
                 break;
             case B:
                 Console.WriteLine("Good! Your grade is B");
                 break;
             case C:
                 Console.WriteLine("Satisfactory. Your grade is C");
                 break;
             case D:
                 Console.WriteLine("Pass.Your grade is D");
                 break;
             case F:
                 Console.WriteLine("Fail. Your grade is F");
                 break;
             default://code to be executed if n doesn't match any cases
                 break;
         }
        */
    }

}

