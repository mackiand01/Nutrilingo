using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrilingo
{
    class StatisticsWeekly
    {
        //

        public string MacroNutrientType { get; set; }
        public decimal Day1 { get; set; }
        public decimal Day2 { get; set; }
        public decimal Day3 { get; set; }
        public decimal Day4 { get; set; }
        public decimal Day5 { get; set; }
        public decimal Day6 { get; set; }
        public decimal Day7 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}
