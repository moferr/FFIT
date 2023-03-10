using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFIT.Service.MarkdownParser
{
    public interface IMarkdownParser
    {

        /// <summary>
        /// Returns parsed string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ParseHeader(string input);
    }
}
