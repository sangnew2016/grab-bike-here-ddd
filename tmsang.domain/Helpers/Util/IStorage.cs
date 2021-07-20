namespace tmsang.domain
{
    public interface IStorage
    {
        void SmsSet(string email, string value);
        string SmsGetCode(string phone);
    }
}
