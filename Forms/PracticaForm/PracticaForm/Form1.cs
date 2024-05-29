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
            string cuit = makTextBoxCuit.Text.Trim();

            string genero = "";
            if (rBMasculino.Checked) genero = rBMasculino.Text.Trim();
            if (rBFemenino.Checked) genero = rBFemenino.Text.Trim();
            if (rBIndefinido.Checked) genero = rBFemenino.Text.Trim();

            string chk1 = (cBCshard.Checked) ? cBCshard.Text.Trim() : "";
            string chk2 = (cBCmasmas.Checked) ? cBCmasmas.Text.Trim() : "";
            string chk3 = (cBJavascript.Checked) ? cBJavascript.Text.Trim() : "";

            string[] curso = new string[3];
            if (chk1 != "" || chk2 != "" || chk3 != "")
            {
                curso[0] = chk1;
                curso[1] = chk2;
                curso[2] = chk3;
            }
            else MessageBox.Show("Selecione una opcion de curso");

            string pais = laPaís.Text.Trim();

            var ingresante = new Ingresante(nombre, genero, direccion, edad, pais, curso, cuit);
            ingresante.ToString();
            if (MessageBox.Show(ingresante.ToString(),"Datos Ingresante", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (MessageBox.Show(ingresante.ToStringCursos(),"Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK){
                    MessageBox.Show("Datos guardados");
                    this.Vaciar();
                }
                else
                {
                    MessageBox.Show("Verificar los datos e intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Datos descartados");
                this.Vaciar();
            }
        }

        public void Vaciar()
        {
            tBNombre.Text = "";
            tBDirección.Text = "";
            numericUpDownEdad.Value = 18;
            makTextBoxCuit.Text = "";
            rBMasculino.Checked = false;
            rBFemenino.Checked = false;
            rBIndefinido.Checked = false;
            cBCshard.Checked = false;
            cBCmasmas.Checked = false;
            cBJavascript.Checked = false;
            laPaís.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
