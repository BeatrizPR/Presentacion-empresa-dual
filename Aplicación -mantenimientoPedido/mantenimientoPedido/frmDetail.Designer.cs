namespace mantenimientoPedido
{
    partial class frmDetail
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
            this.groupBCustomer = new System.Windows.Forms.GroupBox();
            this.textBTerritory = new System.Windows.Forms.TextBox();
            this.textBStore = new System.Windows.Forms.TextBox();
            this.textBName = new System.Windows.Forms.TextBox();
            this.lblTerritory = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBOrder = new System.Windows.Forms.GroupBox();
            this.textBoxShipping = new System.Windows.Forms.TextBox();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.textBOrderDate = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.groupBDetail = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.groupBCustomer.SuspendLayout();
            this.groupBOrder.SuspendLayout();
            this.groupBDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBCustomer
            // 
            this.groupBCustomer.Controls.Add(this.textBTerritory);
            this.groupBCustomer.Controls.Add(this.textBStore);
            this.groupBCustomer.Controls.Add(this.textBName);
            this.groupBCustomer.Controls.Add(this.lblTerritory);
            this.groupBCustomer.Controls.Add(this.lblTienda);
            this.groupBCustomer.Controls.Add(this.lblName);
            this.groupBCustomer.Location = new System.Drawing.Point(12, 22);
            this.groupBCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBCustomer.Name = "groupBCustomer";
            this.groupBCustomer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBCustomer.Size = new System.Drawing.Size(869, 99);
            this.groupBCustomer.TabIndex = 0;
            this.groupBCustomer.TabStop = false;
            this.groupBCustomer.Text = "Información del cliente";
            this.groupBCustomer.Enter += new System.EventHandler(this.groupBCustomer_Enter);
            // 
            // textBTerritory
            // 
            this.textBTerritory.Location = new System.Drawing.Point(638, 41);
            this.textBTerritory.Name = "textBTerritory";
            this.textBTerritory.Size = new System.Drawing.Size(184, 20);
            this.textBTerritory.TabIndex = 5;
            this.textBTerritory.TextChanged += new System.EventHandler(this.textBTerritory_TextChanged);
            // 
            // textBStore
            // 
            this.textBStore.Location = new System.Drawing.Point(346, 41);
            this.textBStore.Name = "textBStore";
            this.textBStore.Size = new System.Drawing.Size(203, 20);
            this.textBStore.TabIndex = 4;
            this.textBStore.TextChanged += new System.EventHandler(this.textBStore_TextChanged);
            // 
            // textBName
            // 
            this.textBName.Location = new System.Drawing.Point(76, 41);
            this.textBName.Name = "textBName";
            this.textBName.Size = new System.Drawing.Size(169, 20);
            this.textBName.TabIndex = 3;
            this.textBName.TextChanged += new System.EventHandler(this.textBName_TextChanged);
            // 
            // lblTerritory
            // 
            this.lblTerritory.AutoSize = true;
            this.lblTerritory.Location = new System.Drawing.Point(575, 44);
            this.lblTerritory.Name = "lblTerritory";
            this.lblTerritory.Size = new System.Drawing.Size(48, 13);
            this.lblTerritory.TabIndex = 2;
            this.lblTerritory.Text = "Territorio";
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Location = new System.Drawing.Point(290, 44);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(40, 13);
            this.lblTienda.TabIndex = 1;
            this.lblTienda.Text = "Tienda";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // groupBOrder
            // 
            this.groupBOrder.Controls.Add(this.textBoxShipping);
            this.groupBOrder.Controls.Add(this.textBoxOrder);
            this.groupBOrder.Controls.Add(this.textBOrderDate);
            this.groupBOrder.Controls.Add(this.lblShipping);
            this.groupBOrder.Controls.Add(this.lblOrder);
            this.groupBOrder.Controls.Add(this.lblOrderDate);
            this.groupBOrder.Location = new System.Drawing.Point(12, 141);
            this.groupBOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBOrder.Name = "groupBOrder";
            this.groupBOrder.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBOrder.Size = new System.Drawing.Size(869, 118);
            this.groupBOrder.TabIndex = 1;
            this.groupBOrder.TabStop = false;
            this.groupBOrder.Text = "Información del pedido";
            this.groupBOrder.Enter += new System.EventHandler(this.groupBOrder_Enter);
            // 
            // textBoxShipping
            // 
            this.textBoxShipping.Location = new System.Drawing.Point(638, 50);
            this.textBoxShipping.Name = "textBoxShipping";
            this.textBoxShipping.Size = new System.Drawing.Size(184, 20);
            this.textBoxShipping.TabIndex = 5;
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(346, 50);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(123, 20);
            this.textBoxOrder.TabIndex = 4;
            // 
            // textBOrderDate
            // 
            this.textBOrderDate.Location = new System.Drawing.Point(95, 50);
            this.textBOrderDate.Name = "textBOrderDate";
            this.textBOrderDate.Size = new System.Drawing.Size(124, 20);
            this.textBOrderDate.TabIndex = 3;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(534, 53);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(89, 13);
            this.lblShipping.TabIndex = 2;
            this.lblShipping.Text = "Método de envío";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(276, 53);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(54, 13);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Nº pedido";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(17, 53);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(72, 13);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Fecha pedido";
            // 
            // groupBDetail
            // 
            this.groupBDetail.Controls.Add(this.btnReturn);
            this.groupBDetail.Controls.Add(this.btnDelete);
            this.groupBDetail.Controls.Add(this.btnModify);
            this.groupBDetail.Controls.Add(this.dataGridViewDetail);
            this.groupBDetail.Location = new System.Drawing.Point(12, 280);
            this.groupBDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBDetail.Name = "groupBDetail";
            this.groupBDetail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBDetail.Size = new System.Drawing.Size(869, 359);
            this.groupBDetail.TabIndex = 2;
            this.groupBDetail.TabStop = false;
            this.groupBDetail.Text = "Detalle del pedido";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(772, 330);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Volver";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(20, 330);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Location = new System.Drawing.Point(20, 33);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.Size = new System.Drawing.Size(827, 276);
            this.dataGridViewDetail.TabIndex = 0;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 651);
            this.Controls.Add(this.groupBDetail);
            this.Controls.Add(this.groupBOrder);
            this.Controls.Add(this.groupBCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDetail";
            this.Text = "Detalle del pedido";
            this.groupBCustomer.ResumeLayout(false);
            this.groupBCustomer.PerformLayout();
            this.groupBOrder.ResumeLayout(false);
            this.groupBOrder.PerformLayout();
            this.groupBDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBCustomer;
        private System.Windows.Forms.GroupBox groupBOrder;
        private System.Windows.Forms.GroupBox groupBDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBTerritory;
        private System.Windows.Forms.TextBox textBStore;
        private System.Windows.Forms.TextBox textBName;
        private System.Windows.Forms.Label lblTerritory;
        private System.Windows.Forms.TextBox textBoxShipping;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.TextBox textBOrderDate;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblOrderDate;
    }
}