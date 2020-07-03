using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Configuration;

namespace TFS_VPN_Logger
{
    class ADFactory
    {

        public void FetchADUsers ()

        {

            List<string> allUsers = new List<string>();
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "CZ.Toyota-fs.com", "OU=CIS Users Pre-Prod,OU=Suppliers,OU=Domain Users,OU=Toyota Financial Services Europe (CZ),DC=CZ,DC=Toyota-FS,DC=com");
            UserPrincipal userPrincipal = new UserPrincipal(principalContext);
            PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);

            foreach (var item in searcher.FindAll())
            {
                allUsers.Add(item.DisplayName);
            }


            var pocet = allUsers.Count;
        }

    }
}
