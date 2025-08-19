using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace Practico2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TDni_Validated(object sender, EventArgs e)
        {
            int dni;
            // Suponiendo que TDni es un TextBox
            if (int.TryParse(TDni.Text, out dni))
            {
                return;
            }
            MessageBox.Show("El DNI debe ser un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TApellido_Validated(object sender, EventArgs e)
        {
            if (!TApellido.Text.All(char.IsLetter))
            {
                MessageBox.Show("El apellido solo debe contener letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TNombre_Validated(object sender, EventArgs e)
        {
            if (!TNombre.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LModificar.Text = TApellido.Text;
                MsgBoxResult ask;
                ask = (MsgBoxResult)MessageBox.Show("¿Desea guardar un nuevo cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == MsgBoxResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = (MsgBoxResult)MessageBox.Show("Esta a punto de eliminar un cliente: " + TNombre.Text + " " + TApellido.Text, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (ask == MsgBoxResult.Yes)
            {
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                MessageBox.Show("El Cliente:" + TNombre.Text + " " + TApellido.Text + " se elimino correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Captura1;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Captura2;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
