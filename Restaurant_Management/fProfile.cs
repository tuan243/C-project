﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Txb_OldPass.Clear();
            Txb_NewPass.Clear();
            Txb_Confirm.Clear();
        }
    }
}
