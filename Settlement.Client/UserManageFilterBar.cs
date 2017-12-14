using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snokye.VVM;
using System.Data.SqlClient;

namespace Settlement.Client
{
    public partial class UserManageFilterBar : FilterBar
    {
        public UserManageFilterBar()
        {
            InitializeComponent();
            Controls.Remove(Controls["pCheckFilter"]);
            foreach (Control c in Controls)
            {
                c.Top -= 31;
            }

            MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - 31);
            //MaximumSize = new Size(0, MinimumSize.Height);
        }

        protected override void BuildFilter()
        {
            txtDispName.Text = txtDispName.Text.Trim();
            if (txtDispName.Text.Length != 0)
            {
                FilterString = "DisplayName LIKE @p0";
                Parameters = new SqlParameter[] { new SqlParameter("@p0", '%' + txtDispName.Text + '%') };
            }
            else
            {
                FilterString = string.Empty;
                Parameters = null;
            }
        }
    }
}
