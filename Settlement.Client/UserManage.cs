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
using CD = Snokye.VVM.ColumnDefinition;

namespace Settlement.Client
{
    public partial class UserManage : DataList
    {
        public UserManage()
        {
            InitializeComponent();
            Title = "用户管理";
        }

        protected override KeyValuePair<string, SqlParameter[]>? GetFilter()
        {
            return null;
        }

        public override void BeginInit()
        {
            base.BeginInit();

            Sentence_From = "UserInfoSet AS t1";
            ColumnDefinitions.AddRange(new CD[]
            {
                new CD(typeof(DataGridViewTextBoxColumn),  "用户名", null, "t1.UserName",    "colUserName"),
                new CD(typeof(DataGridViewTextBoxColumn),  "姓名",   null, "t1.DisplayName", "colDisplayName"),
                new CD(typeof(DataGridViewCheckBoxColumn), "禁用",   null, "t1.Disabled",    "colDisabled", 20),
            });
        }

        public override void EndInit()
        {
            base.EndInit();
            _allGridView.ForEach(d => d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill);
        }
    }
}
