using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFS_VPN_Logger
{
    class ADUser
    {
        private string privName;
        private string privSid;

        public ADUser(string strName, string strSid)
        {
            this.privName = strName;
            this.privSid = strSid;
        }

        public string Name
        {
            get
            {
                return privName;
            }
        }

        public string SID
        {

            get
            {
                return privSid;
            }
        }

    }
}
