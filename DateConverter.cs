using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CHITA
{
    class DateConverter
    {
        public string ConverttoMiladi(string s)
        {
            string[] date = s.Split('/');

            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(Int32.Parse(date[0]), Int32.Parse(date[1]), Int32.Parse(date[2]), pc);

            string m = dt.Month.ToString(), d = dt.Day.ToString();

            switch (m)
            {
                case "0":
                    m = "00";
                    break;
                case "1":
                    m = "01";
                    break;
                case "2":
                    m = "02";
                    break;
                case "3":
                    m = "03";
                    break;
                case "4":
                    m = "04";
                    break;
                case "5":
                    m = "05";
                    break;
                case "6":
                    m = "06";
                    break;
                case "7":
                    m = "07";
                    break;
                case "8":
                    m = "08";
                    break;
                case "9":
                    m = "09";
                    break;
            }
            switch (d)
            {
                case "0":
                    d = "00";
                    break;
                case "1":
                    d = "01";
                    break;
                case "2":
                    d = "02";
                    break;
                case "3":
                    d = "03";
                    break;
                case "4":
                    d = "04";
                    break;
                case "5":
                    d = "05";
                    break;
                case "6":
                    d = "06";
                    break;
                case "7":
                    d = "07";
                    break;
                case "8":
                    d = "08";
                    break;
                case "9":
                    d = "09";
                    break;
            }
            return dt.Year.ToString() + "-" + m + "-" + d;

        }
    }

}
