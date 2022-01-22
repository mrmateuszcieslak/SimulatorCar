
namespace Lab5
{
    partial class EditStreet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapDataSet = new Lab5.MapDataSet();
            this.streetsTableAdapter = new Lab5.MapDataSetTableAdapters.StreetsTableAdapter();
            this.ModifyStreet = new System.Windows.Forms.Button();
            this.pointsStreetTableAdapter = new Lab5.MapDataSetTableAdapters.PointsStreetTableAdapter();
            this.pointsStreetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsStreetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.streetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.mapDataSet;
            this.streetsBindingSource.CurrentChanged += new System.EventHandler(this.streetsBindingSource_CurrentChanged);
            // 
            // mapDataSet
            // 
            this.mapDataSet.DataSetName = "MapDataSet";
            this.mapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyStreet
            // 
            this.ModifyStreet.BackColor = System.Drawing.Color.YellowGreen;
            this.ModifyStreet.Location = new System.Drawing.Point(314, 406);
            this.ModifyStreet.Name = "ModifyStreet";
            this.ModifyStreet.Size = new System.Drawing.Size(136, 32);
            this.ModifyStreet.TabIndex = 1;
            this.ModifyStreet.Text = "Save Changes";
            this.ModifyStreet.UseVisualStyleBackColor = false;
            this.ModifyStreet.Click += new System.EventHandler(this.ModifyStreet_Click);
            // 
            // pointsStreetTableAdapter
            // 
            this.pointsStreetTableAdapter.ClearBeforeFill = true;
            // 
            // pointsStreetBindingSource
            // 
            this.pointsStreetBindingSource.DataMember = "PointsStreet";
            this.pointsStreetBindingSource.DataSource = this.mapDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pointsStreetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(362, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(802, 390);
            this.dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.Width = 125;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.Width = 125;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "IdStreet";
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "IdStreet";
            this.idStreetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.Width = 125;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(519, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 32);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ModifyStreet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditStreet";
            this.Text = "EditStreet";
            this.Load += new System.EventHandler(this.EditStreet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsStreetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MapDataSet mapDataSet;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private MapDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ModifyStreet;
        private MapDataSetTableAdapters.PointsStreetTableAdapter pointsStreetTableAdapter;
        private System.Windows.Forms.BindingSource pointsStreetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exit;
    }
}