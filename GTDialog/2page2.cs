using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTDialog
{
    public partial class _2page2 : Form
    {
        private List<string> packetlist = new List<string>();
        public _2page2(List<string> packetdatainput)
        {
            InitializeComponent();
            packetlist = packetdatainput;
        }

        /* this.pictureBox1.Image = global::GTDialog.Properties.Resources.first;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
         */

        private void createpicture(int i)
        {
            PictureBox p = new PictureBox();
            #region image

            if (i == 0)
            {
                p.Image = Properties.Resources.first;
            }
            else if (i == packetlist.Count)
            {
                p.Image = Properties.Resources.finish;
            }
            else
            {
                p.Image = Properties.Resources.mid;
            }
            #endregion image
            #region locateion
            p.Location = new Point(12, i * 50+ 12);
            #endregion location
            #region Size
            p.Size = new System.Drawing.Size(472, 50);
            #endregion Size
            #region SizeMode
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            #endregion SizeMode
            this.Controls.Add(p);
        }

        private void createpicturewlabel(int i, string label)
        {
            createpicture(i);

            Label l = new Label();
            #region name
            l.Name = label;
            l.Text = label;
            #endregion name
            #region Size
            l.Size = new System.Drawing.Size(36, 13);
            l.AutoSize = true;
            #endregion Size
            #region locateion
            l.Location = new Point(24, i * 25 + 12);
            #endregion location
            l.BringToFront();
            this.Controls.Add(l);
        }

        private void _2page2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(512, packetlist.Count * 50 + 50 + 12);

            for (int i = 0; i < packetlist.Count;)
            {
                string[] currentpacket = packetlist[i].Split('|');
                int iper = 0;
                if (currentpacket[0] == "add_spacer")
                {
                    iper = 2;
                    if (currentpacket[1] == "small")
                    {
                        createpicture(i);
                    }
                    else //big
                    {
                        createpicture(i);
                        createpicture(i + 1);
                    }
                    i += iper;
                }
                else if (currentpacket[0] == "add_achieve")
                {
                    iper = 5;
                    i += iper;
                }
                else if (currentpacket[0] == "add_button")
                {
                    iper = 3;
                    i += iper;
                }
                else if (currentpacket[0] == "add_button")
                {
                    iper = 3;
                    i += iper;
                }
                else if (currentpacket[0] == "add_checkbox")
                {
                    iper = 4;
                    i += iper;
                }
                else if (currentpacket[0] == "add_image_button")
                {
                    iper = 7;
                    i += iper;
                }
                else if (currentpacket[0] == "add_item_picker")
                {
                    iper = 4;
                    i += iper;

                }
                else if (currentpacket[0] == "add_label")
                {
                    iper = 2;
                    i += iper;
                }
                else if (currentpacket[0] == "add_label_with_icon")
                {
                    iper = 5;
                    i += iper;
                }
                else if (currentpacket[0] == "add_player_info")
                {
                    iper = 5;
                    i += iper;
                }
                else if (currentpacket[0] == "add_quick_exit")
                {
                    iper = 1;
                    i += iper;

                }
                else if (currentpacket[0] == "add_slot")
                {
                    iper = 1;
                    i += iper;
                }
                else if (currentpacket[0] == "add_smalltext")
                {
                    iper = 3;
                    i += iper;
                }
                else if (currentpacket[0] == "add_smalltext_forced")
                {
                    iper = 3;
                    i += iper;
                }
                else if (currentpacket[0] == "add_smalltext_forced_alpha")
                {
                    iper = 4;
                    i += iper;
                }
                else if (currentpacket[0] == "add_text_input")
                {
                    iper = 5;
                    i += iper;
                }
                else if (currentpacket[0] == "add_text_input_password")
                {
                    iper = 5;
                    i += iper;
                }
                else if (currentpacket[0] == "add_textbox")
                {
                    iper = 2;
                    createpicturewlabel(i, currentpacket[1]);
                    i += iper;
                }
                else if (currentpacket[0] == "add_url_button")
                {
                    if (packetlist[i + 3] == "NOFLAGS")
                    {
                        iper = 6;
                        i += iper;
                    }
                    else
                    {
                        iper = 4;
                        i += iper;
                    }

                }
                else if (currentpacket[0] == "end_dialog")
                {
                    iper = 4;
                    i += iper;
                }
                else
                {

                }
            }
        }
    }
}
