namespace cinima_project
{
    partial class Form_User
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
            this.movielist = new System.Windows.Forms.ListBox();
            this.btnshowmovie = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtbuy = new System.Windows.Forms.TextBox();
            this.btnchoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movielist
            // 
            this.movielist.FormattingEnabled = true;
            this.movielist.ItemHeight = 16;
            this.movielist.Location = new System.Drawing.Point(317, 27);
            this.movielist.Name = "movielist";
            this.movielist.Size = new System.Drawing.Size(471, 164);
            this.movielist.TabIndex = 1;
            this.movielist.SelectedIndexChanged += new System.EventHandler(this.movielist_SelectedIndexChanged);
            // 
            // btnshowmovie
            // 
            this.btnshowmovie.BackColor = System.Drawing.Color.DarkRed;
            this.btnshowmovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowmovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowmovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshowmovie.Location = new System.Drawing.Point(43, 27);
            this.btnshowmovie.Name = "btnshowmovie";
            this.btnshowmovie.Size = new System.Drawing.Size(222, 67);
            this.btnshowmovie.TabIndex = 2;
            this.btnshowmovie.Text = "show movie";
            this.btnshowmovie.UseVisualStyleBackColor = false;
            this.btnshowmovie.Click += new System.EventHandler(this.btnshowmovie_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Maroon;
            this.lblname.Font = new System.Drawing.Font("Segoe Print", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblname.Location = new System.Drawing.Point(12, 235);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(489, 33);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "enter the name of the Movie you want to watch";
            // 
            // txtbuy
            // 
            this.txtbuy.Font = new System.Drawing.Font("Segoe Print", 10.83186F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuy.Location = new System.Drawing.Point(548, 235);
            this.txtbuy.Multiline = true;
            this.txtbuy.Name = "txtbuy";
            this.txtbuy.Size = new System.Drawing.Size(240, 33);
            this.txtbuy.TabIndex = 4;
            // 
            // btnchoose
            // 
            this.btnchoose.BackColor = System.Drawing.Color.DarkRed;
            this.btnchoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchoose.Font = new System.Drawing.Font("Segoe Print", 10.83186F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchoose.Location = new System.Drawing.Point(548, 283);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(240, 36);
            this.btnchoose.TabIndex = 5;
            this.btnchoose.Text = "Choose this Movie";
            this.btnchoose.UseVisualStyleBackColor = false;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cinima_project.Properties.Resources.theatre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchoose);
            this.Controls.Add(this.txtbuy);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnshowmovie);
            this.Controls.Add(this.movielist);
            this.Name = "Form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.Form_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movielist;
        private System.Windows.Forms.Button btnshowmovie;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtbuy;
        private System.Windows.Forms.Button btnchoose;
    }
}