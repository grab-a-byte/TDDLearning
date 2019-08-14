using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == "")
                return 0;

            var delimiter = GetDelimiterFromString(input);

            var newInput = RemoveUserDefinedDelimter(input, delimiter);
            var replacedInput = newInput.Replace("\n", ",");

            if(delimiter.Length > 0)
                replacedInput = replacedInput.Replace(delimiter, ",");

            IEnumerable<int> numbers = GetListOfIntsFromCommaSepertedString(replacedInput);

            if (numbers.Any(x => x < 0))
                throw new ArgumentException("negatives not allowed");

            return numbers.Sum(x => x);
        }

        private IEnumerable<int> GetListOfIntsFromCommaSepertedString(string input)
        {
            return input.Split(',').Select(x => int.Parse(x));
        }

        private string GetDelimiterFromString(string input)
        {
            var regexPattern = "//(.)\n";
            Regex regex = new Regex(regexPattern);
            Match matches = regex.Match(input);

            if (matches.Success)
                return matches.Groups[1].Value;

            return "";
        }

        private string RemoveUserDefinedDelimter(string input, string delimiter)
        {
            if (delimiter.Length == 0)
                return input;

            return input.Replace($"//{delimiter}\n", "");
        }
    }
}
