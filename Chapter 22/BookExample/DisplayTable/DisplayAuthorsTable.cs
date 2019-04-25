using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookExample;

namespace DisplayTable
{
    public partial class DisplayAuthorsTable : Form
    {
        private BooksEntities dbContext = new BooksEntities(); 


        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            dbContext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();
            authorBindingSource.DataSource = dbContext.Authors.Local;

        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();

            try
            {
                dbContext.SaveChanges();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
