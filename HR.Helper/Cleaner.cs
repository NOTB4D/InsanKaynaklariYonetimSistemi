using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.Helper
{
    public class Cleaner
    {
        public void ClearAll(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)//ClearAll(c); şeklinde de kullanılabilir.
                {
                    ClearAll(c);
                }
            }
        }
    }
}
