using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithms.String_Algorithms
{
    public class String_Algorithms
    {
        public Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }

        public Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }

        public Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsDigit) && s.Any(char.IsUpper) && s.Any(char.IsLower);
        }

        public string NormalizeString(string input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }
    }
}
