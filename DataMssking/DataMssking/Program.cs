using System;
using System.Text.RegularExpressions;

namespace DataMssking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "My credit card number is 1234-5678-9012-3456";
            string output1 = MaskData(input1);
            Console.WriteLine(output1);

            string input2 = "My social security number is 123-45-6789";
            string output2 = MaskData(input2);
            Console.WriteLine(output2);

            string input3 = "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789";
            string output3 = MaskData(input3);
            Console.WriteLine(output3);
        }

        static string MaskCreditCard(string input)
        {
            // Match credit card numbers in the format XXXX-XXXX-XXXX-XXXX
            Match match = Regex.Match(input, @"\d{4}-\d{4}-\d{4}-(\d{4})");
            string maskedInput = Regex.Replace(input, @"\d{4}-\d{4}-\d{4}-\d{4}", $"XXXX-XXXX-XXXX-{match.Groups[1].Value}");
            return maskedInput;
        }

        static string MaskSocialSecurity(string input)
        {
            // Match social security numbers in the format XXX-XX-XXXX
            Match match = Regex.Match(input, @"\d{3}-(\d{2})-\d{4}");
            string maskedInput = Regex.Replace(input, @"\d{3}-\d{2}-\d{4}", $"XXX-{match.Groups[1].Value}-XXXX");
            return maskedInput;
        }

        static string MaskData(string input)
        {
            string maskedInput = MaskCreditCard(input);
            maskedInput = MaskSocialSecurity(maskedInput);
            return maskedInput;
        }
    }
}
