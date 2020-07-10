using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;

namespace TFS_VPN_Logger
{
    public class ADFactory
    {

        

       /* public List<string> FetchADUsers (string searchbase)

        {   
            List<string> allUsers = new List<string>();
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "CZ.Toyota-fs.com", searchbase);
            UserPrincipal userPrincipal = new UserPrincipal(principalContext);
            PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);
            foreach (var item in searcher.FindAll())
            {
                allUsers.Add(item.Name);                      
            }
            return allUsers;

            
            
        }*/



        public ArrayList Users (string searchbase)
        {
            ArrayList userList = new ArrayList();
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, "CZ.Toyota-fs.com", searchbase);
            UserPrincipal userPrincipal = new UserPrincipal(principalContext);
            PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);
            foreach (var item in searcher.FindAll())
            {
                userList.Add(new ADUser(item.Name, item.Sid.ToString()));

            }
            return userList;

        }


    }
}
