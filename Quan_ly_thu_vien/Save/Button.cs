using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save
{
    public class Button
    {
        public static class ButtonServices
        {
            public static void CloseForm(Form form)
            {
                form.Close();
            }
        }
    }
}
