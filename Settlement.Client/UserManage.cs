using Settlement.Model;
using Snokye.Utility;
using Snokye.VVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Settlement.Client
{
    public partial class UserManage : DataList
    {
        public UserManage()
        {
            InitializeComponent();

            using (SettlementContainer c = new SettlementContainer())
                database = new SqlDatabase("data source=.;initial catalog=SalesmenSettlementDev;persist security info=True;user id=sa;password=123456;MultipleActiveResultSets=True;");

            Sentence_From = "UserInfoSet AS t1";
            userManageFilterBar1.Filtering += UserManageFilterBar1_Filtering;
        }

        private void UserManageFilterBar1_Filtering(string where, SqlParameter[] param)
        {
            //Query(where, param);
        }
    }
}
