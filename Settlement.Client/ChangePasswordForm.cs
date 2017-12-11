using Snokye.VVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Settlement.Client
{
    public partial class ChangePasswordForm : AutoEditForm
    {
        public ChangePasswordForm(VMChangePwd viewModel, string title) : base(viewModel, "修改密码") { }
    }
}
