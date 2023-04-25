using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        //Definimos los atributos
        private int _year;
        private int _month;
        private int _day;

        //Creamos constructor Snnipers --> ctor +tab, tab
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month); //Creamos el método
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //Creamos arreglo con la cantidad de días por mes
            if (day >= 1 && day <= dayPerMonth[month])
            {
                return day;
            }
            throw new DayException("Invalid Day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
           
            throw new MonthException("Invalid Month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
