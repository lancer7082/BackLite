using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackLite.Client
{
    public partial class BaseEditControl : UserControl
    {
        public event EventHandler OKButtonClicked = null;
        public event EventHandler CancelButtonClicked = null;

        public BaseEditControl()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OKButtonClicked.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelButtonClicked.Invoke(sender, e);
        }
    }
}
