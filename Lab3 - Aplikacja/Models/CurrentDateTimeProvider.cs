namespace Lab3___Aplikacja.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {

        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
