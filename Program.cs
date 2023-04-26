// written by Adam Chase 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicHW
{
    public class program
    {
        public static void Main(string[] args)
        {



            // convenience store 
            questions aQues = new questions();
            /*int[] change = { 2, 100, 0, 0 };
            Console.WriteLine(aQues.ChangeEnough(change, 14.11));
            Console.ReadLine();*/




            // second largest number
            /* int[] nums = { 10, 40, 30, 20, 50 };
             Console.WriteLine(aQues.SecondLargest(nums));
             Console.ReadLine();*/




            // remove odd nums 
            /*int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] evens = aQues.NoOdds(nums2);
            Console.WriteLine("\n the even elements are \n");
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(evens);
            }
            Console.ReadLine();*/




            // switcharoo
            /*string aString = "cat,dog,and mouse.";
          
            Console.WriteLine(aQues.Switch(aString)); 
            
            Console.ReadKey();*/



            // second occurance of zip 

            string aString = "all zip files are zipped";

            Console.WriteLine(aQues.FindZip(aString));
            Console.ReadLine();


        }
    }
}
