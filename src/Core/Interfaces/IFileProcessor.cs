namespace PromoNet.src.Core.interfaces
{
    public interface IFileProcessor
    {
        string LineColumns{get;init;}
        string PathFile{get;init;}
         void SendFile(string content);
         
    }
}