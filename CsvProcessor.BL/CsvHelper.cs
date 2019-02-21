using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor.BL
{
    public class CsvHelper<T> where T : CsvBase, new()
    {
        public CsvHelper(string filePath)
        {
            this.FullFilePath = filePath;
        }

        public string FullFilePath { get; set; }

        public void WriteToFile(IEnumerable<T> objects)
        {
            IList<T> objs = objects as IList<T> ?? objects.ToList();
            if (objs.Any())
            {
                using (StreamWriter writer = new StreamWriter(this.FullFilePath))
                {
                    foreach (T obj in objs)
                    {
                        writer.WriteLine(obj.ConvertToCsv());
                    }
                }
            }
        }

        public IEnumerable<T> ReadFromFile()
        {
            List<T> objects = new List<T>();
            using (StreamReader reader = new StreamReader(this.FullFilePath))
            {
                string line;
                do
                {
                    line = reader.ReadLine();

                    if (line != null )
                    {
                        T obj = new T();
                        string[] propertyValues = line.Split(',');
                        obj.ConvertFromCsv(propertyValues);
                        objects.Add(obj);
                    }
                    
                } while (line != null);
            }

            return objects;
        }

    }

}
