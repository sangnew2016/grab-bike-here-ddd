namespace tmsang.domain
{
    public interface ISmsProvider
    {
        void Send(string phone, string message);
    }
}
