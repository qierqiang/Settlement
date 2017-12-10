using Snokye.VVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settlement.Client
{
    public class VMChangePwd : ViewModelBase
    {
        public string OldPassword { get; set; }

        public string NewPasswrod { get; set; }

        public string RepPassword { get; set; }
    }
}
