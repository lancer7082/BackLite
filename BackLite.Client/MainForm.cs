﻿using System;
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
    public partial class MainForm : Form
    {
        protected BackLiteEntities _dbContext = new BackLiteEntities();
   
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                bsAccounts.DataSource = _dbContext.Accounts.ToList();
                bsPlatformsTree.DataSource = _dbContext.Platforms_Tree().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var account = (Account)(dgMain.Rows[e.RowIndex].DataBoundItem);
                if (account != null)
                {
                    new AccountView().Show(account);
                }
            }
        }

        private void treePlatforms_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var p = (Platforms_Tree_Result)treePlatforms.GetDataRecordByNode(e.Node);
            if (p == null) return;

            /*
            var source = _dbContext.Accounts.AsQueryable();
            if (p.PlatformId > 0) source = source.Where(x => x.PlatformId == p.PlatformId);
            else if (p.PlatformGroupId > 0) source = source.Where(x => x.PlatformGroupId == p.PlatformGroupId);
            */

            //bsAccounts.DataSource
        }
    }
}
