
namespace EntityDataModelDemo
{
    partial class Form1
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
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.txtEmpDesi = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.lblEmpDesi = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(395, 58);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(240, 150);
            this.dgvEmp.TabIndex = 43;
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Location = new System.Drawing.Point(560, 221);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(75, 35);
            this.btnShowRecord.TabIndex = 42;
            this.btnShowRecord.Text = "SHOW RECORD";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(469, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(373, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(273, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(289, 156);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(100, 20);
            this.txtEmpSal.TabIndex = 37;
            // 
            // txtEmpDesi
            // 
            this.txtEmpDesi.Location = new System.Drawing.Point(289, 124);
            this.txtEmpDesi.Name = "txtEmpDesi";
            this.txtEmpDesi.Size = new System.Drawing.Size(100, 20);
            this.txtEmpDesi.TabIndex = 36;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(289, 90);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 35;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(289, 58);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 34;
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Location = new System.Drawing.Point(165, 163);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(85, 13);
            this.lblEmpSalary.TabIndex = 33;
            this.lblEmpSalary.Text = "Employee Salary";
            // 
            // lblEmpDesi
            // 
            this.lblEmpDesi.AutoSize = true;
            this.lblEmpDesi.Location = new System.Drawing.Point(165, 124);
            this.lblEmpDesi.Name = "lblEmpDesi";
            this.lblEmpDesi.Size = new System.Drawing.Size(112, 13);
            this.lblEmpDesi.TabIndex = 32;
            this.lblEmpDesi.Text = "Employee Designation";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(165, 90);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(84, 13);
            this.lblEmpName.TabIndex = 31;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(165, 58);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(65, 13);
            this.lblEmpId.TabIndex = 30;
            this.lblEmpId.Text = "Employee Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnShowRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.txtEmpDesi);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblEmpSalary);
            this.Controls.Add(this.lblEmpDesi);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpId);
            this.Name = "Form1";
            this.Text = "ADO .Net Data Model";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.TextBox txtEmpDesi;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Label lblEmpDesi;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpId;
    }
}

