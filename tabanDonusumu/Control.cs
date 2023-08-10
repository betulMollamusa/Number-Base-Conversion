using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabanDonusumu
{
    internal class Control
    {
        public string ConvertToBase(int number, int baseValue)
        {
            if (baseValue < 2 || baseValue > 36)
                throw new ArgumentException("Desteklenmeyen taban. Taban 2 ile 36 arasında olmalıdır.");

            string converted = string.Empty;
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            while (number > 0)
            {
                int remainder = number % baseValue;
                converted = digits[remainder] + converted; // Kalanı hedef tabanda karşılık gelen basamağa çevirip öne ekler
                number /= baseValue; // Sayıyı hedef tabanda bölerek işlemi devam ettirir
            }

            return converted;
        }

        public int ConvertFromBase(string number, int baseValue)
        {
            if (baseValue < 2 || baseValue > 36)
                throw new ArgumentException("Desteklenmeyen taban. Taban 2 ile 36 arasında olmalıdır.");

            int result = 0;
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[number.Length - 1 - i];  // Sayının sağdan sola doğru basamaklarına ulaşma
                int value = digits.IndexOf(digit); // Rakamın veya harfin hedef tabandaki değeri

                if (value == -1 || value >= baseValue)
                    throw new ArgumentException("Geçersiz karakter ya da taban belirtilen sayı için uygun değil.");

                // Rakamın veya harfin ondalık değeri ile hedef tabanın i. üssü çarpılır ve sonuca eklenir
                result += value * (int)Math.Pow(baseValue, i);
            }

            return result;
        }
    }
}
