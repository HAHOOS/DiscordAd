using DiscordRPC;
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
using System.Reflection;
using System.Threading;
using Button = DiscordRPC.Button;
using DiscordRPC.Logging;

namespace Discord_Ad
{
    public partial class Form1 : Form
    {
        public string path;
        public DiscordRpcClient client;
        //StreamReader reader;

        public Form1()
        {
            
            InitializeComponent();
            
            
            
            
        }

        





        private void btn_startAd_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password_Start_Ad)
            {
                PasswordVerify(Password.Type.START_AD, true);
            }
            else
            {
                if (Properties.Settings.Default.Manual == true)
                {
                   
                    start_without_file();
                    

                }
                else
                {
                    
                    start_with_file();
                    
                }
            }
        }
        /*
        private void btn_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                label_directory.Text = openFileDialog1.FileName.ToString();
                MessageBox.Show(openFileDialog1.FileName.ToString());
            }
        }
        */
        public void Stop()
        {
            client.ClearPresence();
            client.Dispose();
            btn_stop.Visible = false;
            status.Visible = false;
        }
        public void start_with_file()
        {
            //Under Work
            /*
            status.Visible = true;
            progressbar.Value = 25;
            reader = File.OpenText(openFileDialog1.FileName.ToString());
            var yaml = new YamlStream();
            yaml.Load(reader);



            var deserializer = new Deserializer();
            var res = deserializer.Deserialize<dynamic>(reader);
            string client_id = res["client-id"];
            client = new DiscordRpcClient(client_id);
            client.OnReady += (sender, e) =>
            {
                progressbar.Value = 100;
                label_status.ForeColor = Color.LightGreen;
                label_status.Text = "Ready";
                if (res["details"] != null)
                {
                    string details = res["details"];
                    client.UpdateDetails(details);
                }
                if (res["state"] != null)
                {
                    string state = res["state"];
                    client.UpdateState(state);
                }
                if (res["Large_Image"]["image_key"] != null)
                {
                    string large_image_key = res["Large_Image"]["image_key"];
                    string large_image_text = null;
                    if (res["Large_Image"]["image_text"] != null)
                    {
                        large_image_text = res["Large_Image"]["image_text"];
                    }
                    client.UpdateLargeAsset(large_image_key, large_image_text);
                }
                if (res["Small_Image"]["image_key"] != null)
                {
                    string small_image_key = res["Small_Image"]["image_key"];
                    string small_image_text = null;
                    if (res["Small_Image"]["image_text"] != null)
                    {
                        small_image_text = res["Small_Image"]["image_text"];
                    }
                    client.UpdateLargeAsset(small_image_key, small_image_text);
                }
                if (res["start_time"] == true)
                {
                    DateTime time = DateTime.Now;


                    client.UpdateStartTime(time);
                }
                /*
                if (res["Button1"]["label"] != null)
                {
                    string button_label = res["Button1"]["label"];
                    string button_URL = null;
                    if (res["Button1"]["URL"] != null)
                    {
                        button_URL = res["Button1"]["URL"];
                    }
                    else
                    {
                        
                    }
                    client.
                }
                
            };
            */
        }

        public void start_without_file()
        {


            status.Visible = true;
            btn_stop.Visible = true;
            string button1URL = Properties.Settings.Default.Button1_URL;
         
            string button2URL = Properties.Settings.Default.Button2_URL;
            
         
            string client_id = Convert.ToString(Properties.Settings.Default.Client_id);
            client = new DiscordRpcClient(client_id);
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            
            client.Initialize();
            SetStatus("Initializing", Color.Orange, 25);





            //discordAd.ClientId = long.Parse(client_id);
            client.OnReady += (sender, e) =>
            {
                /*
                if (Properties.Settings.Default.Details != null)
                {
                    string details = Properties.Settings.Default.Details;
                    client.UpdateDetails(details);
                    //discordAd.Details = details;
                }
                if (Properties.Settings.Default.State != null)
                {
                    string state = Properties.Settings.Default.State;
                    client.UpdateState(state);
                    //discordAd.State = state;
                }
                if (Properties.Settings.Default.LargeImage_key != null)
                {
                    string large_image_key = Properties.Settings.Default.LargeImage_key;
                    string large_image_text = Properties.Settings.Default.LargeImage_text;
                    
                    client.UpdateLargeAsset(large_image_key, large_image_text);
                    //discordAd.LargeImage_key = large_image_key;
                    //discordAd.LargeImage_text = large_image_text;
                }
                if (Properties.Settings.Default.SmallImage_key != null)
                {
                    string small_image_key = Properties.Settings.Default.SmallImage_key;
                    string small_image_text = Properties.Settings.Default.SmallImage_text;
                    client.UpdateLargeAsset(small_image_key, small_image_text);
                    //discordAd.SmallImage_key = small_image_key;
                    //discordAd.SmallImage_text = small_image_text;
                }
                if (Properties.Settings.Default.Start_time == true)
                {
                    DateTime time = DateTime.Now;


                    client.UpdateStartTime(time);
                    //discordAd.Start_Time = Properties.Settings.Default.Start_time;

                }
                /*
                if (res["Button1"]["label"] != null)
                {
                    string button_label = res["Button1"]["label"];
                    string button_URL = null;
                    if (res["Button1"]["URL"] != null)
                    {
                        button_URL = res["Button1"]["URL"];
                    }
                    else
                    {
                        
                    }
                    client.
                }
                */
                /*
                progressbar.Value = 100;
                label_status.ForeColor = Color.LightGreen;
                label_status.Text = "Ready";
                /*
                /*
                client.SetPresence(new RichPresence()
                {
                    Details = Properties.Settings.Default.Details,
                    State = Properties.Settings.Default.State,
                    Timestamps = new Timestamps(DateTime.Now),
                    Assets = new Assets()
                    {
                        LargeImageKey = Properties.Settings.Default.LargeImage_key,
                        LargeImageText = Properties.Settings.Default.LargeImage_text,
                        SmallImageKey = Properties.Settings.Default.SmallImage_key,
                        SmallImageText = Properties.Settings.Default.SmallImage_text
                    }
                }) ; 
                */


                client.SetPresence(new RichPresence
                {
                    Details = Properties.Settings.Default.Details,
                    State = Properties.Settings.Default.State,
                    Assets = new Assets()
                    {
                        LargeImageKey = Properties.Settings.Default.LargeImage_key,
                        LargeImageText = Properties.Settings.Default.LargeImage_text,
                        SmallImageKey = Properties.Settings.Default.SmallImage_key,
                        SmallImageText = Properties.Settings.Default.SmallImage_text,
                    },

                     
                      Buttons = new Button[]
                        {
                            new Button() { Label = Properties.Settings.Default.Button1_Label, Url = button1URL },
                            new Button() { Label = Properties.Settings.Default.Button2_Label, Url = button2URL }
                        }


                });
                if (Properties.Settings.Default.Start_time)
                {
                    client.UpdateStartTime(DateTime.Now);
                }

               
                
                SetStatus("Ready", Color.Lime, 100);
                Console.WriteLine("Successfully Initialized DiscordRPC");
            };
            client.OnError += (sender, e) =>
            {
                SetStatus("Error", Color.Yellow, 0);
                client.Dispose();
                MessageBox.Show($"Error occured while starting discord ad {Environment.NewLine}" + e.Message, "Discord Ad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password_Manual)
            {
                PasswordVerify(Password.Type.MANUAL, true);
            }
            else
            {
                Without_file without_File = new Without_file();
                without_File.ShowDialog();
            }
            
        }

        public void SetStatus(string status, Color color, int value_of_progress)
        {

            Thread setThread = new Thread(delegate ()
            {
                label_status.Text = status;
                Thread forecolorThread = new Thread(delegate ()
                {
                    label_status.ForeColor = color;
                });
                forecolorThread.Start();
                Thread progressThread = new Thread(delegate ()
                {
                    progressbar.Value = value_of_progress;
                });
                progressThread.Start();

               
            });
           
            setThread.Start();
            
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Stop();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*
            //Add-ons Directory
            string path2 = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"Addons");
            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }
            */
        }
        /*
        private void LoadAddons()
        {
            string path = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), @"Addons");
            for (int i = 0; i < Directory.GetFiles(path).Length; i++)
            {
                Assembly addon;
                addon = Assembly.LoadFrom(Path.Combine(Directory.GetFiles(path)[i]));
                
            }
        }
        */
        private void toggleButton_manual_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Manual = toggleButton_manual.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password_Settings)
            {
                PasswordVerify(Password.Type.SETTINGS, true);
            }
            else
            {
                Settings settings = new Settings();
                settings.ShowDialog();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            toggleButton_manual.Checked = Properties.Settings.Default.Manual;
            if (Properties.Settings.Default.Password_Start_App)
            {
                PasswordVerify(Password.Type.START_APP, false);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Password_Logged = false;
            Properties.Settings.Default.Save();
            if(client == null)
            {
                client = new DiscordRpcClient("0");
            }
            if (client.IsInitialized)
            {
                e.Cancel = true;
                if(MessageBox.Show($"Are you sure to exit application? {Environment.NewLine}Ad is activated", "DiscordAd", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    Stop();
                    //Application.Exit(new CancelEventArgs(false));
                    Environment.Exit(-1);
                }
            }
            else
            {
                //Application.Exit();
                Environment.Exit(-1);
            }
        }

        private void PasswordVerify(Password.Type type, bool showAsDialog)
        {
            bool activated;
            switch (type)
            {
                case Password.Type.START_APP:
                  activated = Properties.Settings.Default.Password_Start_App;
                  break;
                case Password.Type.START_AD:
                    activated = Properties.Settings.Default.Password_Start_Ad;
                    break;
                case Password.Type.SAVE:
                    activated = Properties.Settings.Default.Password_Save;
                    break;
                case Password.Type.MANUAL:
                    activated = Properties.Settings.Default.Password_Manual;
                    break;
                case Password.Type.SETTINGS:
                    activated = Properties.Settings.Default.Password_Settings;
                    break;
                case Password.Type.STOP:
                    activated = Properties.Settings.Default.Password_Stop;
                    break;

            }
            if (Properties.Settings.Default.Password_Enabled == true)
            {
                if (Properties.Settings.Default.Password_Start_App == true)
                {
                    Password pass = new Password(type);
                    if (type.Equals(Password.Type.START_APP))
                    {
                        if (!Properties.Settings.Default.Password_Logged == true)
                        {

                            if (showAsDialog)
                            {
                                pass.ShowDialog();

                            }
                            else
                            {
                                pass.Show();
                                this.Hide();
                            }


                        }
                    }
                    else
                    {
                        if (showAsDialog)
                        {
                            pass.ShowDialog();

                        }
                        else
                        {
                            pass.Show();
                            this.Hide();
                        }
                    }
                    
                }
            }
        }

       
    }

   
}
