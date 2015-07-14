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

namespace BackLite.Client.BaseForms
{
    public partial class FormBaseJournal : Form
    {
        protected BackLiteEntities _dbContext = null;
        public FormBaseJournal()
        {
            _dbContext = new BackLiteEntities();
            InitializeComponent();
        }
    }
}
