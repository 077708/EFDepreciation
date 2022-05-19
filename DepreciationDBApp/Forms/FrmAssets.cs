using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms.Forms
{
    public partial class FrmAssets : Form
    {
        private IAssetService assetService;
        private IEmployeeService employeeService;

        public FrmAssets(IAssetService assetService, IEmployeeService employeeService)
        {
            this.assetService = assetService;
            this.employeeService = employeeService;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Asset asset = new Asset()
                {
                    Name = txtName.Texts,
                    Description = txtDescription.Texts,
                    Amount = decimal.Parse(txtAmount.Texts),
                    AmountResidual = decimal.Parse(txtAmountResidual.Texts),
                    Terms = int.Parse(txtTerms.Texts),
                    Code = txtCode.Texts,
                    Status = txtStatus.Texts,
                };

                assetService.Create(asset);
                ChargeDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChargeDat()
        {
            dgvEmployee.DataSource = assetService.GetAll();
        }
    }
}
