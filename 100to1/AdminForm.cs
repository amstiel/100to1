﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100to1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            ViewForm vf = new ViewForm();
            vf.Show();
        }
    }
}
