using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create an array of integers that can hold quiz scores 

            int[] quizScores = new int[10];


            //2. Create an array of strings that can hold the names of instructors at TE

            string[] instructorNames = { "David", "Josh", "Craig", "Casey", "John" };


            //3. Create an array of characters that hold "Tech Elevator"   

            char[] orgName = { 'T', 'e', 'c', 'h', ' ', 'E', 'l', 'e', 'v', 'a', 't', 'o', 'r' };


            //4. Print out the 0th item in each array

            Console.WriteLine(quizScores[0]);
            Console.WriteLine(instructorNames[0]);
            Console.WriteLine(orgName[0]);

            //5. Print out the 3rd item in each array

            Console.WriteLine(quizScores[2]);
            Console.WriteLine(instructorNames[2]);
            Console.WriteLine(orgName[2]);


            //6. Get the length of each array

            int quizScoresLength = quizScores.Length;
            int instructorNamesLength = instructorNames.Length;
            int orgNameLength = orgName.Length;


            //7. Get the last index for each array

            int quizScoresIndex = quizScoresLength - 1;
            int instructorNamesIndex = instructorNamesLength - 1;
            int orgNameIndex = orgNameLength - 1;


            //6. Update the last item in each array

            quizScores[quizScoresIndex] = 99;
            instructorNames[instructorNamesIndex] = "Johnny";
            orgName[orgNameIndex] = 'y';


            //7. Loop over an array's contents and print each item out to the screen

            for (int i = 0; i < instructorNames.Length; i++)
            {
                Console.WriteLine(instructorNames[i]);
            }


            //8. Loop over an array and print every other item out to the screen

            for (int i = 0; i < instructorNames.Length; i += 2)
            {
                Console.WriteLine(instructorNames[i]);
            }

            Console.ReadKey();

        }
    }
}
