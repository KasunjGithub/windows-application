using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        DataTable stu = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //call the method of data table
            studentdetails();
            //pass the data into the combo box
            comboBox1.DataSource= stu;
            //display the student name in combobox for the selection
            comboBox1.DisplayMember = "STNAME";
        }
        private void studentdetails()
        {
            //add columns for data table
            stu.Columns.Add("STNAME");
            stu.Columns.Add("STID",typeof(int));
            stu.Columns.Add("ADDRESS");
            stu.Columns.Add("CONTACTNUMBER");

            stu.Rows.Add("Adams",96,"Jffna",0778065298);
            stu.Rows.Add("Jane", 92, "Puttalam", 0723289206);
            stu.Rows.Add("Tom", 89, "Badhulla", 07592069823);
            stu.Rows.Add("Lara", 83, "Hatton", 0716508928);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblsname.Text = stu.Rows[comboBox1.SelectedIndex]["STNAME"].ToString();
            lblsid.Text = stu.Rows[comboBox1.SelectedIndex]["STID"].ToString();
            lbladdress.Text = stu.Rows[comboBox1.SelectedIndex]["ADDRESS"].ToString();
            lblcontact.Text = stu.Rows[comboBox1.SelectedIndex]["CONTACTNUMBER"].ToString();
        }
    }
}
