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
namespace QueryResult
{
    public partial class DisplayTitleResult : Form
    {
        private BooksEntities dbContext = new BooksEntities();


        public DisplayTitleResult()
        {
            InitializeComponent();
        }

        private void DisplayTitleResult_Load(object sender, EventArgs e)
        {
            dbContext.Titles.Load();

            QuerysComboBox.SelectedIndex = 0;
        }

        private void QuerysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (QuerysComboBox.SelectedIndex)
            {
                case 0:
                    titleBindingSource.DataSource =
                        dbContext.Titles.Local
                        .OrderBy(t => t.Title1);
                    break;
                case 1:
                    titleBindingSource.DataSource =
                        dbContext.Titles.Local
                        .Where(t => t.Copyright.Equals("2014"))
                        .OrderBy(t => t.Title1);
                    break;
                case 2:
                    titleBindingSource.DataSource =
                        dbContext.Titles.Local
                        .Where(t => t.Title1.EndsWith("How to Program"))
                        .OrderByDescending(t => t.Title1);
                    break;
                default:
                    break;


            }
        }
    }
}
