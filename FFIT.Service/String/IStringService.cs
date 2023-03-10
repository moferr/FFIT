using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFIT.Service.String
{
    public interface IStringService
    {
        /// <summary>
        /// Returns Middle character of the string (If the string length is even, returns two middle characters); 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetMiddle(string input);
    }
}
