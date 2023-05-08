using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pry_Basculas_SAP.Class
{
    class UserActiveDirectory
    {

       
        public void DatosUsuario()
        {
            // string sql = "" ;

            DirectoryEntry RootDirEntry = new DirectoryEntry("LDAP://RootDSE");
            Object distinguishedName = RootDirEntry.Properties["defaultNamingContext"].Value;





            // Establece la cadena de conexión al servidor de Active Directory
            string ldapPath = "LDAP://aliar.com.co";
            DirectoryEntry entry = new DirectoryEntry(ldapPath);

            // Crea un objeto de búsqueda y establece los criterios de búsqueda
            DirectorySearcher searcher = new DirectorySearcher(entry);
            searcher.Filter = "(samaccountname=edwin.martinez)";

            // Ejecuta la búsqueda y recupera el primer resultado
            SearchResult result1 = searcher.FindOne();

            // Accede a las propiedades del usuario encontrado
            string displayName = result1.Properties["displayname"][0].ToString();
            string email = result1.Properties["mail"][0].ToString();


        }

        public List<User> GetListADUsers()
        {
            List<User> rst = new List<User>();

            string DomainPath = "LDAP://aliar.com.co";
            DirectoryEntry adSearchRoot = new DirectoryEntry(DomainPath);
            DirectorySearcher adSearcher = new DirectorySearcher(adSearchRoot);

            adSearcher.Filter = "(&(objectClass=user)(objectCategory=person))";
            adSearcher.PropertiesToLoad.Add("samaccountname");
            adSearcher.PropertiesToLoad.Add("title");
            adSearcher.PropertiesToLoad.Add("mail");
            adSearcher.PropertiesToLoad.Add("usergroup");
            adSearcher.PropertiesToLoad.Add("company");
            adSearcher.PropertiesToLoad.Add("department");
            adSearcher.PropertiesToLoad.Add("telephoneNumber");
            adSearcher.PropertiesToLoad.Add("mobile");
            adSearcher.PropertiesToLoad.Add("displayname");
            SearchResult result;
            SearchResultCollection iResult = adSearcher.FindAll();

            User item;
            if (iResult != null)
            {
                for (int counter = 0; counter < iResult.Count; counter++)
                {
                    result = iResult[counter];
                    if (result.Properties.Contains("samaccountname"))
                    {
                        item = new User();

                        item.UserName = (String)result.Properties["samaccountname"][0];

                        if (result.Properties.Contains("displayname"))
                        {
                            item.DisplayName = (String)result.Properties["displayname"][0];
                        }

                        if (result.Properties.Contains("mail"))
                        {
                            item.Email = (String)result.Properties["mail"][0];
                        }

                        if (result.Properties.Contains("company"))
                        {
                            item.Company = (String)result.Properties["company"][0];
                        }

                        if (result.Properties.Contains("title"))
                        {
                            item.JobTitle = (String)result.Properties["title"][0];
                        }

                        if (result.Properties.Contains("department"))
                        {
                            item.Deparment = (String)result.Properties["department"][0];
                        }

                        if (result.Properties.Contains("telephoneNumber"))
                        {
                            item.Phone = (String)result.Properties["telephoneNumber"][0];
                        }

                        if (result.Properties.Contains("mobile"))
                        {
                            item.Mobile = (String)result.Properties["mobile"][0];
                        }
                        rst.Add(item);
                    }
                }
            }

            adSearcher.Dispose();
            adSearchRoot.Dispose();

            return rst;
        }

        public class User
        {
            public string UserName { get; set; }

            public string DisplayName { get; set; }

            public string Company { get; set; }

            public string Deparment { get; set; }

            public string JobTitle { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public string Mobile { get; set; }
        }




        public string  GetCurrentUserAD()
        {

            // Obtiene la identidad del usuario actualmente autenticado
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            // Obtiene el nombre del usuario en formato de cadena
            string userClean;
            string username = identity.Name.ToString();
            userClean = username.Substring(6);

            //StringBuilder str = new StringBuilder(username, 50);
            //str.Remove(5, 1);
            //userClean = str.ToString();

            //userClean.Insert(5,"'\\'");





            //string nameClean =  string.Concat("ALIAR\", userClean);
            
            return userClean;

        }


       
        

    }
}
