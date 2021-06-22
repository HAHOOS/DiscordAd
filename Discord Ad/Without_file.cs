using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Ad
{
    public partial class Without_file : Form
    {
        public Without_file()
        {
            InitializeComponent();
            
            txt_id.Text = Convert.ToString(Properties.Settings.Default.Client_id);
            txt_details.Text = Properties.Settings.Default.Details;
            txt_state.Text = Properties.Settings.Default.State;
            check_start_time.Checked = Properties.Settings.Default.Start_time;
            txt_large_key.Text = Properties.Settings.Default.LargeImage_key;
            txt_large_text.Text = Properties.Settings.Default.LargeImage_text;
            txt_small_key.Text = Properties.Settings.Default.SmallImage_key;
            txt_small_text.Text = Properties.Settings.Default.SmallImage_text;
            txt_button1_label.Text = Properties.Settings.Default.Button1_Label;
            txt_button1_URL.Text = Properties.Settings.Default.Button1_URL;
            txt_button2_label.Text = Properties.Settings.Default.Button2_Label;
            txt_button2_URL.Text = Properties.Settings.Default.Button2_URL;
            //Addons Settings
            string path = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"Addons");
            for (int i = 0; i < Directory.GetFiles(path).Length; i++)
            {
                Panel addoncontrol = new Panel();
                addoncontrol.BackColor = System.Drawing.Color.DodgerBlue;
                addoncontrol.Location = new System.Drawing.Point(3, 3);
                addoncontrol.Name = "panel1";
                addoncontrol.Size = new System.Drawing.Size(749, 198);
                addoncontrol.TabIndex = 0;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Client_id = Convert.ToInt64(txt_id.Text);
                Properties.Settings.Default.Details = txt_details.Text;
                Properties.Settings.Default.State = txt_state.Text;
                Properties.Settings.Default.Start_time = check_start_time.Checked;
                Properties.Settings.Default.LargeImage_key = txt_large_key.Text;
                Properties.Settings.Default.LargeImage_text = txt_large_text.Text;
                Properties.Settings.Default.SmallImage_key = txt_small_key.Text;
                Properties.Settings.Default.SmallImage_text = txt_small_key.Text;
                Properties.Settings.Default.Button1_Label = txt_button1_label.Text;
                Properties.Settings.Default.Button1_URL = txt_button1_URL.Text;
                Properties.Settings.Default.Button2_Label = txt_button2_label.Text;
                Properties.Settings.Default.Button2_URL = txt_button2_URL.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Successfully saved ad settings", "Discord Ad", MessageBoxButtons.OK);
            }catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Please try fix this {Environment.NewLine} {Environment.NewLine}" + ex.Message,"Discord Ad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void Without_file_Load(object sender, EventArgs e)
        {

        }

        
    }
}
