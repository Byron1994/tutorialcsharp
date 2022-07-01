﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Date
    {
        public int _year;
        public int _month;
        public int _day;

        public Date(int year,int month,int day)
        {
            _year=year;
            _month=CheckMonth(month);
            _day= CheckDay(year,month,day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if(month==2 && day==29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if(day>=1 && month <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayEception("Dia Invalido");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month>=1&&month<=12)
            {
                return month;
            }
            throw new MonthException("Mes invalido");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}