using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DavesCultureInfo
{
    public class DCultureInfo
    {
        private CultureInfo userCulture;
        
        [CultureItemAttribute(columnorder: 1)]
        public string[] AbbreviatedDayNames
        {
            get => userCulture.DateTimeFormat.AbbreviatedDayNames;
            set
            {
                userCulture.DateTimeFormat.AbbreviatedDayNames = value;
            }
        }

        [CultureItemAttribute(columnorder: 2)]
        public string[] AbbreviatedMonthGenitiveNames
        {
            get => userCulture.DateTimeFormat.AbbreviatedMonthGenitiveNames;
            set
            {
                userCulture.DateTimeFormat.AbbreviatedMonthGenitiveNames = value;
            }
        }
        [CultureItemAttribute(columnorder: 3)]
        public string[] AbbreviatedMonthNames
        {
            get => userCulture.DateTimeFormat.AbbreviatedMonthNames;
            set
            {
                userCulture.DateTimeFormat.AbbreviatedMonthNames = value;
            }
        }

        [CultureItemAttribute(columnorder: 4)]
        public string AMDesignator
        {
            get => userCulture.DateTimeFormat.AMDesignator;
            set => userCulture.DateTimeFormat.AMDesignator = value; 
        }
        [CultureItemAttribute(columnorder: 5)]
        public Calendar Calendar
        {
            get => userCulture.DateTimeFormat.Calendar;
            set
            {
                userCulture.DateTimeFormat.Calendar = value;
            }
        }
        [CultureItemAttribute(columnorder: 6)]
        public CalendarWeekRule CalendarWeekRule
        {
            get => userCulture.DateTimeFormat.CalendarWeekRule;
            set
            {
                userCulture.DateTimeFormat.CalendarWeekRule = value;
            }
        }
        [CultureItemAttribute(columnorder: 7)]
        public string DateSeparator 
        {
            get => userCulture.DateTimeFormat.DateSeparator;
            set
            {
                userCulture.DateTimeFormat.DateSeparator = value;
            }
        }
        [CultureItemAttribute(columnorder: 8)]
        public string[] DayNames 
        {
            get => userCulture.DateTimeFormat.DayNames;
            set
            {
                userCulture.DateTimeFormat.DayNames = value;
            }
        }
        [CultureItemAttribute(columnorder: 9)]
        public DayOfWeek FirstDayOfWeek
        {
            get => userCulture.DateTimeFormat.FirstDayOfWeek;
            set
            {
                userCulture.DateTimeFormat.FirstDayOfWeek = value;
            }
        }
        [CultureItemAttribute(columnorder: 10)]
        public string FullDateTimePattern 
        {
            get => userCulture.DateTimeFormat.FullDateTimePattern;
            set
            {
                userCulture.DateTimeFormat.FullDateTimePattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 11)]
        public bool IsReadOnly 
        {
            get => userCulture.DateTimeFormat.IsReadOnly;
        }
        [CultureItemAttribute(columnorder: 12)]
        public string LongDatePattern 
        {
            get => userCulture.DateTimeFormat.LongDatePattern;
            set
            {
                userCulture.DateTimeFormat.LongDatePattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 13)]
        public string LongTimePattern 
        {
            get => userCulture.DateTimeFormat.LongTimePattern;
            set
            {
                userCulture.DateTimeFormat.LongTimePattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 14)]
        public string MonthDayPattern 
        {
            get => userCulture.DateTimeFormat.MonthDayPattern;
            set
            {
                userCulture.DateTimeFormat.MonthDayPattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 15)]
        public string[] MonthGenitiveNames 
        {
            get => userCulture.DateTimeFormat.MonthGenitiveNames;
            set
            {
                userCulture.DateTimeFormat.MonthGenitiveNames = value;
            }
        }
        [CultureItemAttribute(columnorder: 16)]
        public string[] MonthNames 
        {
            get => userCulture.DateTimeFormat.MonthNames;
            set
            {
                userCulture.DateTimeFormat.MonthNames = value;
            }
        }
        [CultureItemAttribute(columnorder: 17)]
        public string NativeCalendarName 
        {
            get => userCulture.DateTimeFormat.NativeCalendarName;
        }
        [CultureItemAttribute(columnorder: 18)]
        public string PMDesignator 
        {
            get => userCulture.DateTimeFormat.PMDesignator;
            set
            {
                userCulture.DateTimeFormat.PMDesignator = value;
            }
        }
        [CultureItemAttribute(columnorder: 19)]
        public string RFC1123Pattern 
        {
            get => userCulture.DateTimeFormat.RFC1123Pattern;
        }
        [CultureItemAttribute(columnorder: 20)]
        public string ShortDatePattern 
        {
            get => userCulture.DateTimeFormat.ShortDatePattern;
            set
            {
                userCulture.DateTimeFormat.ShortDatePattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 21)]
        public string[] ShortestDayNames 
        {
            get => userCulture.DateTimeFormat.ShortestDayNames;
            set
            {
                userCulture.DateTimeFormat.ShortestDayNames = value;
            }
        }
        [CultureItemAttribute(columnorder: 22)]
        public string ShortTimePatterns 
        {
            get => userCulture.DateTimeFormat.ShortTimePattern;
            set
            {
                userCulture.DateTimeFormat.ShortTimePattern = value;
            }
        }
        [CultureItemAttribute(columnorder: 23)]
        public string SortableDateTimePattern 
        {
            get => userCulture.DateTimeFormat.SortableDateTimePattern;
        }
        [CultureItemAttribute(columnorder: 24)]
        public string TimeSeparator 
        {
            get => userCulture.DateTimeFormat.TimeSeparator;
            set
            {
                userCulture.DateTimeFormat.TimeSeparator = value;
            }
        }
        [CultureItemAttribute(columnorder: 25)]
        public string UniversalSortableDateTimePattern 
        {
            get => userCulture.DateTimeFormat.UniversalSortableDateTimePattern;
        }
        [CultureItemAttribute(columnorder: 26)]
        public string YearMonthPattern 
        {
            get => userCulture.DateTimeFormat.YearMonthPattern;
            set
            {
                userCulture.DateTimeFormat.YearMonthPattern = value;
            }
        }
        public DCultureInfo(string selectedCulture)
        {
            userCulture = new CultureInfo(selectedCulture);
        }

    }


}
