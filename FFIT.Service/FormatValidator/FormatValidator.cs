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

            switch (f.ToLower())
            {
                case "number":
                    return Int32.TryParse(str, out var _);
                case "date":
                    return DateTime.TryParse(str, out var _);
                case "timespan":
                    return TimeSpan.TryParse(str, out var _);
                default:
                    throw new Exception("Unknown format."); ;
            }

            
        }

    }
}
