namespace WF_Test
{
    partial class UseItem
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
            this.Inventory_Box = new System.Windows.Forms.ListBox();
            this.btn_Inven_Use = new System.Windows.Forms.Button();
            this.btn_Inven_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inventory_Box
            // 
            this.Inventory_Box.FormattingEnabled = true;
            this.Inventory_Box.ItemHeight = 12;
            this.Inventory_Box.Location = new System.Drawing.Point(19, 24);
            this.Inventory_Box.Name = "Inventory_Box";
            this.Inventory_Box.Size = new System.Drawing.Size(196, 340);
            this.Inventory_Box.TabIndex = 0;
            this.Inventory_Box.SelectedIndexChanged += new System.EventHandler(this.Inventory_Box_SelectedIndexChanged);
            // 
            // btn_Inven_Use
            // 
            this.btn_Inven_Use.Location = new System.Drawing.Point(19, 388);
            this.btn_Inven_Use.Name = "btn_Inven_Use";
            this.btn_Inven_Use.Size = new System.Drawing.Size(96, 40);
            this.btn_Inven_Use.TabIndex = 1;
            this.btn_Inven_Use.Text = "사용";
            this.btn_Inven_Use.UseVisualStyleBackColor = true;
            this.btn_Inven_Use.Click += new System.EventHandler(this.btn_Inven_Use_Click);
            // 
            // btn_Inven_Close
            // 
            this.btn_Inven_Close.Location = new System.Drawing.Point(119, 388);
            this.btn_Inven_Close.Name = "btn_Inven_Close";
            this.btn_Inven_Close.Size = new System.Drawing.Size(96, 40);
            this.btn_Inven_Close.TabIndex = 1;
            this.btn_Inven_Close.Text = "닫기";
            this.btn_Inven_Close.UseVisualStyleBackColor = true;
            this.btn_Inven_Close.Click += new System.EventHandler(this.btn_Inven_Close_Click);
            // 
            // UseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 450);
            this.Controls.Add(this.btn_Inven_Close);
            this.Controls.Add(this.btn_Inven_Use);
            this.Controls.Add(this.Inventory_Box);
            this.Name = "UseItem";
            this.Text = "Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Inventory_Box;
        private System.Windows.Forms.Button btn_Inven_Use;
        private System.Windows.Forms.Button btn_Inven_Close;
    }
}