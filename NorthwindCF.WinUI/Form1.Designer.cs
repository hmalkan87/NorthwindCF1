namespace NorthwindCF.WinUI
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
            this.btn_GetCustomers = new System.Windows.Forms.Button();
            this.dgv_CustomersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_OrderList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GetCustomers
            // 
            this.btn_GetCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetCustomers.Location = new System.Drawing.Point(675, 12);
            this.btn_GetCustomers.Name = "btn_GetCustomers";
            this.btn_GetCustomers.Size = new System.Drawing.Size(113, 23);
            this.btn_GetCustomers.TabIndex = 0;
            this.btn_GetCustomers.Text = "Show Customers";
            this.btn_GetCustomers.UseVisualStyleBackColor = true;
            this.btn_GetCustomers.Click += new System.EventHandler(this.btn_GetCustomers_Click);
            // 
            // dgv_CustomersList
            // 
            this.dgv_CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_CustomersList.Location = new System.Drawing.Point(12, 41);
            this.dgv_CustomersList.Name = "dgv_CustomersList";
            this.dgv_CustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomersList.Size = new System.Drawing.Size(776, 397);
            this.dgv_CustomersList.TabIndex = 1;
            this.dgv_CustomersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CustomersList_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrdersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // showOrdersToolStripMenuItem
            // 
            this.showOrdersToolStripMenuItem.Name = "showOrdersToolStripMenuItem";
            this.showOrdersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showOrdersToolStripMenuItem.Text = "Show Orders";
            this.showOrdersToolStripMenuItem.Click += new System.EventHandler(this.showOrdersToolStripMenuItem_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(569, 12);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(100, 23);
            this.btn_AddCustomer.TabIndex = 2;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // btn_OrderList
            // 
            this.btn_OrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OrderList.Location = new System.Drawing.Point(488, 12);
            this.btn_OrderList.Name = "btn_OrderList";
            this.btn_OrderList.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderList.TabIndex = 3;
            this.btn_OrderList.Text = "Order List";
            this.btn_OrderList.UseVisualStyleBackColor = true;
            this.btn_OrderList.Click += new System.EventHandler(this.btn_OrderList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OrderList);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.dgv_CustomersList);
            this.Controls.Add(this.btn_GetCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetCustomers;
        private System.Windows.Forms.DataGridView dgv_CustomersList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showOrdersToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_OrderList;
    }
}

