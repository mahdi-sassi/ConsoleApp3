using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Login
    {
    

        public Login(string v1, int v2, bool v3)
        {
            this.username = v1;
            this.code = v2;
            this.isDeleted = v3;
        }

        public string username { get; set; }
        //public string password { get; set; }
        public int code { get; set; }
        //public byte[] hashPassword { get; set; }
        public bool isDeleted { get; set; }
    }
}
