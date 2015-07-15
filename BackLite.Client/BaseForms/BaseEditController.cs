using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackLite.Data.Models;

namespace BackLite.Client
{
    class BaseEditController<T>
    {
        private T _entity;

        protected BaseEditControl Control { get; set; }

        private BackLiteEntities _dbContext = null;

        public BaseEditController()
        {
            InitControl();
            _dbContext = new BackLiteEntities();
        }

        public BaseEditController(BackLiteEntities context)
        {
            InitControl();
            _dbContext = context;
        }

        protected virtual void InitControl()
        {
            Control = new BaseEditControl();
        }

        public virtual void View(T entity)
        {
            if (Control == null)
                throw new ArgumentNullException("Не задана форма редактирования");

            _entity = entity;

            var form = new Form();
            form.Width = Control.Width;
            form.Height = Control.Height;
            Control.Dock = DockStyle.Fill;
            Control.OKButtonClicked += _control_OKButtonClicked;
            Control.CancelButtonClicked += _control_CancelButtonClicked;
            form.Controls.Add(Control);
            form.Show();
        }

        void _control_CancelButtonClicked(object sender, EventArgs e)
        {
            var form = ((Control)sender).FindForm();
            if (form != null)
            {
                form.Close();
                form.Dispose();
            }
        }

        protected virtual bool Validate()
        {
            return true;
        }

        protected virtual void Save()
        {
        }

        private void _control_OKButtonClicked(object sender, EventArgs e)
        {
            var form = ((Control)sender).FindForm();
            if (form != null)
            {
                try
                {
                    if (Validate()) Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                form.Close();
                form.Dispose();
            }
        }
    }
}
