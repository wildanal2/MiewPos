using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiewPos
{
    public partial class InventoryForm : Form
    {
        MySqlConnection myConn;
        MySqlCommand myCommand;
        MySqlDataAdapter myAdapter; 

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }



        void refreshData()
        {
            try
            {
                myConn = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=db_posmiew");
                myConn.Open();

                myCommand = new MySqlCommand("select * from barang",myConn); 
                myAdapter = new MySqlDataAdapter(myCommand);
                myAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                myAdapter.Fill(dt);

                Console.WriteLine("row:"+dt.Rows.Count+"|col:"+dt.Columns.Count);
                foreach(DataRow dr in dt.Rows)
                {
                    Console.WriteLine(dr["nama"].ToString());
                }
                dataGridView1.DataSource = dt; 
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                dataGridView1.Refresh();

                //end
                myConn.Close();
                Debug.WriteLine("Refresh data Successfull");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            RestockForm rf = new RestockForm();
            rf.ShowDialog();
        }

        private void InventoryForm_Activated(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
