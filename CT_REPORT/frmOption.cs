using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CT_REPORT
{
    public partial class frmOption : Form
    {
        public bool _status { get; set; }
        public int _typeSearch { get; set; }
        public string _monthS { get; set; }
        public string _monthE { get; set; }
        public int _chkWh { get; set; }
        public string _WhIdSelect { get; set; }
        public string _Sever_CMDFX;
        public string _Sever_COMSUPPORT;
        public string _WHID;
        public DataTable maswh = new DataTable();
        public frmOption(string connComsup, string connCMDBX, string WHID)
        {
            InitializeComponent();

            _Sever_CMDFX = connCMDBX;
            _Sever_COMSUPPORT = connComsup;
            _WHID = WHID;
        }

       

        private void FrmOption_Load(object sender, EventArgs e)
        {
            _typeSearch = 3;
            radioCtAll.Checked = true;
            month_S.Value = Convert.ToInt32(DateTime.Now.ToString("MM"));
            month_E.Value = Convert.ToInt32(DateTime.Now.ToString("MM"));
            checkWh.Checked = true;
            _chkWh = 0;
            LoadWh();



        }

        public void LoadWh()
        {
            try
            {
                string sqlWh = @"SELECT ID,WHCODE,ABBNAME,CONCAT(WHCODE,' ',ABBNAME) AS FULLNAME 
                                    FROM MAS_WH WHERE ADDR_ROW2 = '0' 
                                    AND (WHCODE LIKE '1%' OR WHCODE LIKE '3%' OR WHCODE LIKE '5%'  OR WHCODE LIKE '7%' ) AND WHCODE NOT LIKE '19%' AND WHCODE NOT LIKE '9%'
                                    ORDER BY WHCODE ";
                SqlConnection conn = new SqlConnection(_Sever_CMDFX);
                SqlDataAdapter da = new SqlDataAdapter(sqlWh, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl");

                cbWhcode.DataSource = new BindingSource(ds.Tables["tbl"], null);
                cbWhcode.DisplayMember = "FULLNAME";
                cbWhcode.ValueMember = "ID";
                cbWhcode.SelectedValue = _WHID;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.ToString());

            }
        }

        private void Month_S_ValueChanged(object sender, EventArgs e)
        {
            _monthS = month_S.Value.ToString(); 
        }

        private void Month_E_ValueChanged(object sender, EventArgs e)
        {
            _monthE = month_E.Value.ToString();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            _status = true;
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            _status = false;
            this.Close();
        }

        private void RadioFullname_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFullname.Checked)
            {
                _typeSearch = 0;
                txtFullname.Enabled = true;
                txtMobile.Enabled = false;
                month_E.Enabled = false;
                month_S.Enabled = false; 
                txtMobile.Text = "";
            } 
        }

        private void RadioMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMobile.Checked)
            {
                _typeSearch = 1;
                txtFullname.Enabled = false;
                txtMobile.Enabled = true;
                month_E.Enabled = false;
                month_S.Enabled = false;
                txtFullname.Text = ""; 
            } 
        }

        private void RadioMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMonth.Checked)
            {
                _typeSearch = 2;
                txtFullname.Enabled = false;
                txtMobile.Enabled = false;
                month_E.Enabled = true;
                month_S.Enabled = true;
                txtFullname.Text = "";
                txtMobile.Text = "";
            } 
        }

        private void RadioCtAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCtAll.Checked)
            {
                _typeSearch = 3;
                txtFullname.Enabled = false;
                txtMobile.Enabled = false;
                month_E.Enabled = false;
                month_S.Enabled = false;
                txtFullname.Text = "";
                txtMobile.Text = "";
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CheckWh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWh.Checked)
            {
                _chkWh = 0;
                cbWhcode.Visible = false;
            }
        }

        private void CbWhcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _WhIdSelect = cbWhcode.SelectedValue.ToString();
        }
         

        private void Chkwh2_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkwh2.Checked)
            {
                _chkWh = 2;
                cbWhcode.Visible = true;
            }
        }

        private void Chkwh3_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkwh3.Checked)
            {
                _chkWh = 3;
                cbWhcode.Visible = false;
            }
        }
    }
}
