using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataDrivenFramework.DataAccessLayer
{
    class FileReader
    {

        public Dictionary<String, String> PropertiesToDic(String filePath)
        {
            String[] textDate = File.ReadAllLines(filePath);

            var data = new Dictionary<string, string>();

            foreach (var line in textDate)
            {
                data.Add(line.Split('=')[0].Trim(), line.Split('=')[1].Trim());
            }

            return data;
        }
        public Dictionary<String, String> XmlToDic(String filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            var data = new Dictionary<string, string>();

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                data.Add(node.Name, node.InnerText);
            }

            return data;
        }
    }
}
