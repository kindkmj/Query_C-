using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL
{
    //Version 1.0
    public static class Program
    {
        public static Dictionary<string,string> SQLDic = new Dictionary<string, string>();
        public static int index = 0;
        public static string sqlKey = "";
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
