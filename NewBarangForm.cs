using MiewPos.Addons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MiewPos
{
    public partial class NewBarangForm : Form
    {
        private RestockForm mForm;
        private string status = "new";
        private CariPosBarang cpb;

        public NewBarangForm()
        {
            InitializeComponent();
        }

        public NewBarangForm(Form calling)
        {
            mForm = calling as RestockForm;
            InitializeComponent();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNama.Text) || String.IsNullOrEmpty(tbMerk.Text) || String.IsNullOrEmpty(tbStock.Text) || String.IsNullOrEmpty(tbHargaa.Text))
                return;

            ItemBarang brg = new ItemBarang(
                tbuid.Text.ToString(),
                tbNama.Text.ToString(),
                tbMerk.Text.ToString(),
                Convert.ToInt32(tbStock.Text.ToString()),
                Convert.ToInt32(tbhargakulak.Text.ToString()),
                Convert.ToInt32(tbHargaa.Text.ToString()),
                Convert.ToInt32(tbHargab.Text.ToString())
                );
            if (status =="new")
            {
                mForm.AddDataListBrg(brg);
            }
            else
            {
                // ini listlocal status=edit 
                mForm.GantiDataList(brg, cpb.posisi);
            }
            
            mForm.setcodelbelWaiting();
            this.Close();
        }

        private void NewBarangForm_Load(object sender, EventArgs e)
        { 
            this.ActiveControl = tbNama;
            tbuid.Text = mForm._code;

            cpb = mForm.FindIdInList(mForm._code);
            //jika ada data sebelumnya di list
            if (cpb.isFound)
            {
                status = "edit";
                labelJudul.Text = "Barang Edit";
                ItemBarang brg = mForm.getItmBarangs(cpb.posisi);
                tbNama.Text = brg.nama;
                tbMerk.Text = brg.merk;
                tbStock.Text = brg.stok.ToString();
                tbhargakulak.Text = brg.hargakulak.ToString();
                tbHargaa.Text = brg.hargaecer.ToString();
                tbHargab.Text = brg.hargabakul.ToString();
            }
            // jika tidak ada di list cari di DB
            //find in db first
            else
            {
                MySqlConnection myConn = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=db_posmiew");

                try
                {
                    myConn.Open();
                    MySqlCommand myCommand = new MySqlCommand("SELECT * FROM barang left JOIN tbl_kulakan on barang.bid=tbl_kulakan.bid where tbl_kulakan.bid=" + mForm._code+" ORDER BY tbl_kulakan.tanggal DESC LIMIT 1", myConn);
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
                    myAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    myAdapter.Fill(dt);
                    //end
                    myConn.Close();
                    if (dt.Rows.Count == 0)
                    {
                        Debug.WriteLine( "TidaK ADA" );
                    }
                    else
                    {
                        grSebelum.Visible = true;
                        Debug.WriteLine("ADA");
                        DataRow dr = dt.Rows[0];
                        tbNama.Text = dr["nama"].ToString();
                        tbMerk.Text = dr["merk"].ToString();
                        hargasebelum.Text ="Rp "+ dr["harga_k"].ToString();
                    }       
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("RQUEST CEK db ERROR");
                    Debug.WriteLine(ex);
                }
            }
            // Berati Data baru
        }
  

        private void btnClose_Click(object sender, EventArgs e)
        {
            mForm.setcodelbelWaiting();
            this.Close();
        }
         
    }
}
