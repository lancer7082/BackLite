using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackLite.Data.Models;

namespace BackLite.Client
{
    public partial class AccountView : Form
    {
        protected BackLiteEntities _dbContext = new BackLiteEntities();

        private Account _account = null;
        
        public AccountView()
        {
            InitializeComponent();
        }

        public void Show(object entity)
        {
            _account = (Account)entity;
            bsAccount.DataSource = _account;
            bsAccountCodes.DataSource = _account.AccountCodes.ToList();
            this.ShowDialog();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            //bsAccount.DataSource = _dbContext.Accounts.Where(x => x.AccountId == _account.AccountId);
        }
    }
}
