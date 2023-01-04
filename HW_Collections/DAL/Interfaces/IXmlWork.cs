namespace HW_Collections.DAL.Interfaces
{
    public interface IXmlWork
    {
        public bool UploadToXml();

        public List<Department> DownloadFromXml();
    }
}
