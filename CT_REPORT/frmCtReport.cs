using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using k.libary;

namespace CT_REPORT
{
    public partial class frmCtReport : frmSub
    {
        public string _Sever_CMDFX;
        public string _Sever_COMSUPPORT;
        public string _SQLLOAD;
        public string _month_S;
        public string _month_E;
        public string _WHID; 
        public frmCtReport(string connComsup, string connCMDBX,string WHID)
        {
            InitializeComponent();
            _Sever_CMDFX = connCMDBX;
            _Sever_COMSUPPORT = connComsup;
            _WHID = WHID;
            _SQLLOAD = @"SELECT ROW_NUMBER() OVER(ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)) AS RW,B.WHCODE,B.ABBNAME,A.FULLNAME,CONCAT(A.ADDR_ROW1, ' ', A.ADDR_ROW2, ' ', A.ADDR_PROVINCE, ' ', A.ADDR_ZIPCODE) AS ADDR, A.ADDR_MOBILE, A.BIRTHDATE, A.AGE, A.SEX,
                            (SELECT TOP 1 PTDATE FROM POS_PT WHERE CT_ID = A.ID AND PTSTATUS IN ('R','S') ORDER BY PTDATE DESC) AS PTDATE  
                            FROM MAS_CT A
                            LEFT JOIN MAS_WH B ON A.WH_ET_ID = B.ID
                            WHERE CT_STATUS = 'A' AND WH_ET_ID = " + _WHID + "AND A.BIRTHDATE IS NOT NULL  ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)";
        }

        private void FrmCtReport_Load(object sender, EventArgs e)
        { 
            lsvDt.LabelWrap = true;
            // Add Columns   
            lsvDt.Columns.Add("ลำดับ", 70, HorizontalAlignment.Left);
            lsvDt.Columns.Add("รหัสสาขา", 100, HorizontalAlignment.Left);
            lsvDt.Columns.Add("ชื่อสาขา", 130, HorizontalAlignment.Left);
            lsvDt.Columns.Add("ชื่อลูกค้า", 120, HorizontalAlignment.Left);
            lsvDt.Columns.Add("ที่อยู่", 130, HorizontalAlignment.Left);
            lsvDt.Columns.Add("หมายเลขโทรศัพท์", 70, HorizontalAlignment.Left);
            lsvDt.Columns.Add("วันเดือนปีเกิด", 100, HorizontalAlignment.Left);
            lsvDt.Columns.Add("อายุ", 130, HorizontalAlignment.Left); 
            lsvDt.Columns.Add("เพศ", 120, HorizontalAlignment.Left);
            lsvDt.Columns.Add("ซื้อล่าสุด", 130, HorizontalAlignment.Left);

            lsvDt.Width = this.Width - 30;
            lsvDt.Height = pnlNavigate.Top - 100;
            //pnlNRPP.Left = this.Width - pnlNRPP.Width - 30;
            LsvPageGlobVar.NRPP = 25;
            LsvPageGlobVar.ConStr = _Sever_CMDFX;
            LsvPageFunc.DbConnection();
            LsvPageGlobVar.Page = 1;
            pb.Visible = true;
            backgroundWorker1.RunWorkerAsync(); 
            lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
            
        }

       

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            LsvPageFunc.ExecSQLQry(_SQLLOAD);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Finish
            pb.Visible = false;
            try
            {
                //lsvSearch.addDataWithDataset(Table, false, false);
                LsvPageFunc.FillLsvData(LsvPageGlobVar.sqlDataTable, lsvDt, 0);
                lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
                //button_Select.Enabled = true;
                pb.Visible = false;
            }
            catch
            {

                //button_Select.Enabled = true;
            }
        } 

        

        private void frmLsvPage_Resize(object sender, EventArgs e)
        {
            lsvDt.Width = this.Width - 30;
            lsvDt.Height = pnlNavigate.Top - 100; 
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            LsvPageGlobVar.Page = 1;
            LsvPageFunc.FillLsvData(LsvPageGlobVar.sqlDataTable, lsvDt, 0);
            lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LsvPageGlobVar.Page = LsvPageGlobVar.TotalPages;
            LsvPageFunc.FillLsvData(LsvPageGlobVar.sqlDataTable, lsvDt, 0);
            lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (LsvPageGlobVar.Page < LsvPageGlobVar.TotalPages)
            {
                LsvPageGlobVar.Page++;
            }
            LsvPageFunc.FillLsvData(LsvPageGlobVar.sqlDataTable, lsvDt, 0);
            lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (LsvPageGlobVar.Page > 1)
            {
                LsvPageGlobVar.Page--;
            }
            LsvPageFunc.FillLsvData(LsvPageGlobVar.sqlDataTable, lsvDt, 0);
            lblInfo.Text = "Record Shown: " + LsvPageGlobVar.RecStart + " to " + LsvPageGlobVar.RecEnd + "                      Page " + LsvPageGlobVar.Page + " of " + LsvPageGlobVar.TotalPages;
        } 

        private void frmLsvPage_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Thanks & Regards \n By Anand. G, \n ag@live.in \n This is Redirect to My Facebook Page", "List View With Paging", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://www.facebook.com/anandkch");
        }

        public class LsvPageGlobVar
        {
            public static string ConStr;
            public static DataTable sqlDataTable = new DataTable();
            public static DataTable _masWh = new DataTable();
            public static int TotalRec; //Variable for getting Total Records of the Table
            public static int NRPP; //Variable for Setting the Number of Recrods per listiview page
            public static int Page; //List View Page for Navigate or move
            public static int TotalPages; //Varibale for Counting Total Pages.
            public static int RecStart; //Variable for Getting Every Page Starting Record Index
            public static int RecEnd; //Variable for Getting Every Page End Record Index
        }
        public class LsvPageFunc
        {
            public static bool DbConnection()
            {
                bool functionReturnValue = false;

                try
                { 
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = LsvPageGlobVar.ConStr; 
                    conn.Open();
                    functionReturnValue = true;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    functionReturnValue = false;
                    MessageBox.Show("Error : " + ex.ToString());
                }
                return functionReturnValue;
            }

            //Function to execute all queires
            public static DataTable ExecSQLQry(string SQLQuery)
            {
                try
                { 
                    SqlConnection conn = new SqlConnection();
                    
                    conn.ConnectionString = LsvPageGlobVar.ConStr;
                    SqlDataAdapter da = new SqlDataAdapter(SQLQuery, conn);
                    da.SelectCommand.CommandTimeout = 240;
                    LsvPageGlobVar.sqlDataTable.Reset();
                    da.Fill(LsvPageGlobVar.sqlDataTable);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error : " + ex.ToString());

                }
                return LsvPageGlobVar.sqlDataTable;
            }

           


            public static void FillLsvData(DataTable sqlData, ListView lvList, int imageID)
            {
                //Load the table data in the listview
                int i = 0;
                int j = 0;
                int m = 0;
                int xsize;


                lvList.Items.Clear();
                // for Adding Column Names from the datatable

                LsvPageGlobVar.TotalRec = sqlData.Rows.Count;

                //try
                //{
                LsvPageGlobVar.TotalPages = LsvPageGlobVar.TotalRec / LsvPageGlobVar.NRPP;

                if (LsvPageGlobVar.TotalRec % LsvPageGlobVar.NRPP > 0)
                {
                    LsvPageGlobVar.TotalPages++;
                }
                //}

                //catch(DivideByZeroException e)
                //{
                //    MessageBox.Show("Error : " + e.ToString());
                //}


                //for (i = 0; i <= sqlData.Columns.Count - 1; i++)
                //{
                //    lvList.Columns.Add(sqlData.Columns[i].ColumnName);
                //}

                //for adding records to the listview from datatable
                int l, k;

                l = (LsvPageGlobVar.Page - 1) * LsvPageGlobVar.NRPP;
                k = ((LsvPageGlobVar.Page) * LsvPageGlobVar.NRPP);

                LsvPageGlobVar.RecStart = l + 1;
                if (k > LsvPageGlobVar.TotalRec)
                {
                    LsvPageGlobVar.RecEnd = LsvPageGlobVar.TotalRec;
                }
                else
                {
                    LsvPageGlobVar.RecEnd = k;
                }

                for (; l < k; l++)
                {
                    if (l >= LsvPageGlobVar.TotalRec)
                    {
                        break;
                    }

                    lvList.Items.Add(sqlData.Rows[l][0].ToString(), imageID);

                    for (j = 1; j <= sqlData.Columns.Count - 1; j++)
                    {
                        if (!System.Convert.IsDBNull(sqlData.Rows[l][j]))
                        {
                            if (m % 2 == 0) lvList.Items[m].BackColor = Color.FromArgb(204, 231, 239);
                            else lvList.Items[m].BackColor = Color.White;
                            if (j == 6 || j == 9)
                            {
                                lvList.Items[m].SubItems.Add(DateTime.Parse(sqlData.Rows[l][j].ToString()).ToString("dd/MM/yyyy"));
                            }
                            else if (j == 8)
                            {
                                if (sqlData.Rows[l][j].ToString() == "F") lvList.Items[m].SubItems.Add("หญิง");
                                else if (sqlData.Rows[l][j].ToString() == "M") lvList.Items[m].SubItems.Add("ชาย");
                            }
                            else
                            { 
                                lvList.Items[m].SubItems.Add(sqlData.Rows[l][j].ToString());
                            }
                                
                        }
                        else
                        {
                            lvList.Items[m].SubItems.Add("");

                        }
                    }
                    m++;
                }


                //for rearrange the column size

                //lvList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //lvList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                //lvList.FullRowSelect = true;
                //for (i = 0; i <= sqlData.Columns.Count - 1; i++)
                //{
                //    xsize = lvList.Width / sqlData.Columns.Count - 8;

                //    if (xsize > 1450)
                //    {
                //        lvList.Columns[i].Width = xsize;
                //        lvList.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                //    }

                //    else
                //    {
                //        lvList.Columns[i].Width = 2000;
                //        lvList.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                //    }
                //}
            }
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripAddMP_Click(object sender, EventArgs e)
        {
            string addOn = "";
            using (frmOption Modaladd = new frmOption(_Sever_COMSUPPORT,_Sever_CMDFX,_WHID))
            {
                Modaladd.ShowDialog();
                if (Modaladd._status)
                {
                    if (Modaladd._chkWh == 0) addOn = " AND A.WH_ET_ID =" + _WHID;
                    else if (Modaladd._chkWh == 2) addOn = " AND A.WH_ET_ID =" + Modaladd._WhIdSelect;
                    else if (Modaladd._chkWh == 3) addOn = " ";
                    if (Modaladd._typeSearch == 0) //ชื่อลูกค้า
                    {
                        
                        _SQLLOAD = @"SELECT ROW_NUMBER() OVER(ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)) AS RW,B.WHCODE,B.ABBNAME,A.FULLNAME,CONCAT(A.ADDR_ROW1, ' ', A.ADDR_ROW2, ' ', A.ADDR_PROVINCE, ' ', A.ADDR_ZIPCODE) AS ADDR, A.ADDR_MOBILE, A.BIRTHDATE, A.AGE, A.SEX,
                            (SELECT TOP 1 PTDATE FROM POS_PT WHERE CT_ID = A.ID AND PTSTATUS IN ('R','S') ORDER BY PTDATE DESC) AS PTDATE  
                            FROM MAS_CT A
                            LEFT JOIN MAS_WH B ON A.WH_ET_ID = B.ID
                            WHERE CT_STATUS = 'A' " + addOn + "  AND A.BIRTHDATE IS NOT NULL AND A.FULLNAME LIKE '%" + Modaladd.txtFullname.Text + "%' ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)";
                    }
                    else if (Modaladd._typeSearch == 1) //หมายเลขโทรศัพท์
                    {
                        _SQLLOAD = @"SELECT ROW_NUMBER() OVER(ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)) AS RW,B.WHCODE,B.ABBNAME,A.FULLNAME,CONCAT(A.ADDR_ROW1, ' ', A.ADDR_ROW2, ' ', A.ADDR_PROVINCE, ' ', A.ADDR_ZIPCODE) AS ADDR, A.ADDR_MOBILE, A.BIRTHDATE, A.AGE, A.SEX,                             
                            (SELECT TOP 1 PTDATE FROM POS_PT WHERE CT_ID = A.ID AND PTSTATUS IN ('R','S') ORDER BY PTDATE DESC) AS PTDATE  
                            FROM MAS_CT A
                            LEFT JOIN MAS_WH B ON A.WH_ET_ID = B.ID
                            WHERE CT_STATUS = 'A' " + addOn + "  AND A.BIRTHDATE IS NOT NULL AND A.ADDR_MOBILE LIKE '%" + Modaladd.txtMobile.Text + "%' ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)";
                    }
                    else if (Modaladd._typeSearch == 2) //เดือนเกิด
                    {
                        _month_S = Modaladd._monthS;
                        _month_E = Modaladd._monthE;
                        _SQLLOAD = @"SELECT ROW_NUMBER() OVER(ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)) AS RW,B.WHCODE,B.ABBNAME,A.FULLNAME,CONCAT(A.ADDR_ROW1, ' ', A.ADDR_ROW2, ' ', A.ADDR_PROVINCE, ' ', A.ADDR_ZIPCODE) AS ADDR, A.ADDR_MOBILE, A.BIRTHDATE, A.AGE, A.SEX,                             
                            (SELECT TOP 1 PTDATE FROM POS_PT WHERE CT_ID = A.ID AND PTSTATUS IN ('R','S') ORDER BY PTDATE DESC) AS PTDATE                              
                            FROM MAS_CT A
                            LEFT JOIN MAS_WH B ON A.WH_ET_ID = B.ID
                            WHERE CT_STATUS = 'A' " + addOn + "  AND A.BIRTHDATE IS NOT NULL AND MONTH(A.BIRTHDATE) BETWEEN '" + _month_S + "' AND '" + _month_E + "' ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)";
                    }
                    else if (Modaladd._typeSearch == 3) //ทั้งหมด
                    {
                        _SQLLOAD = @"SELECT ROW_NUMBER() OVER(ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)) AS RW,B.WHCODE,B.ABBNAME,A.FULLNAME,CONCAT(A.ADDR_ROW1, ' ', A.ADDR_ROW2, ' ', A.ADDR_PROVINCE, ' ', A.ADDR_ZIPCODE) AS ADDR, A.ADDR_MOBILE, A.BIRTHDATE, A.AGE, A.SEX,
                            (SELECT TOP 1 PTDATE FROM POS_PT WHERE CT_ID = A.ID AND PTSTATUS IN ('R','S') ORDER BY PTDATE DESC) AS PTDATE  
                            FROM MAS_CT A
                            LEFT JOIN MAS_WH B ON A.WH_ET_ID = B.ID
                            WHERE CT_STATUS = 'A' " + addOn + "  AND A.BIRTHDATE IS NOT NULL  ORDER BY DAY(A.BIRTHDATE),MONTH(A.BIRTHDATE),YEAR(A.BIRTHDATE)";
                    }
                    pb.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                    //LsvPageFunc.FillLsvData(LsvPageFunc.ExecSQLQry(_SQLLOAD), lsvData, 0);
                }
                else
                { 
                } 
            }
        }

        private void LsvDt_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lsvDt.setSortOrder(e);
        }
    }
}
