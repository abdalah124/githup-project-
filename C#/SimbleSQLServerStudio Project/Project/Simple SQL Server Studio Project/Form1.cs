using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Base_Mouse_Devlober_project.Create_Data_Base;
using Data_Base_Mouse_Devlober_project.Create_Tabl;
using Data_Base_Mouse_Devlober_project.Insert_Into;

using Data_Base_Mouse_Devlober_project.Select_All_From_Table;
using Data_Base_Mouse_Devlober_project.Delete_Data_Base;
using Data_Base_Mouse_Devlober_project.Delete_Table;
using Data_Base_Mouse_Devlober_project.Delete_Column;



namespace Data_Base_Mouse_Devlober_project
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

       

      





        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            

        }

     

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmCreateDB frm = new frmCreateDB();
            frm.ShowDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTable frm = new CreateTable();
            frm.ShowDialog();
        }

        private void insertIntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertInto frm = new InsertInto();
            frm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllFromTable frm = new SelectAllFromTable();
            frm.ShowDialog();
        }

        private void dataBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDB frm = new DeleteDB();
            frm.ShowDialog();
        }

       

        private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteTable frm = new DeleteTable();
            frm.ShowDialog();
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteColumn frm = new DeleteColumn();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}