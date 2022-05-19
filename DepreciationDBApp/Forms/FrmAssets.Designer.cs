namespace DepreciationDBApp.Forms.Forms
{
    partial class FrmAssets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCode = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAmountResidual = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTerms = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.dgvEmployee);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 438);
            this.panel2.TabIndex = 3;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvEmployee.Location = new System.Drawing.Point(42, 82);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.RowTemplate.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.Size = new System.Drawing.Size(528, 258);
            this.dgvEmployee.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.panel3.Location = new System.Drawing.Point(596, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 407);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.txtAmountResidual);
            this.panel1.Controls.Add(this.txtTerms);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 438);
            this.panel1.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtStatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStatus.BorderRadius = 0;
            this.txtStatus.BorderSize = 2;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.Location = new System.Drawing.Point(20, 265);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStatus.PasswordChar = false;
            this.txtStatus.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStatus.PlaceholderText = "Status";
            this.txtStatus.Size = new System.Drawing.Size(171, 31);
            this.txtStatus.TabIndex = 8;
            this.txtStatus.Texts = "";
            this.txtStatus.UnderlinedStyle = true;
            this.txtStatus.UseWaitCursor = true;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCode.BorderRadius = 0;
            this.txtCode.BorderSize = 2;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Location = new System.Drawing.Point(20, 226);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCode.PasswordChar = false;
            this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceholderText = "Code";
            this.txtCode.Size = new System.Drawing.Size(171, 31);
            this.txtCode.TabIndex = 7;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = true;
            this.txtCode.UseWaitCursor = true;
            // 
            // txtAmountResidual
            // 
            this.txtAmountResidual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtAmountResidual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtAmountResidual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAmountResidual.BorderRadius = 0;
            this.txtAmountResidual.BorderSize = 2;
            this.txtAmountResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountResidual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountResidual.Location = new System.Drawing.Point(20, 148);
            this.txtAmountResidual.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountResidual.Multiline = false;
            this.txtAmountResidual.Name = "txtAmountResidual";
            this.txtAmountResidual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAmountResidual.PasswordChar = false;
            this.txtAmountResidual.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmountResidual.PlaceholderText = "AmountResidual";
            this.txtAmountResidual.Size = new System.Drawing.Size(171, 31);
            this.txtAmountResidual.TabIndex = 6;
            this.txtAmountResidual.Texts = "";
            this.txtAmountResidual.UnderlinedStyle = true;
            // 
            // txtTerms
            // 
            this.txtTerms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtTerms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtTerms.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTerms.BorderRadius = 0;
            this.txtTerms.BorderSize = 2;
            this.txtTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTerms.Location = new System.Drawing.Point(20, 187);
            this.txtTerms.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerms.Multiline = false;
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTerms.PasswordChar = false;
            this.txtTerms.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTerms.PlaceholderText = "Terms";
            this.txtTerms.Size = new System.Drawing.Size(171, 31);
            this.txtTerms.TabIndex = 5;
            this.txtTerms.Texts = "";
            this.txtTerms.UnderlinedStyle = true;
            this.txtTerms.UseWaitCursor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtAmount.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAmount.BorderRadius = 0;
            this.txtAmount.BorderSize = 2;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.Location = new System.Drawing.Point(20, 109);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.Size = new System.Drawing.Size(171, 31);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 0;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(20, 70);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "Descritption";
            this.txtDescription.Size = new System.Drawing.Size(171, 31);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(20, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(171, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(33, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAssets";
            this.Text = "FrmAssets";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJTextBox txtStatus;
        private RJCodeAdvance.RJControls.RJTextBox txtCode;
        private RJCodeAdvance.RJControls.RJTextBox txtAmountResidual;
        private RJCodeAdvance.RJControls.RJTextBox txtTerms;
        private RJCodeAdvance.RJControls.RJTextBox txtAmount;
        private RJCodeAdvance.RJControls.RJTextBox txtDescription;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
    }
}