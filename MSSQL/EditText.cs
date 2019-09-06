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
    public partial class EditText : Form
    {
        public EditText()
        {
            InitializeComponent();
        }

        private void EditText_Load(object sender, EventArgs e)
        {
//            for (int i = 0; i < Program.SQLDic.Count; i++)
//            {
//                tbValue.Text = Program.SQLDic.Values.ToList()[Program.index];
//            }
            tbValue.Text = Program.SQLDic.Values.ToList()[Program.index];
            tbKey.Text = Program.SQLDic.Keys.ToList()[Program.index];

        }

        private void btnValueOk_Click(object sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = MjSql.createSqlConnection();
                cmd.CommandText =
                    $"Update SQLQuery set  sqlValue ='{tbValue.Text}' where sqlKey ='{Program.sqlKey}'";
                cmd.ExecuteNonQuery();
            }
        }

        private void btnKeyOk_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = MjSql.createSqlConnection();
                cmd.CommandText =
                    $"Update SQLQuery set  sqlKey ='{tbKey.Text}' where sqlKey ='{Program.sqlKey}'";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
