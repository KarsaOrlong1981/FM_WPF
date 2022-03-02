using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FM_WPF
{
    public static class NameGenerator
    {
        private static List<string> assetsList;
        private static Random random = new Random();
        private static List<string> ReadNames(string filePath)
        {
            assetsList = new List<string>();
            var uri = new Uri(filePath);
            var rs = Application.GetResourceStream(uri);
           
            using (StreamReader sr = new StreamReader(rs.Stream))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    assetsList.Add(line);
                }
            }
            return assetsList;

        }
       
        public static string GetGermanForeName()
        {
            string name = string.Empty;
            assetsList = ReadNames("pack://application:,,,/TextFiles/DeutscheVornamen.txt");
            name = assetsList[random.Next(0, assetsList.Count)];
            return name;
        }
        public static string GetGermanSureName()
        {
            string name = string.Empty;
            assetsList = ReadNames("pack://application:,,,/TextFiles/DeutscheNachnamen.txt");
            name = assetsList[random.Next(0, assetsList.Count)];
            return name;
        }
       
    }
}
