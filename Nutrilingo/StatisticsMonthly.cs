using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrilingo
{
    class StatisticsMonthly
    {
        public string MacroNutrientType { get; set; }
        public decimal Day1 { get; set; }
        public decimal Day2 { get; set; }
        public decimal Day3 { get; set; }
        public decimal Day4 { get; set; }
        public decimal Day5 { get; set; }
        public decimal Day6 { get; set; }
        public decimal Day7 { get; set; }
        public decimal Day8 { get; set; }
        public decimal Day9 { get; set; }
        public decimal Day10 { get; set; }
        public decimal Day11 { get; set; }
        public decimal Day12 { get; set; }
        public decimal Day13 { get; set; }
        public decimal Day14 { get; set; }
        public decimal Day15 { get; set; }
        public decimal Day16 { get; set; }
        public decimal Day17 { get; set; }
        public decimal Day18 { get; set; }
        public decimal Day19 { get; set; }
        public decimal Day20 { get; set; }
        public decimal Day21 { get; set; }
        public decimal Day22 { get; set; }
        public decimal Day23 { get; set; }
        public decimal Day24 { get; set; }
        public decimal Day25 { get; set; }
        public decimal Day26 { get; set; }
        public decimal Day27 { get; set; }
        public decimal Day28 { get; set; }
        public decimal Day29 { get; set; }
        public decimal Day30 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
