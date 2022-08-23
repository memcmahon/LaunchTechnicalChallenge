using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class CreditCard
    {
        private string _number;

        public CreditCard(string number)
        {
            _number = number;
        }

        public bool IsValid()
        {
            var array = _number.ToCharArray();
            var reversed = array.Reverse().ToArray();
            var doubled = new int[_number.Length];
     
            for (var i = 0; i < _number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    doubled[i] = Convert.ToInt16(reversed[i].ToString());
                }
                else
                {
                    doubled[i] = Convert.ToInt16(reversed[i].ToString()) * 2;
                }
            }

            var summed = new int[_number.Length];

            for (var i = 0; i < _number.Length; i++)
            {
                if (doubled[i] > 9)
                {
                    summed[i] = doubled[i] - 9;
                }
                else
                {
                    summed[i] = doubled[i];
                }
            }

            var total = 0;

            foreach (var num in summed)
            {
                total += num;
            }
            
            if (total % 10 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
