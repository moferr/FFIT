using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFIT.Service.FormatValidator
{
    public class FormatValidator
    {

        Dictionary<string, bool> allowedDict = new Dictionary<string, bool>()
        {
            { "number",true},
            { "date",true},
            { "timespan",true}
        };

        public bool IsFormat(string str, string f)
        {
            if (!allowedDict.ContainsKey(f.ToLower()) || allowedDict[f.ToLower()] == false)
            {
                throw new Exception("Format not allowed.");
            }

            if (f.ToLower() == "number")
                return Int32.TryParse(str, out var _);
            else if (f.ToLower() == "date")
                return DateTime.TryParse(str, out var _);
            else if (f.ToLower() == "timespan")
                return TimeSpan.TryParse(str, out var _);

            throw new Exception("Unknown format.");
        }

    }
}
