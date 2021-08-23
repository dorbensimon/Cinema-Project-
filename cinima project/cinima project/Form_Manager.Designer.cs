namespace cinima_project
{
    partial class Form_Manager
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
            this.btnaddmovies = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnupdatenumofseats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movielist
            // 
            this.movielist.FormattingEnabled = true;
            this.movielist.ItemHeight = 16;
            this.movielist.Location = new System.Drawing.Point(306, 95);
            this.movielist.Name = "movielist";
            this.movielist.Size = new System.Drawing.Size(471, 164);
            this.movielist.TabIndex = 0;
            this.movielist.SelectedIndexChanged += new System.EventHandler(this.movielist_SelectedIndexChanged);
            // 
            // btnshowmovie
            // 
            this.btnshowmovie.BackColor = System.Drawing.Color.DarkRed;
            this.btnshowmovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowmovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10619F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowmovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshowmovie.Location = new System.Drawing.Point(38, 95);
            this.btnshowmovie.Name = "btnshowmovie";
            this.btnshowmovie.Size = new System.Drawing.Size(222, 67);
            this.btnshowmovie.TabIndex = 1;
            this.btnshowmovie.Text = "show movie";
            this.btnshowmovie.UseVisualStyleBackColor = false;
            this.btnshowmovie.Click += new System.EventHandler(this.btnshowmovie_Click);
            // 
            // btnaddmovies
            // 
            this.btnaddmovies.BackColor = System.Drawing.Color.DarkRed;
            this.btnaddmovies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddmovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmovies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaddmovies.Location = new System.Drawing.Point(12, 299);
            this.btnaddmovies.Name = "btnaddmovies";
            this.btnaddmovies.Size = new System.Drawing.Size(139, 70);
            this.btnaddmovies.TabIndex = 3;
            this.btnaddmovies.Text = "Add Movie";
            this.btnaddmovies.UseVisualStyleBackColor = false;
            this.btnaddmovies.Click += new System.EventHandler(this.btnaddmovies_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkRed;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Location = new System.Drawing.Point(608, 299);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 70);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete Movie";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(217, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 70);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Price of movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdatenumofseats
            // 
            this.btnupdatenumofseats.BackColor = System.Drawing.Color.DarkRed;
            this.btnupdatenumofseats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatenumofseats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatenumofseats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdatenumofseats.Location = new System.Drawing.Point(422, 299);
            this.btnupdatenumofseats.Name = "btnupdatenumofseats";
            this.btnupdatenumofseats.Size = new System.Drawing.Size(139, 70);
            this.btnupdatenumofseats.TabIndex = 6;
            this.btnupdatenumofseats.Text = "Update number of Seats";
            this.btnupdatenumofseats.UseVisualStyleBackColor = false;
            this.btnupdatenumofseats.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::cinima_project.Properties.Resources.theatre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btnupdatenumofseats);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnaddmovies);
            this.Controls.Add(this.btnshowmovie);
            this.Controls.Add(this.movielist);
            this.Name = "Form_Manager";
            this.Text = "Form_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movielist;
        private System.Windows.Forms.Button btnshowmovie;
        private System.Windows.Forms.Button btnaddmovies;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnupdatenumofseats;
    }
}