using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebform.Ultilities
{
    public class DateTimeConverter
    {
        // Apply Singleton to not let user instantiates the class 
        private static readonly Lazy<DateTimeConverter> lazy = new Lazy<DateTimeConverter>(() => new DateTimeConverter());
        private DateTimeConverter()
        {
        }
        public static DateTimeConverter shared => lazy.Value;


        // Methods
        public String ConvertDateToString(DateTime date)
        {
            var myFormatDate = DateTime.Parse(date.ToString());
            return myFormatDate.ToString("dd/MM/yyyy");
        }
    }
}