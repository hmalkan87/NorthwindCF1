namespace NorthwindCF.WinUI
{
    partial class frm_OrderList
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
            this.txt_SearchOrder = new System.Windows.Forms.TextBox();
            this.dgv_OrderList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SearchOrder
            // 
            this.txt_SearchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchOrder.Location = new System.Drawing.Point(688, 12);
            this.txt_SearchOrder.Name = "txt_SearchOrder";
            this.txt_SearchOrder.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchOrder.TabIndex = 0;
            this.txt_SearchOrder.TextChanged += new System.EventHandler(this.txt_SearchOrder_TextChanged);
            // 
            // dgv_OrderList
            // 
            this.dgv_OrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderList.Location = new System.Drawing.Point(12, 38);
            this.dgv_OrderList.Name = "dgv_OrderList";
            this.dgv_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderList.Size = new System.Drawing.Size(776, 400);
            this.dgv_OrderList.TabIndex = 1;
            // 
            // frm_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_OrderList);
            this.Controls.Add(this.txt_SearchOrder);
            this.Name = "frm_OrderList";
            this.Text = "frm_OrderList";
            this.Load += new System.EventHandler(this.frm_OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchOrder;
        private System.Windows.Forms.DataGridView dgv_OrderList;
    }
}