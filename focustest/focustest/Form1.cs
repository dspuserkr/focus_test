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
        DataSet DSetRegistered;
        DataTable DtRegList;
        DataTable DtRegStock;
        string str등록목록;
        int index등록목록;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSetRegistered = CreateDataset();
            CBoxFocusList.DataSource = DtRegList.DefaultView;
            CBoxFocusList.DisplayMember = "DtRegName";
            index등록목록 = CBoxFocusList.SelectedIndex;
            str등록목록 = CBoxFocusList.Text;
            TBoxSelGroup.Text = CBoxFocusList.Text;
            //ds.WriteXml(@"RegisteredStocks.xml");
        }

        public DataSet CreateDataset()
        {
            DataSet _ds = new DataSet("DSetREG");
            //ds.Namespace = "StdNamespave";

            DtRegList = new DataTable("DtRegList");
            DtRegList.Columns.Add("DtRegName", typeof(string));

            DataRow newRow = DtRegList.NewRow();
            newRow["DtRegName"] = "자동매매종목";
            DtRegList.Rows.Add(newRow);

            newRow = DtRegList.NewRow();
            newRow["DtRegName"] = "관심종목1";
            DtRegList.Rows.Add(newRow);

            newRow = DtRegList.NewRow();
            newRow["DtRegName"] = "조건식추출";
            DtRegList.Rows.Add(newRow);

            _ds.Tables.Add(DtRegList);
            //_ds.AcceptChanges();
            return _ds;
        }
        //public void AddCBoxFocusList(ComboBox targetCBox, string _관심이름)
        //{
        //    targetCBox.Items.Add(_관심이름);
        //}
        //public void DeleteCBoxFocusList(ComboBox targetCBox, string _관심이름)
        //{
        //    targetCBox.Items.Remove(_관심이름);
        //}

        private void ClickCBoxFocusList(object sender, EventArgs e)
        {
            //CBoxFocusList.EndUpdate();
            //CBoxFocusList.Refresh();
            index등록목록 = CBoxFocusList.SelectedIndex;
            str등록목록 = CBoxFocusList.Text;
            TBoxSelGroup.Text = CBoxFocusList.Text;
        }
        private void ClickGroup(object sender, EventArgs e)
        {
            if (sender.Equals(buttNewGroup))
            {
                DataRow newRow = DtRegList.NewRow();
                
                newRow["DtRegName"] = TBoxSelGroup.Text;
                str등록목록 = TBoxSelGroup.Text;
                DtRegList.Rows.Add(newRow);
                index등록목록 = DtRegList.Rows.Count - 1;
                CBoxFocusList.SelectedIndex = index등록목록;
                str등록목록 = TBoxSelGroup.Text;
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
