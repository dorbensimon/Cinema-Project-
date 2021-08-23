namespace cinima_project
{
    partial class Form_add_moviescs
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
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.txtidmovie = new System.Windows.Forms.TextBox();
            this.txtnumberofseat = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.lblnamemovie = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblnumberofseat = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnaddmovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(157, 76);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(172, 22);
            this.txtprice.TabIndex = 0;
            // 
            // txtmoviename
            // 
            this.txtmoviename.Location = new System.Drawing.Point(157, 46);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(172, 22);
            this.txtmoviename.TabIndex = 1;
            // 
            // txtidmovie
            // 
            this.txtidmovie.Location = new System.Drawing.Point(157, 155);
            this.txtidmovie.Name = "txtidmovie";
            this.txtidmovie.Size = new System.Drawing.Size(172, 22);
            this.txtidmovie.TabIndex = 2;
            // 
            // txtnumberofseat
            // 
            this.txtnumberofseat.Location = new System.Drawing.Point(157, 131);
            this.txtnumberofseat.Name = "txtnumberofseat";
            this.txtnumberofseat.Size = new System.Drawing.Size(172, 22);
            this.txtnumberofseat.TabIndex = 3;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(157, 104);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(172, 22);
            this.txtdate.TabIndex = 4;
            // 
            // lblnamemovie
            // 
            this.lblnamemovie.AutoSize = true;
            this.lblnamemovie.Font = new System.Drawing.Font("Segoe Print", 8.920354F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemovie.Location = new System.Drawing.Point(12, 46);
            this.lblnamemovie.Name = "lblnamemovie";
            this.lblnamemovie.Size = new System.Drawing.Size(110, 24);
            this.lblnamemovie.TabIndex = 5;
            this.lblnamemovie.Text = "> Movie Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe Print", 8.920354F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(12, 74);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(59, 24);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "> Price";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe Print", 8.920354F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(12, 102);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 24);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "> Date";
            // 
            // lblnumberofseat
            // 
            this.lblnumberofseat.AutoSize = true;
            this.lblnumberofseat.Font = new System.Drawing.Font("Segoe Print", 8.920354F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofseat.Location = new System.Drawing.Point(12, 130);
            this.lblnumberofseat.Name = "lblnumberofseat";
            this.lblnumberofseat.Size = new System.Drawing.Size(130, 24);
            this.lblnumberofseat.TabIndex = 8;
            this.lblnumberofseat.Text = "> [num] of Seats";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe Print", 8.920354F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 158);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(86, 24);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "> ID movie";
            // 
            // btnaddmovie
            // 
            this.btnaddmovie.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaddmovie.Font = new System.Drawing.Font("Segoe Print", 10.83186F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmovie.ForeColor = System.Drawing.Color.White;
            this.btnaddmovie.Location = new System.Drawing.Point(115, 277);
            this.btnaddmovie.Name = "btnaddmovie";
            this.btnaddmovie.Size = new System.Drawing.Size(143, 55);
            this.btnaddmovie.TabIndex = 10;
            this.btnaddmovie.Text = "Add Movie!";
            this.btnaddmovie.UseVisualStyleBackColor = false;
            this.btnaddmovie.Click += new System.EventHandler(this.btnaddmovie_Click);
            // 
            // Form_add_moviescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 384);
            this.Controls.Add(this.btnaddmovie);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblnumberofseat);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblnamemovie);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtnumberofseat);
            this.Controls.Add(this.txtidmovie);
            this.Controls.Add(this.txtmoviename);
            this.Controls.Add(this.txtprice);
            this.Name = "Form_add_moviescs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_add_moviescs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.TextBox txtidmovie;
        private System.Windows.Forms.TextBox txtnumberofseat;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label lblnamemovie;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblnumberofseat;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnaddmovie;
    }
}