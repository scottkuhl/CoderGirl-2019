using System;

namespace UserSignup.Models
{
    public class User
    {
        public int UserId { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime JoinedDate { get; }


        private static int nextUserId = 0;

        public User()
        {
            UserId = ++nextUserId;
            JoinedDate = DateTime.Now;
        }
    }
}
