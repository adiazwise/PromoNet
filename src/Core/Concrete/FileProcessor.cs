using PromoNet.src.Core.interfaces;

namespace PromoNet.src.Core.Concrete
{
    public class FileProcessor : IFileProcessor
    {
        public string LineColumns { get; init; }
        public string PathFile { get ; init; }

        public FileProcessor(string lineColumns,string pathFile)
        {
            LineColumns = lineColumns;
            PathFile = pathFile;
        }
        public void SendFile(string content)
        {
            if (!File.Exists(PathFile))
            {
               var file = File.CreateText(PathFile);
               file.Write(LineColumns + Environment.NewLine);
               file.Close();
            }
            using(StreamWriter writer = new StreamWriter(PathFile,true))
            {
                writer.WriteLine(content);
                writer.Close();
                
            }
        }
    }
}