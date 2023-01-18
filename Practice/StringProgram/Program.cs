using System;

namespace StringProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //replace string
            string str = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            string result = str.Replace("<<UserName>>", name);
            Console.WriteLine("Result is : "+result);

            //reverse the string
            char[] chars = name.ToCharArray();
            string reverse = string.Empty;
            for(int i = chars.Length-1; i>=0;i--)
            {
                reverse += chars[i];
            }
            Console.WriteLine("Reverse string is : "+reverse);

            //check palindrome or not
            Console.WriteLine("check string is palindrome or not");
            string charArray = Console.ReadLine();
            char[] charArr = charArray.ToCharArray();
            string rev = string.Empty;
            for(int i=charArr.Length-1; i>=0;i--)
            {
                rev += charArr[i];
            }
            if(charArray.Equals(rev))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
