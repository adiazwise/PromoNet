namespace PromoNet.src.Core.interfaces
{
    public interface IFtpProcessor
    {
        string FtpServer{get;set;}
        string RemotePath{get;set;}
        string LocalPath{get;set;}
        void SendFile(string path);
    }
}