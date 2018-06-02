using System;

namespace mantenimientoPedido
{
    partial class frmMain
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.texBTerritory = new System.Windows.Forms.TextBox();
            this.textBoxStore = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblTerritory = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechInicio = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.gridVSearch = new System.Windows.Forms.DataGridView();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.texBTerritory);
            this.groupBoxInfo.Controls.Add(this.textBoxStore);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.lblTerritory);
            this.groupBoxInfo.Controls.Add(this.lblTienda);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 25);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(844, 72);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Información del cliente";
            // 
            // texBTerritory
            // 
            this.texBTerritory.Location = new System.Drawing.Point(659, 30);
            this.texBTerritory.Name = "texBTerritory";
            this.texBTerritory.Size = new System.Drawing.Size(100, 20);
            this.texBTerritory.TabIndex = 5;
            this.texBTerritory.TextChanged += new System.EventHandler(this.texBTerritory_TextChanged);
            // 
            // textBoxStore
            // 
            this.textBoxStore.Location = new System.Drawing.Point(376, 30);
            this.textBoxStore.Name = "textBoxStore";
            this.textBoxStore.Size = new System.Drawing.Size(100, 20);
            this.textBoxStore.TabIndex = 4;
            this.textBoxStore.TextChanged += new System.EventHandler(this.textBoxStore_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // lblTerritory
            // 
            this.lblTerritory.AutoSize = true;
            this.lblTerritory.Location = new System.Drawing.Point(583, 33);
            this.lblTerritory.Name = "lblTerritory";
            this.lblTerritory.Size = new System.Drawing.Size(48, 13);
            this.lblTerritory.TabIndex = 2;
            this.lblTerritory.Text = "Territorio";
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Location = new System.Drawing.Point(304, 33);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(40, 13);
            this.lblTienda.TabIndex = 1;
            this.lblTienda.Text = "Tienda";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker2);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker1);
            this.groupBoxSearch.Controls.Add(this.lblFechaFin);
            this.groupBoxSearch.Controls.Add(this.lblFechInicio);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 129);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(844, 93);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Criterios de búsqueda";
            this.groupBoxSearch.Enter += new System.EventHandler(this.groupBoxSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(674, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(507, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(375, 43);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(101, 13);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha pedido hasta";
            // 
            // lblFechInicio
            // 
            this.lblFechInicio.AutoSize = true;
            this.lblFechInicio.Location = new System.Drawing.Point(37, 43);
            this.lblFechInicio.Name = "lblFechInicio";
            this.lblFechInicio.Size = new System.Drawing.Size(104, 13);
            this.lblFechInicio.TabIndex = 6;
            this.lblFechInicio.Text = "Fecha pedido desde";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.btnDelete);
            this.groupBoxResult.Controls.Add(this.btnModify);
            this.groupBoxResult.Controls.Add(this.gridVSearch);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 249);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(844, 366);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Resultado";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(129, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(24, 326);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // gridVSearch
            // 
            this.gridVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVSearch.Location = new System.Drawing.Point(24, 39);
            this.gridVSearch.Name = "gridVSearch";
            this.gridVSearch.Size = new System.Drawing.Size(795, 272);
            this.gridVSearch.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 627);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Mantenimiento de pedidos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVSearch)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox texBTerritory;
        private System.Windows.Forms.TextBox textBoxStore;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblTerritory;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView gridVSearch;
    }
}