﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmHolaMundo : Form
    {
        public frmHolaMundo()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Piensa, sueña, cree y atrévete");
        }
    }
}
