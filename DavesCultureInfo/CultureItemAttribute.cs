using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavesCultureInfo
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CultureItemAttribute : Attribute
    {
        public string Heading { get; set; }
        public string Units { get; set; }
        public string Format { get; set; }
        public int ColumnOrder { get; }
        public CultureItemAttribute(int columnorder)
        {
            this.ColumnOrder = columnorder;
        }
    }
}
