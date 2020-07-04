using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Configuration;
using System.Windows.Forms;

namespace TFS_VPN_Logger
{
    public class ADFactory
    {

        private List<string> allUsers = new List<string>();

        public List<string> FetchADUsers (string searchbase)

        {            
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "CZ.Toyota-fs.com", searchbase);
            UserPrincipal userPrincipal = new UserPrincipal(principalContext);
            PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);

            foreach (var item in searcher.FindAll())
            {
                allUsers.Add(item.DisplayName);

                
            }
            return allUsers;
            
            
        }

    }
}
