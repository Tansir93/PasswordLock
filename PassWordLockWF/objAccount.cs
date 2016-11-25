using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWordLockWF
{
  internal  class objAccount
    {
        private string _appname;

        private string _account;

        private string _password;

        public string AppName
        {
            get { return _appname; }
            set { _appname = value; }
        }

        public string Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_appname);
            sb.Append("^");
            sb.Append(_account);
            sb.Append("^");
            sb.Append(_password);
            sb.Append("&");
            return sb.ToString();
        }
    }
}
