using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Test.DAL;
using 

namespace WinForm_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            try
            {
                user.Nombre = this.TxtBoxUsuario.Text;
                user.FechaIngreso = new DateTime(this.TxtBoxFecha.Text);
            }
            catch { MessageBox.Show("El formato es inválido"); }


        }

        private bool TieneNumeros(string texto)
        {
            string regExp = "[0-9]"

            //Debo verificar que el texto no contenga números
            foreach (char letra in texto)
            {
                if (letra.Equals())
                {

                }


            }


        }


        //private void TxtBoxUsuario_Validating(object sender, EventArgs e)
        //{

        //}
    }
}
