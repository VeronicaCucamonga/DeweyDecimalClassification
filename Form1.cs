﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replaceBooks_Click(object sender, EventArgs e)
        {
            Hide();
            ReplaceBooks rb = new ReplaceBooks();
            rb.ShowDialog();
            Close();
        }

    }
}