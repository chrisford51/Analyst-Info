namespace Analyst_Info
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hddb01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hddb01DataSet = new Analyst_Info.hddb01DataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staffInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoTableAdapter = new Analyst_Info.hddb01DataSetTableAdapters.StaffInfoTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.staffInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hddb01DataSet2 = new Analyst_Info.hddb01DataSet2();
            this.staffInfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.staffInfoTableAdapter1 = new Analyst_Info.hddb01DataSet2TableAdapters.StaffInfoTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.service1DataGridViewTextBoxColumn,
            this.service2DataGridViewTextBoxColumn,
            this.service3DataGridViewTextBoxColumn,
            this.service4DataGridViewTextBoxColumn,
            this.service5DataGridViewTextBoxColumn,
            this.service6DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffInfoBindingSource5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // staffInfoBindingSource1
            // 
            this.staffInfoBindingSource1.DataMember = "StaffInfo";
            this.staffInfoBindingSource1.DataSource = this.hddb01DataSetBindingSource;
            // 
            // hddb01DataSetBindingSource
            // 
            this.hddb01DataSetBindingSource.DataSource = this.hddb01DataSet;
            this.hddb01DataSetBindingSource.Position = 0;
            // 
            // hddb01DataSet
            // 
            this.hddb01DataSet.DataSetName = "hddb01DataSet";
            this.hddb01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // staffInfoBindingSource
            // 
            this.staffInfoBindingSource.DataMember = "StaffInfo";
            this.staffInfoBindingSource.DataSource = this.hddb01DataSetBindingSource;
            // 
            // staffInfoTableAdapter
            // 
            this.staffInfoTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(825, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // staffInfoBindingSource2
            // 
            this.staffInfoBindingSource2.DataMember = "StaffInfo";
            this.staffInfoBindingSource2.DataSource = this.hddb01DataSetBindingSource;
            // 
            // staffInfoBindingSource3
            // 
            this.staffInfoBindingSource3.DataMember = "StaffInfo";
            this.staffInfoBindingSource3.DataSource = this.hddb01DataSetBindingSource;
            // 
            // staffInfoBindingSource4
            // 
            this.staffInfoBindingSource4.DataMember = "StaffInfo";
            this.staffInfoBindingSource4.DataSource = this.hddb01DataSetBindingSource;
            // 
            // hddb01DataSet2
            // 
            this.hddb01DataSet2.DataSetName = "hddb01DataSet2";
            this.hddb01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffInfoBindingSource5
            // 
            this.staffInfoBindingSource5.DataMember = "StaffInfo";
            this.staffInfoBindingSource5.DataSource = this.hddb01DataSet2;
            // 
            // staffInfoTableAdapter1
            // 
            this.staffInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 95;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Width = 59;
            // 
            // service1DataGridViewTextBoxColumn
            // 
            this.service1DataGridViewTextBoxColumn.DataPropertyName = "Service 1";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.service1DataGridViewTextBoxColumn.HeaderText = "Service 1";
            this.service1DataGridViewTextBoxColumn.Name = "service1DataGridViewTextBoxColumn";
            // 
            // service2DataGridViewTextBoxColumn
            // 
            this.service2DataGridViewTextBoxColumn.DataPropertyName = "Service 2";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.service2DataGridViewTextBoxColumn.HeaderText = "Service 2";
            this.service2DataGridViewTextBoxColumn.Name = "service2DataGridViewTextBoxColumn";
            // 
            // service3DataGridViewTextBoxColumn
            // 
            this.service3DataGridViewTextBoxColumn.DataPropertyName = "Service 3";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.service3DataGridViewTextBoxColumn.HeaderText = "Service 3";
            this.service3DataGridViewTextBoxColumn.Name = "service3DataGridViewTextBoxColumn";
            // 
            // service4DataGridViewTextBoxColumn
            // 
            this.service4DataGridViewTextBoxColumn.DataPropertyName = "Service 4";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service4DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.service4DataGridViewTextBoxColumn.HeaderText = "Service 4";
            this.service4DataGridViewTextBoxColumn.Name = "service4DataGridViewTextBoxColumn";
            // 
            // service5DataGridViewTextBoxColumn
            // 
            this.service5DataGridViewTextBoxColumn.DataPropertyName = "Service 5";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service5DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.service5DataGridViewTextBoxColumn.HeaderText = "Service 5";
            this.service5DataGridViewTextBoxColumn.Name = "service5DataGridViewTextBoxColumn";
            // 
            // service6DataGridViewTextBoxColumn
            // 
            this.service6DataGridViewTextBoxColumn.DataPropertyName = "Service 6";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service6DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.service6DataGridViewTextBoxColumn.HeaderText = "Service 6";
            this.service6DataGridViewTextBoxColumn.Name = "service6DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 565);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hddb01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hddb01DataSetBindingSource;
        private hddb01DataSet hddb01DataSet;
        private System.Windows.Forms.BindingSource staffInfoBindingSource;
        private hddb01DataSetTableAdapters.StaffInfoTableAdapter staffInfoTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffInfoBindingSource1;
        private System.Windows.Forms.BindingSource staffInfoBindingSource2;
        private System.Windows.Forms.BindingSource staffInfoBindingSource3;
        private System.Windows.Forms.BindingSource staffInfoBindingSource4;
        private hddb01DataSet2 hddb01DataSet2;
        private System.Windows.Forms.BindingSource staffInfoBindingSource5;
        private hddb01DataSet2TableAdapters.StaffInfoTableAdapter staffInfoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service6DataGridViewTextBoxColumn;
    }
}

