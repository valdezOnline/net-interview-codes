using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2inputset1output
{
    public class InputReceived
    {
        public double dblValue { get; set; }
        public string strValue { get; set; }

        public bool ValidateNbrInput(string nbrInput)
        {
            Regex regexNbr = new Regex(@"(\+|\-)?(\d*\.)?\d+$");
            return regexNbr.IsMatch(nbrInput);
        }
        public bool ValidateLtrInput(string ltrString)
        {
            Regex regexLtr = new Regex(@"[a-j]|[A-J]");
            return regexLtr.IsMatch(ltrString);
        }

        public double ReturnLetterValue(string letterString)
        {

            switch (letterString.ToUpper().ToString())
            {
                case "A":
                    return 0;                    
                case "B":
                    return 1;
                case "C":
                    return ReturnLetterValue("B");
                case "D":
                    return ReturnLetterValue("B") + ReturnLetterValue("C");
                case "E":
                    return ReturnLetterValue("C") + ReturnLetterValue("D");
                case "F":
                    return ReturnLetterValue("D") + ReturnLetterValue("E");
                case "G":
                    return ReturnLetterValue("E") + ReturnLetterValue("F");
                case "H":
                    return ReturnLetterValue("F") + ReturnLetterValue("G");
                case "I":
                    return ReturnLetterValue("G") + ReturnLetterValue("H");
                case "J":
                    return ReturnLetterValue("G") + ReturnLetterValue("H") + ReturnLetterValue("F")+ ReturnLetterValue("G");
                default:
                    return 0;
            }
        }
    }
}
