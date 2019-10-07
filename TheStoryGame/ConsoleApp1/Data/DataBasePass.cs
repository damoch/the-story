namespace TheStoryWindows.Data
{
    internal class DataBasePass
    {

        public DataBasePass(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }
    }
}
