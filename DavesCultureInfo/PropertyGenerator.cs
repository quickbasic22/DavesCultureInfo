using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DavesCultureInfo
{
    public class PropertyGenerator<T>
    {
        private IEnumerable<T> _data;
        private string _filename;
        private Type _type;

        public PropertyGenerator(IEnumerable<T> data, string filename)
        {
            _data = data;
            _filename = filename;

            _type = typeof(T);
        }

        public void Generate()
        {
            var rows = new List<string>();

            rows.Add(CreateHeader());

            foreach (var item in _data)
                rows.Add(CreateRow(item));

            File.WriteAllLines($"{_filename}.csv", rows, Encoding.UTF8);
        }

        private string CreateHeader()
        {
            var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var orderedProps = properties.OrderBy(p => p.GetCustomAttribute<CultureItemAttribute>().ColumnOrder);

            var bob = new StringBuilder();

            foreach (var prop in orderedProps)
            {
                var attr = prop.GetCustomAttribute<CultureItemAttribute>();

                bob.Append(attr.Heading ?? prop.Name).Append(",");
            }
            int lastComma = bob.Length - 1;

            return bob.ToString(0, lastComma);
        }

        private string CreateRow(T item)
        {
            var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var orderedProps = properties.OrderBy(p => p.GetCustomAttribute<CultureItemAttribute>().ColumnOrder);

            var bob = new StringBuilder();

            foreach (var prop in orderedProps)
            {
                bob.Append(CreateItem(prop, item)).Append(",");
            }
            int lastComma = bob.Length - 1;

            return bob.ToString(0, lastComma);
        }

        private string CreateItem(PropertyInfo prop, T item)
        {
            var attr = prop.GetCustomAttribute<CultureItemAttribute>();

            //Console.WriteLine(attr.Format);
            //Console.WriteLine(attr.Units);
            Console.WriteLine(prop.GetValue(item));
            var myvalue = prop.GetValue(item).GetType();
            Console.WriteLine(myvalue.ToString());
            // Console.WriteLine(string.Format($"{{0:{attr.Format}}}{attr.Units}", prop.GetValue(item)));

            return string.Format($"{{0:{attr.Format}}}{attr.Units}", prop.GetValue(item));
        }
    }
}
