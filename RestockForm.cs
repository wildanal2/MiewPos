using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using MiewPos.Addons;
using MySql.Data.MySqlClient;

namespace MiewPos
{
    public partial class RestockForm : Form
    {
        readonly object _lock = new object();
        SerialPort _serialPort;
        public string _code = "";
        List<Addons.ItemBarang> itemBarangs;
        List<Addons.ItemBarang> itemBarangsBaru;
        public bool itScan = false;

        public RestockForm()
        {
            InitializeComponent();
        }

        private void RestockForm_Load(object sender, EventArgs e)
        { 
            itemBarangs = new List<ItemBarang>(); 

            string[] ports = SerialPort.GetPortNames();
            foreach (string po in ports)
            {
                comboport.Items.Add(po);
            }
            RefreshDataList();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (_serialPort !=null && _serialPort.IsOpen)
            {
                btnConnect.Text = "Connect";
                labelCode.Text = "____________";
                _serialPort.Close();
                _serialPort = null;
                return;
            }

            _serialPort = new SerialPort(comboport.Text.Trim(), 19200, Parity.Space, 8, StopBits.One);
            _serialPort.ParityReplace = 0;
            _serialPort.DataReceived += DataReceived;
            _serialPort.ErrorReceived += ErrorReceived;
            _serialPort.Open();

            if (_serialPort.IsOpen)
            {
                btnConnect.Text = "Disconnect";
                labelCode.Text = "waiting scan.....";
            }
        }

        private void ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (e.EventType == SerialError.RXParity)
                readingCode();
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {  
            readingCode();
        }

        void readingCode()
        {
            if (_serialPort == null || itScan == true)
            {
                if(_serialPort != null)
                {
                    _serialPort.DiscardInBuffer();
                    _serialPort.DiscardOutBuffer(); 
                }
                return;
            } 

            lock (_lock)
            {
                _code = "";
                while (_serialPort.BytesToRead > 0)
                {
                    var chunk = new byte[_serialPort.BytesToRead];
                    _serialPort.Read(chunk, 0, chunk.Length);
                    System.Text.Encoding enc = System.Text.Encoding.ASCII;
                    _code += enc.GetString(chunk);
                    Debug.WriteLine("ini:" + enc.GetString(chunk));
                }
                Debug.WriteLine("jdi:" + _code);
            }
            this.BeginInvoke(new EventHandler(DisplayThreadText));
        }

        private void DisplayThreadText(object sender, EventArgs e)
        {
            textBox1.AppendText(_code);
            textBox1.AppendText("\n");
            labelCode.Text = _code;
            itScan = true;

            NewBarangForm newB = new NewBarangForm(this);
            newB.ShowDialog();
        }

        private void RestockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( _serialPort!=null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            } 
        }

        private void btnSaveRestock_Click(object sender, EventArgs e)
        { 
            Debug.WriteLine("total : "+itemBarangs.Count);
            if (string.IsNullOrEmpty(tbNamaToko.Text) || itemBarangs.Count==0)
                return;
            ProsesInputKeDB();
        }

        #region //set get method
        public void setcodelbelWaiting()
        {
            labelCode.Text = "waiting scan.....";
        }
        public void AddDataListBrg(ItemBarang brg)
        {
            this.itemBarangs.Add(brg);
        }

        public ItemBarang getItmBarangs(int i)
        {
            return itemBarangs[i];
        }

        public CariPosBarang FindIdInList(string id)
        {
            CariPosBarang pBrg = new CariPosBarang();
            int p = 0;
            foreach (ItemBarang brg in itemBarangs)
            {
                if (brg.uid.Equals(id))
                {
                    pBrg.isFound = true;
                    pBrg.posisi = p;
                    break;
                }
                p++;
            }
            return pBrg;
        }

        public void GantiDataList(ItemBarang brg,int pos)
        {
            itemBarangs[pos] = brg;
        }

        public void HapusDataList(string uid)
        {
            int p = 0;
            foreach (ItemBarang brg in itemBarangs)
            {
                if (brg.uid.Equals(uid))
                { 
                    break;
                }
                p++;
            }
            itemBarangs.RemoveAt(p);
        }

        public void RefreshDataList()
        {
            Debug.WriteLine("Refresh data");

            DataTable dt = new DataTable();
            dt.Columns.Add("No"); 
            dt.Columns.Add("UID");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Merk");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Sub-Hrg Kulak");
            dt.Columns.Add("Hrg Ecer");
            dt.Columns.Add("Hrg bakul");
            int n = 1,tot=0;
            foreach (ItemBarang brg in itemBarangs)
            {
                DataRow dr = dt.NewRow();
                dr[0] = n;
                dr[1] = brg.uid;
                dr[2] = brg.nama;
                dr[3] = brg.merk;
                dr[4] = brg.stok;
                dr[5] = brg.hargakulak;
                dr[6] = (Convert.ToInt32(brg.hargakulak) * Convert.ToInt32(brg.stok));
                dr[7] = brg.hargaecer;
                dr[8] = brg.hargabakul;
                //
                tot += (Convert.ToInt32(brg.hargakulak) * Convert.ToInt32(brg.stok));
                n++;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();

            lbHargaTotalBarang.Text = "Rp "+tot;
        }
        #endregion

        private void RestockForm_Activated(object sender, EventArgs e)
        { 
            RefreshDataList();
            itScan = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string arguid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string argnama = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Debug.WriteLine("cel:" + arguid);
            if (string.IsNullOrEmpty(arguid))
                return;

            itScan = true;
            AksiRestokForm newB = new AksiRestokForm(this,arguid,argnama);
            newB.ShowDialog();
        }

        public void ShowNewBarangForm()
        {
            NewBarangForm newB = new NewBarangForm(this);
            newB.ShowDialog();
        }

        #region //SAVE TO DB
        public void ProsesInputKeDB()
        {
            string tglkulakan = dateKulakan.Value.Date.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");
            MySqlConnection myConn = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=db_posmiew");
            
            // #1 Cek Data Jika belum ada DI DB
            itemBarangsBaru = new List<ItemBarang>(); //buat list untuk barang baru
            foreach (ItemBarang brg in itemBarangs)
            {
                try
                {
                    myConn.Open();
                    MySqlCommand myCommand = new MySqlCommand("select * from barang where bid="+brg.uid, myConn);
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
                    myAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    myAdapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        Debug.WriteLine(brg.nama+" TidaK ADA");
                        itemBarangsBaru.Add(brg);
                    }
                    //end
                    myConn.Close();
                    Debug.WriteLine("Cek data Successfull");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("RQUEST CEK db ERROR");
                    Debug.WriteLine(e);
                }
            }
            Debug.WriteLine(itemBarangsBaru.Count()+ "BARANG Baru");

            //#2 INPUT LIST BARANG jika belum Ada KE DB
            Debug.WriteLine("MULAI Proses #2 INPUT LIST BARANG ");
            foreach (ItemBarang nbrg in itemBarangsBaru)
            {
                try
                {
                    myConn.Open();
                    MySqlCommand comm = myConn.CreateCommand();
                    comm.CommandText = "INSERT INTO barang(bid,nama,merk,stok) VALUES(@bid, @nama, @merk, 0)";
                    comm.Parameters.AddWithValue("@bid", nbrg.uid);
                    comm.Parameters.AddWithValue("@nama", nbrg.nama);
                    comm.Parameters.AddWithValue("@merk", nbrg.merk);
                    comm.ExecuteNonQuery();
                    //end
                    myConn.Close();
                    Debug.WriteLine("INPUT LIST BARANG "+nbrg.nama+" Successfull");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("INPUT LIST BARANG ERROR");
                    Debug.WriteLine(e);
                }
            }

            //#3 Input List ke Tbl_Kulakan
            Debug.WriteLine("MULAI Proses #3 Input List ke Tbl_Kulakan");
            foreach (ItemBarang brg in itemBarangs)
            {
                try
                {
                    myConn.Open();
                    MySqlCommand comm = myConn.CreateCommand();
                    comm.CommandText = "INSERT INTO tbl_kulakan(bid,toko_kulak,jumlah,harga_k,sub_harga,tanggal) VALUES(@bid, @toko_kulak, @jumlah, @harga_k, @sub_harga, @tgl)";
                    comm.Parameters.AddWithValue("@bid", brg.uid);
                    comm.Parameters.AddWithValue("@toko_kulak", tbNamaToko.Text);
                    comm.Parameters.AddWithValue("@jumlah", brg.stok);
                    comm.Parameters.AddWithValue("@harga_k", brg.hargakulak);
                    comm.Parameters.AddWithValue("@sub_harga", (brg.stok* brg.hargakulak));
                    comm.Parameters.AddWithValue("@tgl", tglkulakan); 
                    comm.ExecuteNonQuery();
                    //end
                    myConn.Close();
                    Debug.WriteLine("INPUT LIST Kulakan " + brg.nama + " Successfull");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("INPUT LIST Kulakan ERROR");
                    Debug.WriteLine(e);
                }
            }

            //#4 Input List ke Tbl_UPDATE harga
            Debug.WriteLine("MULAI Proses #4 Input List ke Tbl_UPDATE harga");
            foreach (ItemBarang brg in itemBarangs)
            {
                try
                {
                    myConn.Open();
                    MySqlCommand comm = myConn.CreateCommand();
                    comm.CommandText = "INSERT INTO tbl_updateharga(bid,harga_ecer,harga_bakul,tgl_update) VALUES(@bid, @harga_ecer, @harga_bakul, @tgl_update)";
                    comm.Parameters.AddWithValue("@bid", brg.uid);
                    comm.Parameters.AddWithValue("@harga_ecer", brg.hargaecer);
                    comm.Parameters.AddWithValue("@harga_bakul", brg.hargabakul);
                    comm.Parameters.AddWithValue("@tgl_update", tglkulakan); 
                    comm.ExecuteNonQuery();
                    //end
                    myConn.Close();
                    Debug.WriteLine("INPUT LIST Kulakan " + brg.nama + " Successfull");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("INPUT LIST Kulakan ERROR");
                    Debug.WriteLine(e);
                }
            }
            
            //end
            this.Close();
        }
        #endregion
    }
}
