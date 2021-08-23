namespace cinima_project
{
    partial class formUpdatenumofseats
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
            this.txtidtodelete = new System.Windows.Forms.TextBox();
            this.lblidmoviedelete = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtnumofseats = new System.Windows.Forms.TextBox();
            this.btnupdatenumofseats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtidtodelete
            // 
            this.txtidtodelete.Location = new System.Drawing.Point(289, 79);
            this.txtidtodelete.Name = "txtidtodelete";
            this.txtidtodelete.Size = new System.Drawing.Size(161, 22);
            this.txtidtodelete.TabIndex = 21;
            // 
            // lblidmoviedelete
            // 
            this.lblidmoviedelete.AutoSize = true;
            this.lblidmoviedelete.Location = new System.Drawing.Point(17, 84);
            this.lblidmoviedelete.Name = "lblidmoviedelete";
            this.lblidmoviedelete.Size = new System.Drawing.Size(262, 17);
            this.lblidmoviedelete.TabIndex = 20;
            this.lblidmoviedelete.Text = "the ID of the movie you want to update >";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(105, 42);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(174, 17);
            this.lblUpdate.TabIndex = 19;
            this.lblUpdate.Text = "Update number of Seats >";
            // 
            // txtnumofseats
            // 
            this.txtnumofseats.Location = new System.Drawing.Point(289, 39);
            this.txtnumofseats.Name = "txtnumofseats";
            this.txtnumofseats.Size = new System.Drawing.Size(161, 22);
            this.txtnumofseats.TabIndex = 18;
            // 
            // btnupdatenumofseats
            // 
            this.btnupdatenumofseats.BackColor = System.Drawing.Color.Crimson;
            this.btnupdatenumofseats.ForeColor = System.Drawing.Color.White;
            this.btnupdatenumofseats.Location = new System.Drawing.Point(267, 120);
            this.btnupdatenumofseats.Name = "btnupdatenumofseats";
            this.btnupdatenumofseats.Size = new System.Drawing.Size(193, 44);
            this.btnupdatenumofseats.TabIndex = 17;
            this.btnupdatenumofseats.Text = "Update [number] Of Seats";
            this.btnupdatenumofseats.UseVisualStyleBackColor = false;
            this.btnupdatenumofseats.Click += new System.EventHandler(this.btnupdatenumofseats_Click);
            // 
            // formUpdatenumofseats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 188);
            this.Controls.Add(this.txtidtodelete);
            this.Controls.Add(this.lblidmoviedelete);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtnumofseats);
            this.Controls.Add(this.btnupdatenumofseats);
            this.Name = "formUpdatenumofseats";
            this.Text = "Update number of Seats >>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidtodelete;
        private System.Windows.Forms.Label lblidmoviedelete;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtnumofseats;
        private System.Windows.Forms.Button btnupdatenumofseats;
    }
}