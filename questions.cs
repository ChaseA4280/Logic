using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicHW
{
    public class questions
    {
        // convenience store
        public bool ChangeEnough(int[] change,double amtDue)
        {
            
            double quarters = change[0] * .25;
            double dimes = change[1] * .1;
            double nickles = change[2] * .05;
            double pennies = change[3] * .01;
            double amt = quarters + dimes + nickles + pennies;
            if ( amt >= amtDue )
            {
                return true;
            }
            else 
            { 
                return false;
            }
            
        }
        // second largest number 
        public int SecondLargest(int[] nums)
        {
            int length = nums.Length;
            int secL = nums[1];
            int large = nums[0];
            for (int i = 0; i < length; i++)
            {
                if (nums[0] > nums[i++])
                {
                    nums[0] = large;
                }
                else if (nums[1] < nums[i++]) 
                {
                    nums[1] = secL;

                }
                
            }
            return secL;
        }
        // eliminate odd numbers 
        public int[] NoOdds(int[] nums)
        {
            int even = 0;
            int odd = 0;

            foreach (var n in nums)
            {
                
                if ((n % 2) == 0)
                {
                    even++;
                }
                else if ((n % 2) != 1)
                {
                    odd++;
                }

               
            }
            int[] evens = new int[even];
            return evens;

           
        }
        // switcaroo
        public string Switch(string aString)
        {
            // aquire the length of given string
            int length = aString.Length;
            string newString = string.Empty;
            
            if (length < 2)
            {
                return aString + "";
            }
            else if (length > 2 & aString[0] == aString[length - 1])
            {
                return aString + "incompatible";

            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    
                    string first = aString.Substring(0,1);
                    string remainder = aString.Substring(1,length-2) ;
                    string last = aString.Substring(length-1);
                    newString = $"{last}{remainder}{first}";
                   
                    
                   
                }
            }
            return newString;
           
            
        }
        // find the second occurnce of "zip" in a string
        public int FindZip(string aString)
        {
            int length = aString.Length;
            
            int first = aString.IndexOf("zip");
            int second = aString.IndexOf("zip", first + 1);

            return second;
            
        }
    } 
}
