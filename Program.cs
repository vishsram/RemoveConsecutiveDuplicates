using System;
using System.Text;

namespace RemoveDuplicates
{
    class Program
    {
        public String RemoveConsecutiveDuplicates(String str) {
            if (String.IsNullOrEmpty(str)) {
                return String.Empty;
            }

            int i = 0;
            StringBuilder result = new StringBuilder();

            while(i < str.Length) {
                char currentChar = str[i];
                result.Append(currentChar);

                i++;
                while(i < str.Length) {
                    if (str[i] == currentChar) {
                        i++;
                    }
                    else {
                        break;
                    }
                }
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program DuplicateRemover = new Program();
            String result = DuplicateRemover.RemoveConsecutiveDuplicates("AAbbaaaarr");
            Console.WriteLine(result);
        }
    }
}
