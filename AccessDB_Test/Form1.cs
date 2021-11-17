using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDB_Test
{
    public partial class Form1 : Form
    {

        System.Data.OleDb.OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }


        #region DB
        private void DBConnect(string strDBPath)
        {
            //OLEDB
            string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDBPath}";   //Source={경로}
            _conn = new OleDbConnection(connStr);

            string Query = $@"Select *
From Voca";

            QueryExeCute(Query);

        }

        //쿼리. 이렇게 따로 빼주면 접근할때마다 DB닫았다 열었다 안해도 됨
        private void QueryExeCute(string Query)
        {
            DataSet ds = new DataSet(); //DataGridView 쓸거니까~

            System.Data.OleDb.OleDbDataAdapter adp = new OleDbDataAdapter(Query, _conn);   // (쿼리,커낵션string)
            adp.Fill(ds);  //Adapter를 통해 나온 값들은 DataSet에 다 들어간다

            dgData.DataSource = ds.Tables[0];
        }
        #endregion



        // DB Load 버튼
        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;    //파일 위치한 경로
            OFDialog.FileName = "*.mdb";                           // 파일경로\\사용자가 저장할때 쓴 이름.mdb
            OFDialog.Filter = "db files (*.mdb)|*.mdb|All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPath.Text = OFDialog.FileName;
                DBConnect(tboxPath.Text);
                //DBConnect(OFDialog.FileName);
            }


        }

        // 실행 버튼. tboxQuery에 적어준 Query문을 보고 쿼리에 접근(DB에 접근)
        private void btnExe_Click(object sender, EventArgs e)
        {
            QueryExeCute(tboxQuery.Text);    
        }


        // 예제1,2,3 버튼
        private void btnEx_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string strQuery = null;

            switch (btn.Name)
            {
                case "btnEx1":
                    strQuery = $@"Select *
From Voca";
                    break;

                case "btnEx2":
                    strQuery = $@"Select *
From Voca
Where 단어 Like ""%a%""";
                    break;

                case "btnEx3":
                    strQuery = $@"Select*
From Voca
Order By ID DESC";
                    break;
                default:
                    break;
            }

            tboxQuery.Text = strQuery;
        }


        //Excel Export 버튼
        // DataGrideView에 보여진 Data를 Excel로 저장
        private void btnExport_Click(object sender, EventArgs e)
        {
            SFDialog.InitialDirectory = Application.StartupPath;   
            SFDialog.FileName = "*.xls";
            SFDialog.Filter = "xls files (*.xls)|*.elx|All files (*.*)|*.*";

            if(SFDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExe excel = new ExcelExe();  //class 선언

                string strFilePath = SFDialog.FileName;           
                DataTable dt = dgData.DataSource as DataTable;


                ExcelExe.enExportType enType = ExcelExe.enExportType.EXCEL_COM;      //enum
               //ExcelExe.enExportType enType = ExcelExe.enExportType.OLEDB_EXCEL;
               //ExcelExe.enExportType enType = ExcelExe.enExportType.CSV_STREAM;

                string strRet = excel.ExcelExport(strFilePath, dt, enType);
                MessageBox.Show(strRet);

            }
        }
    }
}
