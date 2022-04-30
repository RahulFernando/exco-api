namespace exco_api.Models
{
    public class User
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public UserType user_type { get; set; } = UserType.student;
        public string password { get; set; }
    }

    public class Login
    {
        public string user_name { get; set; }
        public string password { get; set; }
    }

    public class LoginResponse
    {
        public string user_name { get; set; }
        public string token { get; set; }
    }

    public enum UserType
    {
        student,
        faculty_member
    }
}