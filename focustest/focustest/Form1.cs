#define defREADXML

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace focustest
{
    public partial class Form1 : Form
    {
        public static DataSet DSetReg;
        public static DataTable DtRegList;
        public static DataTable DtRegStock;
        string str등록목록;
        int index등록목록;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSetReg = new DataSet("DSetREG");
#if (defREADXML)
            // Read XML from project folder
            DSetReg.ReadXml(@"..\..\..\RegisteredStocks.xml");
            DataTable DtRegList = DSetReg.Tables["DtRegNameList"];
            DataTable DtRegStock = DSetReg.Tables["DtRegStockList"];

#else
            DtRegList = CreateDtRegList();
            DtRegStock = CreateDtRegStock();
            DSetReg.Tables.Add(DtRegList);
            DSetReg.Tables.Add(DtRegStock);
#endif

            // DataRelation
            DataRelation RelDSetReg;
            RelDSetReg = new DataRelation("RelDSetReg",
                DSetReg.Tables["DtRegNameList"].Columns["DtRegName"],
                DSetReg.Tables["DtRegStockList"].Columns["DtRegName"], 
                false);
            DSetReg.Relations.Add(RelDSetReg);

            // Dataset binding
            CBoxFocusList.DataSource = DtRegList.DefaultView;
            CBoxFocusList.DisplayMember = "DtRegName";
            index등록목록 = CBoxFocusList.SelectedIndex;
            str등록목록 = CBoxFocusList.Text;
            TBoxSelGroup.Text = CBoxFocusList.Text;

            DgvRegStockList.AutoGenerateColumns = true;
            DSetReg.Tables["DtRegStockList"].DefaultView.RowFilter = "DtRegName = '" + TBoxSelGroup.Text + "'";
            DgvRegStockList.DataSource = DSetReg.Tables["DtRegStockList"].DefaultView;

            // Write XML  to project folder
            DSetReg.WriteXml(@"..\..\..\RegisteredStocks.xml");
        }
        public DataTable CreateDtRegList()
        {
            // parent table 등록종목목록
            DataTable _dt = new DataTable("DtRegNameList");
            _dt.Columns.Add("DtRegName", typeof(string));

            //_dt.Rows.Add(new object[] { "자동매매종목" });
            //_dt.Rows.Add(new object[] { "관심종목1" });
            //_dt.Rows.Add(new object[] { "조건식추출" });
            _dt.Rows.Add("자동매매종목");
            _dt.Rows.Add("관심종목1");
            _dt.Rows.Add("조건식추출");

            return _dt;
        }
        public DataTable CreateDtRegStock()
        {
            // child table 등록종목목록별 등록종목들
            DataTable _dt = new DataTable("DtRegStockList");
            _dt.Columns.Add("종목번호");
            _dt.Columns.Add("종목명");
            _dt.Columns.Add("DtRegName");

            _dt.Rows.Add(new object[] { "000001", "현대건설1", "자동매매종목" });
            _dt.Rows.Add(new object[] { "000002", "현대건설2", "자동매매종목" });
            _dt.Rows.Add(new object[] { "000003", "현대건설3", "자동매매종목" });
            _dt.Rows.Add(new object[] { "000004", "현대건설4", "자동매매종목" });
            _dt.Rows.Add(new object[] { "000005", "현대건설5", "자동매매종목" });
            _dt.Rows.Add(new object[] { "000002", "현대건설2", "관심종목1" });
            _dt.Rows.Add(new object[] { "000003", "현대건설3", "관심종목1" });
            _dt.Rows.Add(new object[] { "000003", "현대건설3", "조건식추출" });
            _dt.Rows.Add(new object[] { "000004", "현대건설4", "조건식추출" });
            _dt.Rows.Add(new object[] { "000005", "현대건설5", "조건식추출" });

            return _dt;
        }
        private void ClickCBoxFocusList(object sender, EventArgs e)
        {
            //CBoxFocusList.EndUpdate();
            //CBoxFocusList.Refresh();
            index등록목록 = CBoxFocusList.SelectedIndex;
            str등록목록 = CBoxFocusList.Text;
            TBoxSelGroup.Text = CBoxFocusList.Text;

            // filtering Datagridview
            DSetReg.Tables["DtRegStockList"].DefaultView.RowFilter = "DtRegName = '" + TBoxSelGroup.Text + "'";

        }
        private void ClickGroup(object sender, EventArgs e)
        {
            if (sender.Equals(buttNewGroup))
            {
                // if 같은 이름이 없으면
                DataRow newRow = DtRegList.NewRow();
                
                newRow["DtRegName"] = TBoxSelGroup.Text;
                str등록목록 = TBoxSelGroup.Text;
                DtRegList.Rows.Add(newRow);
                index등록목록 = DtRegList.Rows.Count - 1;
                CBoxFocusList.SelectedIndex = index등록목록;
                str등록목록 = TBoxSelGroup.Text;
                // else 같은 이름이 있으면 스킵

            }
            else if (sender.Equals(buttDelGroup))
            {
                index등록목록 = CBoxFocusList.SelectedIndex;
                TBoxSelGroup.Text = CBoxFocusList.Text;
                str등록목록 = TBoxSelGroup.Text;
                DtRegList.Rows[index등록목록].Delete();
                index등록목록 = CBoxFocusList.SelectedIndex;
                str등록목록 = CBoxFocusList.Text;
                TBoxSelGroup.Text = CBoxFocusList.Text;
            }
        }
    }
}
