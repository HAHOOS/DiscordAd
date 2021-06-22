
namespace Discord_Ad
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_enabled = new Discord_Ad.ToggleButton.ToggleButton();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.password_checkbox_startApp = new System.Windows.Forms.CheckBox();
            this.password_checkbox_startAd = new System.Windows.Forms.CheckBox();
            this.password_checkbox_save = new System.Windows.Forms.CheckBox();
            this.password_checkbox_stop = new System.Windows.Forms.CheckBox();
            this.password_checkbox_manual = new System.Windows.Forms.CheckBox();
            this.password_checkbox_settings = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Font = new System.Drawing.Font("Montserrat", 10F);
            this.show_pass.Location = new System.Drawing.Point(16, 59);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(139, 24);
            this.show_pass.TabIndex = 2;
            this.show_pass.Text = "Show Password";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enable Password";
            // 
            // password_enabled
            // 
            this.password_enabled.AutoSize = true;
            this.password_enabled.Location = new System.Drawing.Point(15, 84);
            this.password_enabled.MinimumSize = new System.Drawing.Size(45, 22);
            this.password_enabled.Name = "password_enabled";
            this.password_enabled.OffBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.password_enabled.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.password_enabled.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.password_enabled.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.password_enabled.Size = new System.Drawing.Size(45, 22);
            this.password_enabled.TabIndex = 3;
            this.password_enabled.UseVisualStyleBackColor = true;
            this.password_enabled.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(16, 33);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(157, 20);
            this.password_txt.TabIndex = 5;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label3.Location = new System.Drawing.Point(12, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Language:";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(16, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "English";
            this.comboBox1.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Blue;
            this.btn_save.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(608, 327);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(152, 60);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // password_checkbox_startApp
            // 
            this.password_checkbox_startApp.AutoSize = true;
            this.password_checkbox_startApp.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_startApp.Location = new System.Drawing.Point(15, 20);
            this.password_checkbox_startApp.Name = "password_checkbox_startApp";
            this.password_checkbox_startApp.Size = new System.Drawing.Size(95, 24);
            this.password_checkbox_startApp.TabIndex = 20;
            this.password_checkbox_startApp.Text = "Start App";
            this.password_checkbox_startApp.UseVisualStyleBackColor = true;
            // 
            // password_checkbox_startAd
            // 
            this.password_checkbox_startAd.AutoSize = true;
            this.password_checkbox_startAd.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_startAd.Location = new System.Drawing.Point(15, 44);
            this.password_checkbox_startAd.Name = "password_checkbox_startAd";
            this.password_checkbox_startAd.Size = new System.Drawing.Size(86, 24);
            this.password_checkbox_startAd.TabIndex = 21;
            this.password_checkbox_startAd.Text = "Start Ad";
            this.password_checkbox_startAd.UseVisualStyleBackColor = true;
            // 
            // password_checkbox_save
            // 
            this.password_checkbox_save.AutoSize = true;
            this.password_checkbox_save.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_save.Location = new System.Drawing.Point(15, 89);
            this.password_checkbox_save.Name = "password_checkbox_save";
            this.password_checkbox_save.Size = new System.Drawing.Size(61, 24);
            this.password_checkbox_save.TabIndex = 23;
            this.password_checkbox_save.Text = "Save";
            this.password_checkbox_save.UseVisualStyleBackColor = true;
            // 
            // password_checkbox_stop
            // 
            this.password_checkbox_stop.AutoSize = true;
            this.password_checkbox_stop.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_stop.Location = new System.Drawing.Point(15, 67);
            this.password_checkbox_stop.Name = "password_checkbox_stop";
            this.password_checkbox_stop.Size = new System.Drawing.Size(61, 24);
            this.password_checkbox_stop.TabIndex = 22;
            this.password_checkbox_stop.Text = "Stop";
            this.password_checkbox_stop.UseVisualStyleBackColor = true;
            // 
            // password_checkbox_manual
            // 
            this.password_checkbox_manual.AutoSize = true;
            this.password_checkbox_manual.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_manual.Location = new System.Drawing.Point(15, 133);
            this.password_checkbox_manual.Name = "password_checkbox_manual";
            this.password_checkbox_manual.Size = new System.Drawing.Size(79, 24);
            this.password_checkbox_manual.TabIndex = 25;
            this.password_checkbox_manual.Text = "Manual";
            this.password_checkbox_manual.UseVisualStyleBackColor = true;
            // 
            // password_checkbox_settings
            // 
            this.password_checkbox_settings.AutoSize = true;
            this.password_checkbox_settings.Font = new System.Drawing.Font("Montserrat", 10F);
            this.password_checkbox_settings.Location = new System.Drawing.Point(15, 110);
            this.password_checkbox_settings.Name = "password_checkbox_settings";
            this.password_checkbox_settings.Size = new System.Drawing.Size(87, 24);
            this.password_checkbox_settings.TabIndex = 24;
            this.password_checkbox_settings.Text = "Settings";
            this.password_checkbox_settings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.password_checkbox_startApp);
            this.panel1.Controls.Add(this.password_checkbox_manual);
            this.panel1.Controls.Add(this.password_checkbox_startAd);
            this.panel1.Controls.Add(this.password_checkbox_settings);
            this.panel1.Controls.Add(this.password_checkbox_stop);
            this.panel1.Controls.Add(this.password_checkbox_save);
            this.panel1.Location = new System.Drawing.Point(16, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 199);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password Needed:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_enabled);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox show_pass;
        private ToggleButton.ToggleButton password_enabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox password_checkbox_startApp;
        private System.Windows.Forms.CheckBox password_checkbox_startAd;
        private System.Windows.Forms.CheckBox password_checkbox_save;
        private System.Windows.Forms.CheckBox password_checkbox_stop;
        private System.Windows.Forms.CheckBox password_checkbox_manual;
        private System.Windows.Forms.CheckBox password_checkbox_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}