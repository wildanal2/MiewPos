using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiewPos
{
    public partial class AksiRestokForm : Form
    {
        private RestockForm mForm;
        private string uidd,nama;

        public AksiRestokForm()
        {
            InitializeComponent();
        }
        public AksiRestokForm(Form calling,string uid,string nma)
        {
            mForm = calling as RestockForm;
            uidd = uid;
            nama = nma;
            InitializeComponent();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            mForm.itScan = false;
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        { 
            mForm._code = uidd;
            mForm.ShowNewBarangForm();
            this.Close(); 
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            mForm.HapusDataList(uidd);
            this.Close();
        }

        private void AksiRestokForm_Load(object sender, EventArgs e)
        {
            lbUid.Text = uidd;
            lbNama.Text = nama;
        }
    }
}
