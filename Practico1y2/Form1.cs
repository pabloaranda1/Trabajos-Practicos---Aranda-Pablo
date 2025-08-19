using System;
using System.Windows.Forms;

namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TDni.KeyPress += TDni_KeyPress;
            TApellido.KeyPress += TApellido_KeyPress;
            TNombre.KeyPress += TNombre_KeyPress;
            TGuardar.Click += TGuardar_Click;
            TEliminar.Click += TEliminar_Click; // Asocia el evento al botón Eliminar
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text))
            {
                ask = MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ask = MessageBox.Show(
                "Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Insercion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (ask == DialogResult.Yes)
            {
                LModificar.Text = TApellido.Text;
                string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
                MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = $"{TNombre.Text} {TApellido.Text}";
            DialogResult ask = MessageBox.Show(
                $"Está apunto de eliminar el Cliente: {nombreCompleto}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2 // El foco por defecto está en "NO"
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show($"El Cliente: {nombreCompleto} se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = string.Empty;
            }
            // Si se presiona "No", no sucede nada
        }
    }
}
