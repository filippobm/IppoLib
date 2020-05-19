namespace IppoLib
{
    public class MessageFormatter
    {
        public string Print(string message)
        {
            const string prefix = "message";
            return $"{prefix}: {message}";
        }
    }
}