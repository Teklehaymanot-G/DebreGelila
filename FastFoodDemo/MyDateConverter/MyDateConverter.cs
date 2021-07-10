using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.DateConverter
{
    class MyDateConverter
    {
        public void FromEthiopianToGrigorian() { }
        public static string FromGrigorianToEthiopian(DateTime dateTime) 
        {
            // 1 - Jan      7  - Jul
            // 2 - Feb      8  - Aug
            // 3 - Mar      9  - Sep
            // 4 - Apr      10 - Oct
            // 5 - May      11 - Nov
            // 6 - Jun      13 - Dec
            
            int date = dateTime.Day;
            int month = dateTime.Month;
            int year = dateTime.Year;

            int year_eth = 0;
            string month_eth = "";
            int date_eth = 0;

            if (month >= 1 && month <= 8)
                year_eth = year - 8;
            else
                year_eth = year - 7;


            // January
            if(month == 1)
            {
                if(year_eth % 4 == 0)
                {
                    if(date < 10)
                    {
                        month_eth = "ታህሳስ";
                        date_eth = (date + 31) - 10;
                    }
                    else
                    {
                        month_eth = "ጥር";
                        date_eth = date - 9;
                    }

                }
                else
                {
                    if(date < 9)
                    {
                        month_eth = "ታህሳስ";
                        date_eth = (date + 31) - 9;
                    }
                    else
                    {
                        month_eth = "ጥር";
                        date_eth = date - 8;
                    }
                }
            }

            // February
            else if (month == 2)
            {
                if(year_eth % 4 is 0)
                {
                    if(date < 10)
                    {
                        month_eth = "ጥር";
                        date_eth = (date + 31) - 9;
                    }
                    else
                    {
                        month_eth = "የካቲት";
                        date_eth = date - 8;
                    }
                }
                else
                {
                    if(date < 8)
                    {
                        month_eth = "ጥር";
                        date_eth = (date + 31) - 8;
                    }
                    else
                    {
                        month_eth = "የካቲት";
                        date_eth = date - 7;
                    }
                }

            }

            // March
            else if (month == 3)
            {
                if(date < 10)
                {
                    month_eth = "የካቲት";
                    date_eth = (date + 29) - 8;
                }
                else
                {
                    month_eth = "መጋቢት";
                    date_eth = date - 9;
                }
            }

            // April
            else if (month == 4)
            {
                if(date < 9)
                {
                    month_eth = "መጋቢት";
                    date_eth = (date + 30) - 8;
                }
                else
                {
                    month_eth = "ሚያዚያ";
                    date_eth = date - 8;
                }
            }

            // May
            else if (month == 5)
            {
                if(date < 9)
                {
                    month_eth = "ሚያዚያ";
                    date_eth = (date + 30) - 8;
                }
                else
                {
                    month_eth = "ግንቦት";
                    date_eth = date - 8;
                }
            }

            // June
            else if (month == 6)
            {
                if(date < 8)
                {
                    month_eth = "ግንቦት";
                    date_eth = (date + 31) - 8;
                }
                else
                {
                    month_eth = "ሰኔ";
                    date_eth = date - 7;
                }
            }

            // July
            else if (month == 7)
            {
                if(date < 8)
                {
                    month_eth = "ሰኔ";
                    date_eth = (date + 30) - 7;
                }
                else
                {
                    month_eth = "ሐምሌ";
                    date_eth = date - 7;
                }
            }

            // August
            else if (month == 8)
            {
                if(date < 7)
                {
                    month_eth = "ሐምሌ";
                    date_eth = (date + 31) - 7;
                }
                else
                {
                    month_eth = "ነሐሴ";
                    date_eth = date - 6;
                }
            }

            // September
            else if (month == 9)
            {
                if(year_eth % 4 == 0)
                {
                    if(year % 4 == 0)
                    {
                        if(date < 6)
                        {
                            month_eth = "ነሐሴ";
                            date_eth = (date + 31) - 6;
                        }
                        else
                        {
                            if(date < 12)
                            {
                                month_eth = "ጷጉሜን";
                                date_eth = date - 5;
                            }
                            else
                            {
                                month_eth = "መስከረም";
                                date_eth = date - 10;
                            }
                        }
                    }
                    else
                    {
                        if(date < 6)
                        {
                            month_eth = "ነሐሴ";
                            date_eth = (date + 31) - 7;
                        }
                        else
                        {
                            if(date < 12)
                            {
                                month_eth = "ጷጉሜን";
                                date_eth = date - 6;
                            }
                            else
                            {
                                month_eth = "መስከረም";
                                date_eth = date - 10;
                            }
                        }
                    }
                }
                else
                {
                    if(year % 4 == 0)
                    {
                        if(date < 5)
                        {
                            month_eth = "ነሐሴ";
                            date_eth = (date + 31) - 5;
                        }
                        else
                        {
                            if(date < 11)
                            {
                                month_eth = "ጷጉሜን";
                                date_eth = date - 4;
                            }
                            else
                            {
                                month_eth = "መስከረም";
                                date_eth = date - 10;
                            }
                        }
                    }
                    else
                    {
                        if(date < 5)
                        {
                            month_eth = "ነሐሴ";
                            date_eth = (date + 31) - 6;
                        }
                        else
                        {
                            if(date < 11)
                            {
                                month_eth = "ጷጉሜን";
                                date_eth = date - 5;
                            }
                            else
                            {
                                month_eth = "መስከረም";
                                date_eth = date - 10;
                            }

                        }
                    }
                }
            }

            // October
            else if (month == 10)
            {
                if(year_eth % 4 == 0)
                {
                    if(date < 12)
                    {
                        month_eth = "መስከረም";
                        date_eth = (date + 30) - 11;
                    }
                    else
                    {
                        month_eth = "ጥቅምት";
                        date_eth = date - 11;
                    }
                }
                else
                {
                    if(date < 11)
                    {
                        month_eth = "መስከረም";
                        date_eth = (date + 30) - 10;
                    }
                    else
                    {
                        month_eth = "ጥቅምት";
                        date_eth = date - 10;
                    }
                }
            }

            // November
            else if (month == 11)
            {
                if(year_eth % 4 == 0)
                {
                    if(date < 11)
                    {
                        month_eth = "ጥቅምት";
                        date_eth = (date + 31) - 11;
                    }
                    else
                    {
                        month_eth = "ሕዳር";
                        date_eth = date - 10;
                    }
                }
                else
                {
                    if(date < 10)
                    {
                        month_eth = "ጥቅምት";
                        date_eth = (date + 31) - 10;
                    }
                    else
                    {
                        month_eth = "ሕዳር";
                        date_eth = date - 9;
                    }
                }
            }

            // December
            else if (month == 12)
            {
                if(year_eth % 4 == 0)
                {
                    if(date < 11)
                    {
                        month_eth = "ሕዳር";
                        date_eth = (date + 30) - 10;
                    }
                    else
                    {
                        month_eth = "ታሕሳስ";
                        date_eth = date - 10;
                    }
                }
                else
                {
                    if(date < 10)
                    {
                        month_eth = "ሕዳር";
                        date_eth = (date + 30) - 9;
                    }
                    else
                    {
                        month_eth = "ታሕሳስ";
                        date_eth = date - 9;
                    }
                } 
            }

            return month_eth + " " + date_eth + " " + year_eth;
        }
    }
}
