using HW_Collections.DAL.Interfaces;
using System.Xml;
using System.Xml.Linq;

namespace HW_Collections.DAL
{
    public class XmlWork : IXmlWork
    {
        public List<Department> DownloadFromXml()
        {
            string xml = System.IO.File.ReadAllText("departments.xml");
            var col = XDocument.Parse(xml)
                .Descendants("departments")
                .Descendants("department")
                .ToList();
            var departmentsList = new List<Department>();

            foreach (var item in col)
            {
                var department = new Department()
                {
                    DepName = item.Element("DepName").Value,
                    DateOfCreate = DateOnly.Parse(item.Element("DateOfCreate").Value)
                };
                departmentsList.Add(department);
            }
            return departmentsList;
           
        }

        public bool UploadToXml()
        {
            throw new NotImplementedException();
        }
    }
}
