using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakAwayWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {



                using (var context = new BAGA.BAEntities())
                {
                    List<BAGA.Customer> customers =
                    context.Customers.Include("Contact")
                    .Include("PrimaryActivity")
                    .Include("SecondaryActivity")
                    .Include("PrimaryDestinations")
                    .Include("SecondaryDestinations")
                    .Include("Reservations.Trip.Destination")
                    .ToList();

                    customerBindingSource.DataSource = customers;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
