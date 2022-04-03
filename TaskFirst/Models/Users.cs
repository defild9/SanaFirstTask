namespace TaskFirst.Models
{
    public class Users
    {
		private static List<GetName> users = new List<GetName>();
		public static IEnumerable<GetName> User
        {
            get { return users; }
        }
		
        public static void AddUser(GetName name)
        {
            users.Add(name);
        }
	}
}
