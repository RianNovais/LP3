﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicios3
{
    public partial class formMultiplos : Form
    {
        public formMultiplos()
        {
            InitializeComponent();
        }

        private void buttonMostrarMultiplos_Click(object sender, EventArgs e){
            FormMostrarMut formMostrar = new FormMostrarMut();
            formMostrar.Show();

        }
    }
}