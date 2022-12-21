namespace API
{
    public static class Settings
    {
        public static string Secret = Environment.GetEnvironmentVariable("APIKEY");
    }
}
