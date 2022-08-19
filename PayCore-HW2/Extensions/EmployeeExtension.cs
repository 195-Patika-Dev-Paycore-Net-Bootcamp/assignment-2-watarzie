using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PayCore_HW2.Extensions
{
    public static class EmployeeExtension
    {
        // Employee sınıfının DateofBirth property'si için yazılmış extension metot.
        public static bool DateOfBirth(DateTime time)
        {

            
            var max = new DateTime(2002, 10, 10);
            var min = new DateTime(1945, 11, 11);
            if (time < min || time > max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Employee sınıfının Email property'si için yazılmış extension metot.
        public static bool Email(string email)
        {
            // Regex ifadesinde özel karakterleri içermeyecek şekilde eşlenme sağlanmıştır.
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            // Email içerisinde rakam var mı yok mu kontrolü yapılıp result değerine boolean tipte atanır.
            var result = email.Any(x => char.IsDigit(x));
            if (result)
            {
                // Eğer rakam var ise false geri dönüş verir.
                return false;
            }

            if (regex.IsMatch(email))
            {
                // Regex ifadesi ile eşleşir ise true geri dönüş verir.
                return true;
            }
            return false;

        }
        public static bool PhoneNumber(string pnumber)
        {
            // Telefon numarası rakamlardan mı oluşuyor kontrolü yapılıp result değişkenine boolean atama yapılır.
            var result = pnumber.Any(x => char.IsDigit(x));
            // Eğer numara rakamlardan oluşmuş ve + işareti ile başlamızsa true geri dönüş verilir.
            if (result && pnumber.StartsWith("+"))
            {
                return true;
            }
            return false;

        }
    }
}
