﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Grondstof> stockGrondstof = new List<Grondstof>();
        List<ChocoladeBatch> stockChocolade = new List<ChocoladeBatch>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}