using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;


namespace Chapter2Console
{
    class Program
    {
        private static void QueryContacts()
        {
            using (var context = new PEF())
            {
                var contacts = context.Contacts;
                foreach (var contact in contacts)
                {
                    Console.WriteLine("{0} {1}",
                    contact.FirstName.Trim(),
                    contact.LastName);
                }
            }
        }

        private static void FunctionOverride()
        {
            using (var context = new PEF())
            {
                var contact = context.Contacts.Include("Addresses")
                .Where(c => c.Addresses.Any()).First();
                //make a change to contact
                contact.LastName = contact.LastName.Trim() + "-Jones";
                //make a change to the address
                var address = contact.Addresses.First();
                address.Street2 = "Apartment 42";
                //call SaveChanges
                context.SaveChanges();
            }
        }

        private static void FindContactsByState()
        {
            using (var context = new PEF())
            {
                var results = context.GetContactsbyState("Washington");
                foreach (var c  in results)
                {
                    Console.WriteLine("Name : " + c.FirstName);
                }
            }
        }

        private static void EntitySQL()
        {
            using (var context = new PEF())
            {
                String query = "SELECT c.FirstName,c.LastName, c.Title " +
                "FROM PEF.Contacts AS c " +
                    "WHERE c.FirstName='Robert'";
                                
                var objectContext = ((IObjectContextAdapter)context).ObjectContext;
                ObjectQuery<DbDataRecord> contacts = objectContext.CreateQuery<DbDataRecord>(query);

                foreach (DbDataRecord record in contacts)
                {
                    Console.WriteLine("{0} {1} {2}",
                    record["Title"].ToString().Trim(),
                    record["FirstName"].ToString().Trim(),
                    record["LastName"].ToString().Trim());
                }
            }
        }
        static void Main(string[] args)
        {
            //QueryContacts();
            //FindContactsByState();
            EntitySQL();
            //FunctionOverride();
        }
    }
}
