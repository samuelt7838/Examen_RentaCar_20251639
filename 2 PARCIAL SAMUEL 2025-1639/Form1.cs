
using System;
using System.Globalization;
using System.Windows.Forms;

namespace _2_PARCIAL_SAMUEL_2025_1639
{
    public partial class lblItbis : Form
    {
        public lblItbis()
        {
            InitializeComponent();

            // Configuración inicial
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            // Los campos de resultados no se editan manualmente
            txtSubtotal.ReadOnly = true;
            txtDescuento.ReadOnly = true;
            txtDomicilio.ReadOnly = true;
            txtItbis.ReadOnly = true;
            txtTotal.ReadOnly = true;

            // Eventos de los botones
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // AGREGAR ALQUILER
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            string cliente = txtCliente.Text.Trim();
            string vehiculo = txtVehiculo.Text.Trim();

            decimal tarifa = ObtenerTarifa();
            int dias = (int)nudDias.Value;

            string alquiler =
                cliente + " | " +
                vehiculo + " | " +
                dias + " días | " +
                "RD$ " + tarifa.ToString("N2");

            lstAlquileres.Items.Add(alquiler);

            MessageBox.Show(
                "Alquiler agregado correctamente.",
                "RentaCar Express",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // CALCULAR ALQUILER
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            decimal tarifa = ObtenerTarifa();
            int dias = (int)nudDias.Value;

            // Seguro
            decimal seguro = rbtCompleto.Checked ? 300m : 0m;

            // GPS
            decimal gps = chkGps.Checked ? 100m : 0m;

            // Subtotal
            decimal subtotal = (tarifa + seguro + gps) * dias;

            // Descuento corporativo del 15 %
            decimal descuento = chkCorporativo.Checked
                ? subtotal * 0.15m
                : 0m;

            // Entrega a domicilio
            decimal domicilio = rbtDomicilio.Checked ? 500m : 0m;

            // Base imponible
            decimal baseImponible = subtotal - descuento + domicilio;

            // ITBIS del 18 %
            decimal itbis = baseImponible * 0.18m;

            // Total
            decimal total = baseImponible + itbis;

            // Mostrar resultados
            txtSubtotal.Text = subtotal.ToString("N2");
            txtDescuento.Text = descuento.ToString("N2");
            txtDomicilio.Text = domicilio.ToString("N2");
            txtItbis.Text = itbis.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }

        // VALIDAR DATOS
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Escriba el nombre del cliente.");
                txtCliente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
            {
                MessageBox.Show("Escriba el vehículo.");
                txtVehiculo.Focus();
                return false;
            }

            decimal tarifa;

            if (!decimal.TryParse(
                txtTarifa.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out tarifa))
            {
                if (!decimal.TryParse(
                    txtTarifa.Text,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out tarifa))
                {
                    MessageBox.Show("Ingrese una tarifa válida.");
                    txtTarifa.Focus();
                    return false;
                }
            }

            if (tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser mayor que cero.");
                txtTarifa.Focus();
                return false;
            }

            if (nudDias.Value <= 0)
            {
                MessageBox.Show("Seleccione al menos un día de alquiler.");
                nudDias.Focus();
                return false;
            }

            return true;
        }

        private decimal ObtenerTarifa()
        {
            decimal tarifa;

            if (!decimal.TryParse(
                txtTarifa.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out tarifa))
            {
                decimal.TryParse(
                    txtTarifa.Text,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out tarifa);
            }

            return tarifa;
        }

        // LIMPIAR FORMULARIO
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();

            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtDomicilio.Clear();
            txtItbis.Clear();
            txtTotal.Clear();

            nudDias.Value = 0;
            dtpSalida.Value = DateTime.Today;

            chkCorporativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            lstAlquileres.Items.Clear();

            txtCliente.Focus();
        }

        // SALIR DEL PROGRAMA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "RentaCar Express",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Eventos existentes del diseñador
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
