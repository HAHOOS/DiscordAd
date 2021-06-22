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
    public partial class Password : Form
    {
        Type type;
        bool logged;

        public Password(Type type)
        {
            InitializeComponent();
            this.type = type;

        }

        public enum Type
        {
            START_APP,
            START_AD,
            STOP,
            SAVE,
            SETTINGS,
            MANUAL
        };
        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (!show_pass.Checked)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text == Properties.Settings.Default.Password)
            {
                Properties.Settings.Default.Password_Logged = true;
                Properties.Settings.Default.Save();
                logged = true;
                this.Hide();
                
                
                if (type.Equals(Type.START_APP))
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }else if (type.Equals(Type.START_AD))
                {
                    if (Properties.Settings.Default.Manual == true)
                    {
                        Form1 form1 = new Form1();
                        form1.start_without_file();
                        form1.status.Visible = true;
                        
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.start_with_file();
                        form1.status.Visible = true;
                    }
                }
                else if (type.Equals(Type.MANUAL))
                {
                    Without_file manual = new Without_file();
                    manual.Show();
                }
                else if (type.Equals(Type.SETTINGS))
                {
                    Settings settings = new Settings();
                    settings.Show();
                }

            }
            else
            {
                MessageBox.Show("Password is incorrect!", "DiscordAd Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
                
            }
        }

        private void Password_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logged)
            {
                Application.Exit();
            }
        }
    }
}
