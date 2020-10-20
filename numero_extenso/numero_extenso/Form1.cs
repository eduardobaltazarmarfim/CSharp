using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numero_extenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txnumero.Text = string.Empty;
            txextenso.Text = string.Empty;
            txnumero.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Escrever por Extenso";
        }
    }
}
