using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Util
{
    public class ElementCalculator
    {
        public string GetElementByBirthYear(string dob)
        {
            int year = int.Parse(dob.Substring(0, 4));
            try
            {
                var element = CalElement(year);
                return element;
            }
            catch (Exception ex)
            {
                return "Định dạng ngày tháng năm không hợp lệ";
            }
        }

        public string CalElement(int birthYear)
        {
            int lastTwoDigits = birthYear % 100;
            int firstNumber = 0;
            int secondNumber = 0;

            // Calculate Thiên Can
            if (lastTwoDigits % 10 == 4 || lastTwoDigits % 10 == 5)
                firstNumber = 1;
            else if (lastTwoDigits % 10 == 6 || lastTwoDigits % 10 == 7)
                firstNumber = 2;
            else if (lastTwoDigits % 10 == 8 || lastTwoDigits % 10 == 9)
                firstNumber = 3;
            else if (lastTwoDigits % 10 == 0 || lastTwoDigits % 10 == 1)
                firstNumber = 4;
            else if (lastTwoDigits % 10 == 2 || lastTwoDigits % 10 == 3)
                firstNumber = 5;

            // Calculate Địa chi
            int remainder = birthYear % 12;
            if (remainder == 4 || remainder == 5 || remainder == 10 || remainder == 11)
                secondNumber = 0;
            else if (remainder == 6 || remainder == 7 || remainder == 0 || remainder == 1)
                secondNumber = 1;
            else if (remainder == 8 || remainder == 9 || remainder == 2 || remainder == 3)
                secondNumber = 2;

            // Calculate giá trị của mệnh
            int result = firstNumber + secondNumber;
            if (result > 5)
            {
                result = result - 5;
            }
            switch (result)
            {
                case 1:
                    return "Kim";
                case 2:
                    return "Thủy";
                case 3:
                    return "Hỏa";
                case 4:
                    return "Thổ";
                case 5:
                    return "Mộc";
                default:
                    return "Unknown";
            }
        }
    
}
}
