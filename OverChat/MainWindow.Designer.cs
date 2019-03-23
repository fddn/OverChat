namespace OverChat
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.input_username = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_username.ForeColor = System.Drawing.SystemColors.Window;
            this.input_username.Location = new System.Drawing.Point(42, 12);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(249, 20);
            this.input_username.TabIndex = 0;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.Control;
            this.btn_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_load.BackgroundImage")));
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_load.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_load.Location = new System.Drawing.Point(297, 10);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(25, 25);
            this.btn_load.TabIndex = 2;
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(328, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_settings.Location = new System.Drawing.Point(12, 10);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(25, 25);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.input_username);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0.65D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverChat";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_settings;
    }
}

