
namespace Discord_Ad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.label_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_directory = new System.Windows.Forms.Label();
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.toggleButton_manual = new Discord_Ad.ToggleButton.ToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISCORD AD";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Blue;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(215, 313);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(366, 69);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_startAd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config.yml";
            this.openFileDialog1.Filter = "YML Files|*.yml";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar,
            this.label_1,
            this.label_status});
            this.status.Location = new System.Drawing.Point(0, 455);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.status.Size = new System.Drawing.Size(800, 22);
            this.status.TabIndex = 6;
            this.status.Text = "statusStrip1";
            this.status.Visible = false;
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            this.progressbar.Value = 25;
            // 
            // label_1
            // 
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(42, 17);
            this.label_1.Text = "Status:";
            // 
            // label_status
            // 
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(48, 17);
            this.label_status.Text = "Starting";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Blue;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Enabled = false;
            this.btn_load.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(587, 238);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(180, 69);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-7, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(808, 67);
            this.label2.TabIndex = 8;
            this.label2.Text = "Directory:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label_directory
            // 
            this.label_directory.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_directory.Location = new System.Drawing.Point(-2, 216);
            this.label_directory.Name = "label_directory";
            this.label_directory.Size = new System.Drawing.Size(803, 49);
            this.label_directory.TabIndex = 9;
            this.label_directory.Text = "None";
            this.label_directory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_directory.Visible = false;
            // 
            // btn_manual
            // 
            this.btn_manual.BackColor = System.Drawing.Color.Blue;
            this.btn_manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manual.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manual.ForeColor = System.Drawing.Color.White;
            this.btn_manual.Location = new System.Drawing.Point(215, 388);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(366, 50);
            this.btn_manual.TabIndex = 10;
            this.btn_manual.Text = "Manual";
            this.btn_manual.UseVisualStyleBackColor = false;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Blue;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(587, 313);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(180, 69);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 21.75F);
            this.label3.Location = new System.Drawing.Point(640, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Manual";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Blue;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(29, 388);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(180, 50);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // toggleButton_manual
            // 
            this.toggleButton_manual.AutoSize = true;
            this.toggleButton_manual.Checked = true;
            this.toggleButton_manual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton_manual.Enabled = false;
            this.toggleButton_manual.Location = new System.Drawing.Point(599, 408);
            this.toggleButton_manual.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton_manual.Name = "toggleButton_manual";
            this.toggleButton_manual.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton_manual.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton_manual.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton_manual.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton_manual.Size = new System.Drawing.Size(45, 22);
            this.toggleButton_manual.TabIndex = 25;
            this.toggleButton_manual.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Loading with File YML soon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toggleButton_manual);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.label_directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DiscordAd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_directory;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Button btn_stop;
        public System.Windows.Forms.ToolStripStatusLabel label_1;
        public System.Windows.Forms.ToolStripStatusLabel label_status;
        public System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_settings;
        private ToggleButton.ToggleButton toggleButton_manual;
        public System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Label label4;
    }
}

