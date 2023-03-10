using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FFIT.Service.MarkdownParser
{
    public class MarkdownParser : IMarkdownParser
    {
        Regex regex = new Regex(@"(^\s*)([#]{1,6})\s([^\s].+)$");


        /// <summary>
        /// Returns parsed string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ParseHeader(string input)
        {
            var match = regex.Match(input);
            // Check input
            if (match.Success == false)
            {
                return input;
            }

            var sb = new StringBuilder();

            // Number of # charachter
            var hashCount = match.Groups[2].Value.Length;

            // Start of h tag
            sb.Append($"<h{hashCount}>");

            // Append spaces before first #
            sb.Append(match.Groups[1].Value);

            // Append header content
            sb.Append(match.Groups[3].Value);

            // End of h tag
            sb.Append($"</h{hashCount}>");

            return sb.ToString();
        }
    }
}
