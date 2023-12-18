using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRemastered.models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string UserEmail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
    }
}
