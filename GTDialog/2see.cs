using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GTDialog
{
    public partial class _2see : Form
    {
        private string packetdata = string.Empty;
        private int logcount = 0;
        List<string> packetper = new List<string>();
        
        public _2see(string packets)
        {
            InitializeComponent();
            packetdata = shit2(packets);
        }
        private string shit2(string str)
        {
            return Regex.Replace(str, @"\r\n?|\n", "");
        }

        private void newlog(string log)
        {
            logbox.Items.Add(logcount +": " +log);
            logcount++;
        }


        private void _2see_Load(object sender, EventArgs e)
        {
            label1.Text = packetdata;
            string[] par = packetdata.Split('|');
            List<string> packetlist = par.ToList<string>();
            packetper = new List<string>();
            List<string> errors = new List<string>();
            newlog("Read Datas Started.");
            for (int i = 0; i < packetlist.Count; )
            {
                string sper = string.Empty;
                int iper = 0;

                all.Items.Add(i.ToString() +": " +packetlist[i]);
                newlog(packetlist[i]);
                if (packetlist[i] == "add_spacer")
                {
                    iper = 2;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_achieve")
                {
                    iper = 5;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_button")
                {
                    iper = 3;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_button")
                {
                    iper = 3;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_checkbox")
                {
                    iper = 4;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_image_button")
                {
                    iper = 7;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_item_picker")
                {
                    iper = 4;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_label")
                {
                    iper = 2;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_label_with_icon")
                {
                    iper = 5;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_player_info")
                {
                    iper = 5;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_quick_exit")
                {
                    iper = 1;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;

                }
                else if (packetlist[i] == "add_slot")
                {
                    iper = 1;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_smalltext")
                {
                    iper = 3;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_smalltext_forced")
                {
                    iper = 3;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_smalltext_forced_alpha")
                {
                    iper = 4;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_text_input")
                {
                    iper = 5;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_text_input_password")
                {
                    iper = 5;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_textbox")
                {
                    iper = 2;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else if (packetlist[i] == "add_url_button")
                {
                    if (packetlist[i + 3] == "NOFLAGS")
                    {
                        iper = 6;
                        for (int ip = 0; ip < iper; )
                        {
                            newlog("Successful item Reading: " + packetlist[i + ip]);
                            sper += packetlist[i + ip] + "|";
                            ip++;
                        }
                        newlog("Successful item: " + sper);
                        packetper.Add(sper);
                        i += iper;
                    }
                    else
                    {
                        iper = 4;
                        for (int ip = 0; ip < iper; )
                        {
                            newlog("Successful item Reading: " + packetlist[i + ip]);
                            sper += packetlist[i + ip] + "|";
                            ip++;
                        }
                        newlog("Successful item: " + sper);
                        packetper.Add(sper);
                        i += iper;
                    }
                    
                }
                else if (packetlist[i] == "end_dialog")
                {
                    iper = 4;
                    for (int ip = 0; ip < iper; )
                    {
                        newlog("Successful item Reading: " + packetlist[i + ip]);
                        sper += packetlist[i + ip] + "|";
                        ip++;
                    }
                    newlog("Successful item: " + sper);
                    packetper.Add(sper);
                    i += iper;
                }
                else
                {
                    errors.Add(packetlist[i]);
                    newlog("Error item: " + packetlist[i]);
                    i++;
                }
                
            }

            for (int i = 0; i < packetper.Count; i++)
            {
                Complete.Items.Add(i.ToString() + ":" + packetper[i]);
            }

            for (int i = 0; i < errors.Count; i++)
            {
                errorss.Items.Add(i.ToString() + ":" + errors[i]);
            }
            newlog("Everyting Finished.");
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string goods = string.Empty;
            string[] goodlist =
            {
                "1.0: {",
                "2see Templated Done",
                "add_spacebar added",
                "}",
                " ",
                "1.1: {",
                "2page2 template added",
                "all dialog contents added",
                "}"
            };
            foreach (string a in goodlist)
            {
                goods += a + Environment.NewLine;
            }
            MessageBox.Show(goods, "Version 1.1");
        }

        private void Page2_Click(object sender, EventArgs e)
        {
            _2page2 p2 = new _2page2(packetper);
            DialogResult dresult = MessageBox.Show("Do you want to open 2page2(BETA)?", "GTDialog", MessageBoxButtons.YesNoCancel);
            if (dresult == DialogResult.Yes)
            {
                p2.Show();
            }
            else if (dresult == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }
    }
}
