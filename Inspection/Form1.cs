using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace Inspection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void complaintBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.complaintBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inspectorDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inspectorDBDataSet.Inspection' table. You can move, or remove it, as needed.
            this.inspectionTableAdapter.Fill(this.inspectorDBDataSet.Inspection);
            // TODO: This line of code loads data into the 'inspectorDBDataSet.Complaint' table. You can move, or remove it, as needed.
            this.complaintTableAdapter.Fill(this.inspectorDBDataSet.Complaint);

        }
        
        

        private void complaintDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void openscan_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void scanbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg;*.bmp;*.png | *.jpg;*.bmp;*.png; | All files(*.*) | *.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();

                byte[] images = null;
                FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                connection.Open();
                string sqlQuery = "Insert into Complaint (complaint_scan) Values(@images)";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(N.ToString() + "Изображение сохранено");


            }
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Чижова\\Desktop\\Зак_Диплом\\Inspection\\Inspection\\InspectorDB.mdf;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;

        private void vievcomplaintbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

