using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForm
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void laApellido_Click(object sender, EventArgs e)
        {

        }

        private void tBDirección_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rBMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBIndefinido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBCshard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBJavascript_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string nombre = tBNombre.Text.Trim();
            string direccion = tBDirección.Text.Trim();
            int edad = (int)numericUpDownEdad.Value;
            string genero = "";
            if (rBMasculino.Checked) genero = rBMasculino.Text.Trim();
            if (rBFemenino.Checked) genero = rBFemenino.Text.Trim();
            if (rBIndefinido.Checked) genero = rBFemenino.Text.Trim();

            string chk1 = (cBCshard.Checked) ? cBCshard.Text.Trim() : "";
            string chk2 = (cBCmasmas.Checked) ? cBCmasmas.Text.Trim() : "";
            string chk3 = (cBJavascript.Checked) ? cBJavascript.Text.Trim() : "";

            if (chk1 != "" || chk2 != "" || chk3 != "")
            {
                string[] curso = new string[3] {chk1, chk2, chk3};
            }
            else MessageBox.Show("Selecione una opcion de curso");

            laPaís.Text.Trim();
        }
    }
}
