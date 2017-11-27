namespace DiverseNote.Business.Providers.Interfaces
{
    public interface IEmailProvider
    {
        void Send(string subject, string toAddress, string fromAddress, string body);
    }
}