using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerUnico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger log1 = Logger.GetInstancia();
            Logger log2 = Logger.GetInstancia();

            log1.Log("chamoy@");
            log2.Log("Mensaje 2");


            bool sonIguales = log1 == log2;
            string mensaje = sonIguales ? "Son iguales" : "No son iguales";
            MessageBox.Show(mensaje);

        }

    }
}
