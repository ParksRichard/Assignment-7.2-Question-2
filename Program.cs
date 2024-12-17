//given a string s, reverse only all the vowels in the string and return

//loop array for search
//how to deterimine vowel? - isolate char?
//move identified vowels to new array (i and j)
// use poi nters?

namespace Assignment_7._2_Question_2
{
    internal class Program
    {

        static bool Vowel(char c)
        {
            //return vowels?
            return "aeiouAEIOU".IndexOf(c) >= 0;
            //cool
        }

        static string ReverseVowels(string s)
        { //set up string as array
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;

            //pointers?
            while (left < right)
            {
                while (left < right && !Vowel(chars[left]))
                    left++;
                //looking from side to side to determine if a vowel or not
                while (left < right && !Vowel(chars[right]))
                    right--;

                //move vowels around
                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter some words:");
            string input = Console.ReadLine();

            Console.WriteLine("");
            string result = ReverseVowels(input);
            Console.WriteLine("Your words after playing with vowels: \n"  + result);
            //quite silly
        }
    }
}
