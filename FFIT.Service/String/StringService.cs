using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFIT.Service.String
{
    public class StringService : IStringService
    {
        /// <summary>
        /// Returns Middle character of the string (If the string length is even, returns two middle characters); 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetMiddle(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            if (input.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("Input string length should not be greater than 1000.");
            }

            return input.Length % 2 == 1 ? 
                input.Substring(input.Length / 2, 1) // odd string length
                : 
                input.Substring((input.Length / 2) - 1, 2);// even string length
        }
    }
}
