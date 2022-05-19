using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms
{
    public partial class Form1 : Form
    {
        private IAssetService assetService;
        private IEmployeeService employeeService;

        public Form1(IAssetService assetService, IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            this.assetService = assetService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvEmployee.DataSource = employeeService.GetAll();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    Names = txtName.Texts,
                    Lastnames = txtLastNames.Texts,
                    Address = txtAddress.Texts,
                    Email = txtEmail.Texts,
                    Dni = txtDni.Texts,
                    Phone = txtPhone.Texts,
                    Status = txtStatus.Texts,
                };

                employeeService.Create(employee);
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            FrmAssets frmHistory = new FrmAssets(this.assetService, this.employeeService);
            frmHistory.ShowDialog();
        }
    }
}
