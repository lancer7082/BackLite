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
    public partial class TransactionsView : FormBaseJournal
    {
        public TransactionsView()
        {
            InitializeComponent();
        }

        private void TransactionsView_Shown(object sender, EventArgs e)
        {
            bsMain.DataSource = _dbContext.Transactions.ToList();
        }

        private void mnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tran = new TransactionMoney();
            //new TransactionMoneyView().ShowModal(tran); 
            new TransactionMoneyController().View(tran);
        }
    }
}
