using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Ad
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            password_txt.Text = Properties.Settings.Default.Password;
            password_enabled.Checked = Properties.Settings.Default.Password_Enabled;
             password_enabled.Checked = Properties.Settings.Default.Password_Enabled;
            password_checkbox_startApp.Checked = Properties.Settings.Default.Password_Start_App;
            password_checkbox_startAd.Checked = Properties.Settings.Default.Password_Start_Ad;
            password_checkbox_stop.Checked = Properties.Settings.Default.Password_Stop;
            password_checkbox_save.Checked = Properties.Settings.Default.Password_Save;
            password_checkbox_settings.Checked = Properties.Settings.Default.Password_Settings;
            password_checkbox_manual.Checked = Properties.Settings.Default.Password_Manual;

        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.Enabled = password_enabled.Checked;
            

        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (!show_pass.Checked)
            {
                password_txt.UseSystemPasswordChar = true;
            }
            else
            {
                password_txt.UseSystemPasswordChar = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Password = password_txt.Text;
                Properties.Settings.Default.Password_Enabled = password_enabled.Checked;
                Properties.Settings.Default.Password_Start_App = password_checkbox_startApp.Checked;
                Properties.Settings.Default.Password_Start_Ad = password_checkbox_startAd.Checked;
                Properties.Settings.Default.Password_Stop = password_checkbox_stop.Checked;
                Properties.Settings.Default.Password_Save = password_checkbox_save.Checked;
                Properties.Settings.Default.Password_Settings = password_checkbox_settings.Checked;
                Properties.Settings.Default.Password_Manual = password_checkbox_manual.Checked;
                Properties.Settings.Default.Save();
                MessageBox.Show("Successfully saved settings", "Discord Ad", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Please try fix this {Environment.NewLine} {Environment.NewLine}" + ex.Message, "Discord Ad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
