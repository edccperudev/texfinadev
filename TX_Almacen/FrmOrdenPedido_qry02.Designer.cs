﻿namespace TX_Almacen
{
    partial class FrmOrdenPedido_qry02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenPedido_qry02));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkPendiente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.txtfechaIni = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodOp = new System.Windows.Forms.TextBox();
            this.chkAprobado = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgOrdenPedido = new System.Windows.Forms.DataGridView();
            this.idPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreqsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe_requer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_clipro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_raznombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.29897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.70103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Controls.Add(this.chkPendiente, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFechaFin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtfechaIni, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcliente, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtproducto, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcodOp, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkAprobado, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.89655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.10345F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 58);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // chkPendiente
            // 
            this.chkPendiente.AutoSize = true;
            this.chkPendiente.Checked = true;
            this.chkPendiente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPendiente.Location = new System.Drawing.Point(570, 35);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(72, 18);
            this.chkPendiente.TabIndex = 23;
            this.chkPendiente.Text = "Pendiente";
            this.chkPendiente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio :";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFechaFin.Location = new System.Drawing.Point(78, 35);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 20;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // txtfechaIni
            // 
            this.txtfechaIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtfechaIni.Location = new System.Drawing.Point(78, 3);
            this.txtfechaIni.Mask = "00/00/0000";
            this.txtfechaIni.Name = "txtfechaIni";
            this.txtfechaIni.Size = new System.Drawing.Size(88, 20);
            this.txtfechaIni.TabIndex = 19;
            this.txtfechaIni.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin: :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Producto :";
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtcliente.Location = new System.Drawing.Point(274, 3);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(191, 20);
            this.txtcliente.TabIndex = 1;
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcliente_KeyPress);
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtproducto.Location = new System.Drawing.Point(570, 3);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(234, 20);
            this.txtproducto.TabIndex = 2;
            this.txtproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproducto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código OPedido :";
            // 
            // txtcodOp
            // 
            this.txtcodOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtcodOp.Location = new System.Drawing.Point(274, 35);
            this.txtcodOp.Name = "txtcodOp";
            this.txtcodOp.Size = new System.Drawing.Size(191, 20);
            this.txtcodOp.TabIndex = 3;
            this.txtcodOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodOp_KeyPress);
            // 
            // chkAprobado
            // 
            this.chkAprobado.AutoSize = true;
            this.chkAprobado.Checked = true;
            this.chkAprobado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAprobado.Location = new System.Drawing.Point(484, 35);
            this.chkAprobado.Name = "chkAprobado";
            this.chkAprobado.Size = new System.Drawing.Size(71, 18);
            this.chkAprobado.TabIndex = 21;
            this.chkAprobado.Text = "Aprobado";
            this.chkAprobado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(813, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 26);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 531);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgOrdenPedido);
            this.groupBox3.Location = new System.Drawing.Point(0, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1046, 439);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // dgOrdenPedido
            // 
            this.dgOrdenPedido.AllowUserToAddRows = false;
            this.dgOrdenPedido.AllowUserToOrderColumns = true;
            this.dgOrdenPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOrdenPedido.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgOrdenPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrdenPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrdenPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeriodo,
            this.idreqsalida,
            this.fe_requer,
            this.st_estado,
            this.Autorizado,
            this.Aprobado,
            this.id_Vendedor,
            this.ds_Vendedor,
            this.id_producto,
            this.ds_producto,
            this.id_color,
            this.ds_color,
            this.Rollo,
            this.id_clipro,
            this.ds_raznombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrdenPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrdenPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrdenPedido.Location = new System.Drawing.Point(3, 16);
            this.dgOrdenPedido.Name = "dgOrdenPedido";
            this.dgOrdenPedido.RowHeadersVisible = false;
            this.dgOrdenPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrdenPedido.Size = new System.Drawing.Size(1040, 420);
            this.dgOrdenPedido.TabIndex = 5;
            // 
            // idPeriodo
            // 
            this.idPeriodo.DataPropertyName = "idPeriodo";
            this.idPeriodo.HeaderText = "Periodo";
            this.idPeriodo.Name = "idPeriodo";
            this.idPeriodo.Width = 72;
            // 
            // idreqsalida
            // 
            this.idreqsalida.DataPropertyName = "idreqsalida";
            this.idreqsalida.HeaderText = "Req.Salida";
            this.idreqsalida.Name = "idreqsalida";
            this.idreqsalida.ReadOnly = true;
            this.idreqsalida.Width = 88;
            // 
            // fe_requer
            // 
            this.fe_requer.DataPropertyName = "fe_requer";
            this.fe_requer.HeaderText = "Fecha";
            this.fe_requer.Name = "fe_requer";
            this.fe_requer.ReadOnly = true;
            this.fe_requer.Width = 62;
            // 
            // st_estado
            // 
            this.st_estado.DataPropertyName = "st_estado";
            this.st_estado.HeaderText = "Estado";
            this.st_estado.Name = "st_estado";
            this.st_estado.ReadOnly = true;
            this.st_estado.Width = 65;
            // 
            // Autorizado
            // 
            this.Autorizado.DataPropertyName = "Autorizado";
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.Name = "Autorizado";
            this.Autorizado.ReadOnly = true;
            this.Autorizado.Width = 90;
            // 
            // Aprobado
            // 
            this.Aprobado.DataPropertyName = "Aprobado";
            this.Aprobado.HeaderText = "Aprobado";
            this.Aprobado.Name = "Aprobado";
            this.Aprobado.ReadOnly = true;
            this.Aprobado.Width = 81;
            // 
            // id_Vendedor
            // 
            this.id_Vendedor.DataPropertyName = "id_Vendedor";
            this.id_Vendedor.HeaderText = "id_Vendedor";
            this.id_Vendedor.Name = "id_Vendedor";
            this.id_Vendedor.Visible = false;
            this.id_Vendedor.Width = 97;
            // 
            // ds_Vendedor
            // 
            this.ds_Vendedor.DataPropertyName = "ds_Vendedor";
            this.ds_Vendedor.HeaderText = "Vendedor";
            this.ds_Vendedor.Name = "ds_Vendedor";
            this.ds_Vendedor.Width = 81;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 93;
            // 
            // ds_producto
            // 
            this.ds_producto.DataPropertyName = "ds_producto";
            this.ds_producto.HeaderText = "Producto";
            this.ds_producto.Name = "ds_producto";
            this.ds_producto.ReadOnly = true;
            this.ds_producto.Width = 78;
            // 
            // id_color
            // 
            this.id_color.DataPropertyName = "id_color";
            this.id_color.HeaderText = "id_color";
            this.id_color.Name = "id_color";
            this.id_color.ReadOnly = true;
            this.id_color.Visible = false;
            this.id_color.Width = 74;
            // 
            // ds_color
            // 
            this.ds_color.DataPropertyName = "ds_color";
            this.ds_color.HeaderText = "Color";
            this.ds_color.Name = "ds_color";
            this.ds_color.ReadOnly = true;
            this.ds_color.Width = 62;
            // 
            // Rollo
            // 
            this.Rollo.DataPropertyName = "Rollo";
            this.Rollo.HeaderText = "Rollo";
            this.Rollo.Name = "Rollo";
            this.Rollo.Width = 60;
            // 
            // id_clipro
            // 
            this.id_clipro.DataPropertyName = "id_clipro";
            this.id_clipro.HeaderText = "id_clipro";
            this.id_clipro.Name = "id_clipro";
            this.id_clipro.ReadOnly = true;
            this.id_clipro.Visible = false;
            this.id_clipro.Width = 78;
            // 
            // ds_raznombre
            // 
            this.ds_raznombre.DataPropertyName = "ds_raznombre";
            this.ds_raznombre.HeaderText = "Cliente";
            this.ds_raznombre.Name = "ds_raznombre";
            this.ds_raznombre.ReadOnly = true;
            this.ds_raznombre.Width = 72;
            // 
            // FrmOrdenPedido_qry02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenPedido_qry02";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmOrdenPedido_qry02_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodOp;
        private System.Windows.Forms.MaskedTextBox txtfechaIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.CheckBox chkAprobado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgOrdenPedido;
        private System.Windows.Forms.CheckBox chkPendiente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreqsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe_requer;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clipro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_raznombre;
    }
}