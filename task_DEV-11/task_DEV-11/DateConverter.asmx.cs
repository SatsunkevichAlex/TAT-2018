using System;
using System.Web.Services;

namespace task_DEV_11
{
    /// <summary>
    /// Date.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DateConverter : System.Web.Services.WebService
    {
        /// <summary>
        /// Converts date into days from Jesus birth.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns>Days from Jesus birth.</returns>
        [WebMethod]
        public int ConvertDateIntoDays(int year, int month, int day)
        {
            double leapYears = year / 4;
            leapYears = Math.Floor(leapYears);
            int daysInLeapYears = (int)leapYears * 366;

            year -= (int)leapYears;
            int daysInYears = year * 365;


            int daysInMonth = 0;
            switch(month)
            {
                case 1:
                    daysInMonth = 31;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                case 3:
                    daysInMonth = 31;
                    break;
                case 4:
                    daysInMonth = 30;
                    break;
                case 5:
                    daysInMonth = 31;
                    break;
                case 6:
                    daysInMonth = 30;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 31;
                    break;
                case 9:
                    daysInMonth = 30;
                    break;
                case 10:
                    daysInMonth = 31;
                    break;
                case 11:
                    daysInMonth = 30;
                    break;
                case 12:
                    daysInMonth = 31;
                    break;
            }

            return daysInLeapYears + daysInYears + daysInMonth + day;
        }
    }
}
