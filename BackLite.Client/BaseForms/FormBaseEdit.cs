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
    public partial class FormBaseEdit<T> : Form
    {
        private T _entity;
        protected BackLiteEntities _dbContext = null;

        public FormBaseEdit()
        {
            _dbContext = new BackLiteEntities();
            InitializeComponent();
        }

        protected virtual void InitDataSource(T entity)
        {
            _entity = entity;
            bsMain.DataSource = _entity;
        }

        public virtual DialogResult ShowModal(T entity)
        {
            InitDataSource(entity);
            return ShowDialog();
        }
    }
}
