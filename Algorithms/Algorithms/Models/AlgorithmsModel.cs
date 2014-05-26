using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Algorithms.Models
{
    public class AlgorithmsModel
    {
        [Required(ErrorMessage = "You must enter a value to verify")]
        public string Text { get; set; }

        [Required(ErrorMessage = "You must enter a value to verify")]
        public int Number { get; set; }

        public bool IsPalindrome(string texto)
        {
            char[] original = new char[texto.Length];
            string right = string.Empty;
            string left = string.Empty;
            bool isPalindrome = false;

            for (int i = 0; i < texto.Length; i++)
            {
                original[i] = texto[i];
                right += original[i];

            }
            Array.Reverse(original);

            foreach (var item in original)
            {
                left += item;
            }

            if (left.Equals(right))
                isPalindrome = true;
            else
                isPalindrome = false;

            return isPalindrome;

        }

        public string Fibonacci(int number)
        {
            var first = 0;
            var second = 1;
            var result = 0;

            System.Text.StringBuilder sb = new System.Text.StringBuilder ();
            sb.Append(first+","+second+",");
            while(result < number)
            {
                result = first + second;
                first = second;
                second = result;
                sb.Append(result + ",");
            }

            return sb.ToString();
        }
    }
}