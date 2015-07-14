using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackLite.Client.BaseForms;
using BackLite.Data.Models;

namespace BackLite.Client
{
    public partial class TransactionMoneyView : 
#if DEBUG
        TransactionMoneyView_Design        
#else
        FormBaseEdit<TransactionMoney>
#endif
    {
        public TransactionMoneyView()
        {
            InitializeComponent();
        }
    }

#if DEBUG
    public class TransactionMoneyView_Design : FormBaseEdit<TransactionMoney> { }
#endif
}

