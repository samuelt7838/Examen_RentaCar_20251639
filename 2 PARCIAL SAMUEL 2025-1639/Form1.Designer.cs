namespace _2_PARCIAL_SAMUEL_2025_1639
{
    partial class lblItbis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCliente = new Label();
            lblSalida = new Label();
            lblVehiculo = new Label();
            lblTarifa = new Label();
            lblDias = new Label();
            chkGps = new CheckBox();
            dtpSalida = new DateTimePicker();
            grpSeguro = new GroupBox();
            grpEntrega = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            rbtBasico = new RadioButton();
            rbtCompleto = new RadioButton();
            rbtSucursal = new RadioButton();
            rbtDomicilio = new RadioButton();
            txtCliente = new TextBox();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            btnAgregar = new Button();
            this.lblTituloDescuento = new Label();
            this.lblTituloDomicilio = new Label();
            this.lblTituloItbis = new Label();
            lblTituloTotal = new Label();
            this.txtTotal = new TextBox();
            this.txtItbis = new TextBox();
            txtDomicilio = new TextBox();
            txtDescuento = new TextBox();
            txtSubtotal = new TextBox();
            nudDias = new NumericUpDown();
            chkCorporativo = new CheckBox();
            lstAlquileres = new ListBox();
            lblTituloSubtotal = new Label();
            grpSeguro.SuspendLayout();
            grpEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(22, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(22, 111);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(53, 20);
            lblSalida.TabIndex = 1;
            lblSalida.Text = "Salida:";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(22, 183);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(68, 20);
            lblVehiculo.TabIndex = 2;
            lblVehiculo.Text = "Vehículo:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(22, 249);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(48, 20);
            lblTarifa.TabIndex = 3;
            lblTarifa.Text = "Tarifa:";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(22, 330);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(41, 20);
            lblDias.TabIndex = 4;
            lblDias.Text = "Días:";
            lblDias.Click += label5_Click;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(22, 534);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 5;
            chkGps.Text = "GPS (+RD$100 por día)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(93, 111);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 6;
            // 
            // grpSeguro
            // 
            grpSeguro.Controls.Add(rbtCompleto);
            grpSeguro.Controls.Add(rbtBasico);
            grpSeguro.Location = new Point(22, 403);
            grpSeguro.Name = "grpSeguro";
            grpSeguro.Size = new Size(250, 125);
            grpSeguro.TabIndex = 7;
            grpSeguro.TabStop = false;
            grpSeguro.Text = "Seguro";
            // 
            // grpEntrega
            // 
            grpEntrega.Controls.Add(rbtDomicilio);
            grpEntrega.Controls.Add(rbtSucursal);
            grpEntrega.Location = new Point(296, 403);
            grpEntrega.Name = "grpEntrega";
            grpEntrega.Size = new Size(250, 125);
            grpEntrega.TabIndex = 8;
            grpEntrega.TabStop = false;
            grpEntrega.Text = "Entrega";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 610);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(162, 68);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(200, 610);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(162, 68);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(402, 610);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 68);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(31, 36);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 0;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Básico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(31, 75);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(172, 24);
            rbtCompleto.TabIndex = 1;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(30, 36);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 24);
            rbtSucursal.TabIndex = 1;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(30, 75);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(171, 24);
            rbtDomicilio.TabIndex = 2;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(93, 9);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(250, 27);
            txtCliente.TabIndex = 12;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(93, 183);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(250, 27);
            txtVehiculo.TabIndex = 13;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(93, 249);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(250, 27);
            txtTarifa.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(537, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(341, 68);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button4_Click;
            // 
            // lblTituloDescuento
            // 
            this.lblTituloDescuento.AutoSize = true;
            this.lblTituloDescuento.Location = new Point(603, 396);
            this.lblTituloDescuento.Name = "lblTituloDescuento";
            this.lblTituloDescuento.Size = new Size(82, 20);
            this.lblTituloDescuento.TabIndex = 19;
            this.lblTituloDescuento.Text = "Descuento:";
            // 
            // lblTituloDomicilio
            // 
            this.lblTituloDomicilio.AutoSize = true;
            this.lblTituloDomicilio.Location = new Point(608, 460);
            this.lblTituloDomicilio.Name = "lblTituloDomicilio";
            this.lblTituloDomicilio.Size = new Size(77, 20);
            this.lblTituloDomicilio.TabIndex = 20;
            this.lblTituloDomicilio.Text = "Domicilio:";
            // 
            // lblTituloItbis
            // 
            this.lblTituloItbis.AutoSize = true;
            this.lblTituloItbis.Location = new Point(589, 521);
            this.lblTituloItbis.Name = "lblTituloItbis";
            this.lblTituloItbis.Size = new Size(87, 20);
            this.lblTituloItbis.TabIndex = 21;
            this.lblTituloItbis.Text = "ITBIS (18%):";
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Location = new Point(729, 610);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(53, 20);
            lblTituloTotal.TabIndex = 22;
            lblTituloTotal.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new Point(793, 600);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new Size(165, 27);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += this.textBox5_TextChanged;
            // 
            // txtItbis
            // 
            this.txtItbis.Location = new Point(686, 518);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new Size(250, 27);
            this.txtItbis.TabIndex = 24;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(686, 460);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(250, 27);
            txtDomicilio.TabIndex = 25;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(686, 396);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(250, 27);
            txtDescuento.TabIndex = 26;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(686, 347);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(250, 27);
            txtSubtotal.TabIndex = 27;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(94, 331);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(250, 27);
            nudDias.TabIndex = 28;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(94, 55);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(158, 24);
            chkCorporativo.TabIndex = 29;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(538, 125);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(300, 144);
            lstAlquileres.TabIndex = 30;
            // 
            // lblTituloSubtotal
            // 
            lblTituloSubtotal.AutoSize = true;
            lblTituloSubtotal.Location = new Point(608, 347);
            lblTituloSubtotal.Name = "lblTituloSubtotal";
            lblTituloSubtotal.Size = new Size(68, 20);
            lblTituloSubtotal.TabIndex = 18;
            lblTituloSubtotal.Text = "Subtotal:";
            // 
            // lblItbis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1044, 744);
            Controls.Add(lstAlquileres);
            Controls.Add(chkCorporativo);
            Controls.Add(nudDias);
            Controls.Add(txtSubtotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtDomicilio);
            Controls.Add(this.txtItbis);
            Controls.Add(this.txtTotal);
            Controls.Add(lblTituloTotal);
            Controls.Add(this.lblTituloItbis);
            Controls.Add(this.lblTituloDomicilio);
            Controls.Add(this.lblTituloDescuento);
            Controls.Add(lblTituloSubtotal);
            Controls.Add(btnAgregar);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(txtCliente);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpEntrega);
            Controls.Add(grpSeguro);
            Controls.Add(dtpSalida);
            Controls.Add(chkGps);
            Controls.Add(lblDias);
            Controls.Add(lblTarifa);
            Controls.Add(lblVehiculo);
            Controls.Add(lblSalida);
            Controls.Add(lblCliente);
            ForeColor = Color.BurlyWood;
            Name = "lblItbis";
            Text = "Rentacar Express-Alquileres";
            grpSeguro.ResumeLayout(false);
            grpSeguro.PerformLayout();
            grpEntrega.ResumeLayout(false);
            grpEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblSalida;
        private Label lblVehiculo;
        private Label lblTarifa;
        private Label lblDias;
        private CheckBox chkGps;
        private DateTimePicker dtpSalida;
        private GroupBox grpSeguro;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private GroupBox grpEntrega;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtCliente;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private Button btnAgregar;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label label9;
        private Label lblTituloTotal;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtDomicilio;
        private TextBox txtDescuento;
        private TextBox txtSubtotal;
        private NumericUpDown nudDias;
        private CheckBox chkCorporativo;
        private ListBox lstAlquileres;
        private Label lblTituloSubtotal;
        private Label lblTituloDescuento;
        private Label lblTituloDomicilio;
        private Label lblTituloItbis;
        private TextBox txtTotal;
        private TextBox txtItbis;
    }
}
