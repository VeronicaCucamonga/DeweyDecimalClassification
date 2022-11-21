using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalClassification
{
    //----------CODE ATTRIBUTION----------
    //Name: Modern Flat UI, Random MultiColor, Highlight button-Active Form, WinForm, C#, V-0.1
    //Publisher: RJ Code Advance EN
    //Date: 13 December 2019
    //URL: https://youtu.be/BtOEztT1Qzk
    //This code handles the home page form
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //select different color themes from class
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string colors = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(colors);
        }

        //method activate button when clicked
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        //method disable button when another button is clicked
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        //open up the childforms method
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(childForm);
            this.panelDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnReplace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReplaceBooks(), sender);
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IdentifyAreas(), sender);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FindingCallNo(), sender);
        }
    }
    //----------CODE ATTRIBUTION ENDS----------
}
