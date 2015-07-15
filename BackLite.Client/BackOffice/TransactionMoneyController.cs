using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackLite.Data.Models;

namespace BackLite.Client
{
    class TransactionMoneyController : BaseEditController<TransactionMoney>
    {
        protected override void InitControl()
        {
            Control = new TransactionMoneyControl();
        }
    }
}
