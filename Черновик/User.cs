using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Черновик
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public bool CheckUser()
        {
            return true;
        }

        private string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString());
                }
                return sb.ToString();
            }
        }
    }
}
