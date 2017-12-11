using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Settlement.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //A a = new A();

            //Func<A,string> func = (aa) => a.Name;
            //func.Method.GetParameters(0)
            //MessageBox.Show(func.Target.GetType().FullName+"\r\n"+typeof(A).FullName);
            //System.Diagnostics.Process.GetCurrentProcess().Kill();

            Application.Run(new ClientForm());
        }

        class A
        {
            public string Name { get; set; }
        }
    }
}
