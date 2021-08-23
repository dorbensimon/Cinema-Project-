namespace cinima_project
{
    partial class Form_select_status
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
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_manager
            // 
            this.btn_manager.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_manager.Enabled = false;
            this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manager.ForeColor = System.Drawing.Color.White;
            this.btn_manager.Location = new System.Drawing.Point(12, 12);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(185, 54);
            this.btn_manager.TabIndex = 0;
            this.btn_manager.Text = "Manager";
            this.btn_manager.UseVisualStyleBackColor = false;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(186, 84);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 38);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_User
            // 
            this.btn_User.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.ForeColor = System.Drawing.Color.White;
            this.btn_User.Location = new System.Drawing.Point(272, 12);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(185, 54);
            this.btn_User.TabIndex = 3;
            this.btn_User.Text = "User";
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // Form_select_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(469, 134);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_manager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_select_status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_User;
    }
}