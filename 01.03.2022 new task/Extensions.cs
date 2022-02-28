using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2022_new_task
{
    static class Extensions
    {
        public static string isCapitalized(this string word)
        { 
            //Task1
            #region
            string capitaledWord = "";
            word = word.ToLower();
            var newWord = word.Split(' ');
            foreach (string item in newWord)
            {
                capitaledWord += char.ToUpper(item[0]); /*+item.Substring(1) + " ";*/
                for (int i = 1; i < item.Length; i++)
                {
                    capitaledWord += item[i];

                }
                capitaledWord += " ";
            }
            return capitaledWord;

            #endregion

            
        }

        //Task2
        #region

        public static bool SearchWord(this string text, string search)

        {
            string[] newtext = text.Split(" ");
            foreach (string item in newtext)
            {
                if (item == search)
                {
                    return true;
                }
            }
            return false;
            #endregion

        }
    }
}
