using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor.BL
{
    public abstract class CsvBase
    {

        public virtual string ConvertToCsv()
        {
            string strCsv = "";

            //read the object properties using reflection
            PropertyInfo[] properties = GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                //write property value
                strCsv += properties[i].GetValue(this).ToString();
                if (i != properties.Length - 1)
                {
                    strCsv += ",";
                }
            }

            return strCsv;
        }

        public virtual void ConvertFromCsv(string[] propertyValues)
        {
            //get properties using reflection
            PropertyInfo[] properties = GetType().GetProperties();
            for (var i = 0; i < properties.Length; i++)
            {
                string strType = properties[i].PropertyType.Name;
                switch (strType)
                {
                    case "Int32":
                        properties[i].SetValue(this, int.Parse(propertyValues[i]));
                        break;
                    case "DateTime":
                        properties[i].SetValue(this, DateTime.Parse(propertyValues[i]));
                        break;
                    case "Boolean":
                        properties[i].SetValue(this, bool.Parse(propertyValues[i]));
                        break;
                    case "Double":
                        properties[i].SetValue(this, double.Parse(propertyValues[i]));
                        break;
                    default:
                        //string
                        properties[i].SetValue(this, propertyValues[i]);
                        break;
                }
            }
        }
    }
}
