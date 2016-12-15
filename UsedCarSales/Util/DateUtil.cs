using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedCarSales
{
    public static class DateUtil
    {
        public const int INVALID_YEAR = -1;

        //return null if 
        public static int HandleYearString(string year)
        {
            if (!String.IsNullOrEmpty(year) && !String.IsNullOrWhiteSpace(year))
            {
                int yearInt;
                if (Int32.TryParse(year, out yearInt))
                {
                    if (yearInt >= 1900 && yearInt < 3000)
                    {
                        return yearInt;
                    }
                }
            }

            return INVALID_YEAR;
        }
    }
}
