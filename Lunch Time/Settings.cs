namespace Lunch_Time
{
    public class Settings
    {
        public byte[] olvState { get; set; }
        public string DisplayName { get; set; }
        public string LogFolder { get; set; }
        public string AdpUrl { get; set; }

        public Settings()
        {
            LogFolder = @"\\dcdckyftppi1\csftp.comicsuite.com\users\cstech\Lunch Time\";
            AdpUrl = "https://workforcenow.adp.com/";
        }
    }
}
