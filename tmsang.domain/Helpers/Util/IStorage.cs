namespace tmsang.domain
{
    public interface IStorage
    {
        string WebRootPath { get; set; }

        void SmsSet(string email, string value);
        string SmsGetCode(string phone);
    }
}
