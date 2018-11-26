using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {
        private int _id;
        private string _Fname;
        private string _Sname;
        private string _login;
        private string _password;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }
        }
        public string Sname
        {
            get { return _Sname; }
            set { _Sname = value; }
        }
        public string login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
