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
    public partial class NewSQL : Form
    {
        private bool bCheck = false;
        private List<string> sqlKeyList = new List<string>();
        private List<string> sqlValueList = new List<string>();
        public NewSQL()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbKey.Text == string.Empty || tbValue.Text == string.Empty)
            {
                MessageBox.Show("빈 값이 있습니다.");
                return;
            }
            //체크박스가 활성화 되어야만 진행가능
            if (bCheck == true)
            {
                MessageBox.Show("Key 값이 중복됩니다.");
                return;
            }
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = MjSql.createSqlConnection();
                cmd.CommandText =
                    $"insert into SQLQuery values((select count(sequence) from SQLQuery)+1 ,'{tbKey.Text}','{tbValue.Text}')";
                cmd.ExecuteNonQuery();
            }
        }

        private void btnCheckText_Click(object sender, EventArgs e)
        {
            bCheck = false;
            //keylist에서 같은키가 있는지 검사
            MjSql.initQuery(sqlKeyList, sqlValueList);
            for (int j = 0; j < sqlKeyList.Count; j++)
            {
                if (tbKey.Text.Trim() == sqlKeyList[j].Trim())
                {
                    bCheck = true;
                }
            }

            if (bCheck == false)
            {
                cbCheck.Checked = true;
            }
        }
    }
}
