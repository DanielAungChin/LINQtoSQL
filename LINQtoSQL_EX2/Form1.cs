using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace LINQtoSQL_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Table(Name="Student_table")]
        public class Contact
        {
            [Column]
            public int student_id;
            [Column]
            public string student_Name;
            [Column]
            public string Gender;
            [Column]
            public string Course;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectiionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2019\Projects\exercise\LINQtoSQL_EX2\Student.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {
                DataContext db = new DataContext(ConnectiionString);//create DataContext
                Table < Contact >contacts = db.GetTable<Contact>();//create table
                var contactDetail = from c in contacts where c.Gender == "W" orderby c.student_Name select c;//LINQ to SQL
                foreach(var c in contactDetail)
                {
                    richTextBox1.AppendText(c.student_Name);
                    richTextBox1.AppendText("\t");
                    richTextBox1.AppendText(c.Course);
                    richTextBox1.AppendText("\n");
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
