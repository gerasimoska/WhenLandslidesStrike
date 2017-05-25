using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASAapp
{
    public partial class Form1 : Form
    {
        List<Image> img;
        public Objects objects = new Objects();
        public List<RootObject> RootObjects;
        public List<RootObject> added;
        public Functions functions;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            RootObjects = new List<RootObject>();
            added = new List<RootObject>();
            functions = new Functions();
            img = new List<Image>();
            objects = functions.ParseJSON("all");


            player.SoundLocation = "yiruma.wav";
            player.PlayLooping();

            //panelStart.Visible = true;
            //btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
        }

        

        private void btnAbout_Click(object sender, EventArgs e) {

            panelAbout.Visible = true;
            panelStart.Visible = false;
            panelAddNewLocation.Visible = false;
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            listBox2.Items.Clear();
        }

        private void buttonAddNewLocation_Click(object sender, EventArgs e)
        {
            panelAddNewLocation.Visible = true;
            panelStart.Visible = false;
            panelAbout.Visible = false;
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
            panelAddNewLocation.Visible = false;
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelStart.Visible = true;
            panelAbout.Visible = false;
            panelAddNewLocation.Visible = false;
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            textBox2.Text = "";
            listBox2.Items.Clear();
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            string place = textBox2.Text.Trim();
            List<RootObject> list = new List<RootObject>();
            List<RootObject> RootObjects = functions.ParseJSON("all").obj;

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter location! ", "Unsufficient data", MessageBoxButtons.OK);
                return;
            }
            else if (textBox2.Text != "" && textBox2.Text != null)
            {
                timerProgressBar.Start();
                list = functions.ParseJSON(textBox2.Text).obj;
            }

            foreach (RootObject ro in list)
            {
                listBox2.Items.Add(ro.ToString());
            }

        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
        }

        private void buttonAddNewLocation_MouseHover(object sender, EventArgs e)
        {
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Increment(10);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }

        }
    }
}
