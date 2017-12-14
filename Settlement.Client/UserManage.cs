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
            Sentence_From = "UserInfoSet AS t1";
        }

        protected override KeyValuePair<string, SqlParameter[]>? GetFilter()
        {
            return null;
        }
    }
}
