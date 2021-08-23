namespace cinima_project
{
    partial class form_update_price
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
            this.btnupdateprice = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblidmoviedelete = new System.Windows.Forms.Label();
            this.txtidtodelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnupdateprice
            // 
            this.btnupdateprice.BackColor = System.Drawing.Color.Crimson;
            this.btnupdateprice.ForeColor = System.Drawing.Color.White;
            this.btnupdateprice.Location = new System.Drawing.Point(262, 142);
            this.btnupdateprice.Name = "btnupdateprice";
            this.btnupdateprice.Size = new System.Drawing.Size(193, 44);
            this.btnupdateprice.TabIndex = 12;
            this.btnupdateprice.Text = "Update Price";
            this.btnupdateprice.UseVisualStyleBackColor = false;
            this.btnupdateprice.Click += new System.EventHandler(this.btnupdateprice_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(284, 61);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(161, 22);
            this.txtprice.TabIndex = 13;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(170, 61);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(104, 17);
            this.lblUpdate.TabIndex = 14;
            this.lblUpdate.Text = "the new price >";
            // 
            // lblidmoviedelete
            // 
            this.lblidmoviedelete.AutoSize = true;
            this.lblidmoviedelete.Location = new System.Drawing.Point(12, 106);
            this.lblidmoviedelete.Name = "lblidmoviedelete";
            this.lblidmoviedelete.Size = new System.Drawing.Size(262, 17);
            this.lblidmoviedelete.TabIndex = 15;
            this.lblidmoviedelete.Text = "the ID of the movie you want to update >";
            // 
            // txtidtodelete
            // 
            this.txtidtodelete.Location = new System.Drawing.Point(284, 101);
            this.txtidtodelete.Name = "txtidtodelete";
            this.txtidtodelete.Size = new System.Drawing.Size(161, 22);
            this.txtidtodelete.TabIndex = 16;
            // 
            // form_update_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 201);
            this.Controls.Add(this.txtidtodelete);
            this.Controls.Add(this.lblidmoviedelete);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.btnupdateprice);
            this.Name = "form_update_price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_update_price";
            this.Load += new System.EventHandler(this.form_update_price_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdateprice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblidmoviedelete;
        private System.Windows.Forms.TextBox txtidtodelete;
    }
}