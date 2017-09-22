﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
            this.Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
    }
}
