using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL
{
    public partial class Form1 : Form
    {
        private bool bsize = true;
            List<string> sqlKeyList = new List<string>();
            List<string> sqlValueList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(622, 530);
            MjSql.initQuery(sqlKeyList, sqlValueList);
            foreach (var sqllist in Program.SQLDic)
            {
                //키 값만 보여주고 키 값을 선택하면 해당 키에대한 쿼리문을 보여주는 형식으로 변경하기.
                lblSqlKeyList.Items.Add($"키 : {sqllist.Key} ");
//                lblSqlValueList.Items.Add($" 쿼리문 : {sqllist.Value}");
                if (lblSqlValueList.Items.Count == 0)
                {
                    lblSqlValueList.Items.Add("아직 값이 없습니다.");
                }
            }
            //            for (int i = 0; i < Program.SQLDic.Count; i++)
            //            {
            //                lblSqlList.Items.Add(Program.SQLDic.Keys.ToList()[i]); 
            //            }
            lblSqlValueList.SelectedIndex = lblSqlValueList.Items.Count - 1;
//테이블 모두 검색후 리스트박스에 추가
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //테이블 모두 검색후 리스트박스에 추가 같은 기능
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Program.sqlKey = sqlKeyList[lblSqlValueList.SelectedIndex];
            Program.index = lblSqlValueList.SelectedIndex;
            EditText ed  =new EditText();
            ed.ShowDialog();
        }

        private void lblSqlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.index = lblSqlValueList.SelectedIndex;
            foreach (var sqllist in Program.SQLDic)
            {
                if (sqllist.Key == lblSqlKeyList.SelectedIndex.ToString())
                {
                lblSqlValueList.Items.Add($"값 : {sqllist.Value} ");
                }
                if (lblSqlValueList.Items.Count == 0)
                {
                    lblSqlValueList.Items.Add("아직 값이 없습니다.");
                }
            }
        }

        private void btnRefrush_Click(object sender, EventArgs e)
        {
            lblSqlValueList.Items.Clear();
            sqlKeyList.Clear();
            sqlValueList.Clear();
            MjSql.initQuery(sqlKeyList,sqlValueList);
            foreach (var sqllist in Program.SQLDic)
            {
                lblSqlKeyList.Items.Add($"키 : {sqllist.Key} ");
                if (lblSqlValueList.Items.Count == 0)
                {
                    lblSqlValueList.Items.Add("아직 값이 없습니다.");
                }
            }
            lblSqlValueList.SelectedIndex = lblSqlValueList.Items.Count - 1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NewSQL ns = new NewSQL();
            ns.ShowDialog();
        }

        private void btnExpansion_Click(object sender, EventArgs e)
        {
            if (bsize == true)
            {
                this.Size = new Size(776, 530);
                bsize = false;
                btnExpansion.Text = "<";
                btnExpansion.Location = new Point(723, 4);
            }

            else if (bsize == false)
            {
                this.Size = new Size(622, 530);
                bsize = true;
                btnExpansion.Text = ">";
                btnExpansion.Location =new Point(576, 10);
            }
        }

        private void lblSqlKeyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.index = lblSqlKeyList.SelectedIndex;
            lblSqlValueList.Items.Clear();
            lblSqlValueList.Items.Add($"값 : {Program.SQLDic[Program.SQLDic.Keys.ToList()[Program.index]]} ");
        }
    }
}
