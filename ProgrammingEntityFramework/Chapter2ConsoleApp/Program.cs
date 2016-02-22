using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Common;

namespace Chapter2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryContacts();
        }

        private static void QueryContacts()
        {
            using (var context = new PEF())
            {
                context.Database.Log = Console.WriteLine;

                String query = "SELECT c, c.Addresses " +
                "FROM PEF.Contacts AS c " +
                "WHERE c.FirstName='Robert'";

                var adapter = (IObjectContextAdapter)context;
                var objectContext = adapter.ObjectContext;

                ObjectQuery<DbDataRecord> contacts = objectContext.CreateQuery<DbDataRecord>(query);

                //DbQuery
                foreach (DbDataRecord c in contacts)
                {
                    var contact = c[0] as Contact;
                    Console.WriteLine("{0} {1} {2}",
                                    contact.Title.Trim(),
                                    contact.FirstName.Trim(),
                                    contact.LastName);

                    //foreach (var a in contact.Addresses)
                    //{
                    //    Console.WriteLine(" {0}, {1}",
                    //    a.Street1.Trim(), a.City);
                    //}
                }
            }
        }
    }
}
