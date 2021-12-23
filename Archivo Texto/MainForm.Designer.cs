/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 05/10/2020
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Archivo_Texto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApaterno;
		private System.Windows.Forms.TextBox txtAmaterno;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.ComboBox cmbGenero;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.MaskedTextBox txtTelefono;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnFin;
		private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView dtgvRegistros;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apaterno_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amaterno_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Genero_Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Column;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.MaskedTextBox mtbID;
		private System.Windows.Forms.Button btnTerminado;
		private System.Windows.Forms.TextBox txtPunteroHash;
		private System.Windows.Forms.Label lblPuntero;
		private System.Windows.Forms.Button btnDesbloquearID;
		//private System.Windows.Forms.RichTextBox rtb1;
		private System.Windows.Forms.Button btnOrdenamiento;
		private System.Windows.Forms.Button btnTodos;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnBusBin;
		//private System.Windows.Forms.Button btnTodos;
		//private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>{
		private void InitializeComponent(){
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApaterno = new System.Windows.Forms.TextBox();
			this.txtAmaterno = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnFin = new System.Windows.Forms.Button();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dtgvRegistros = new System.Windows.Forms.DataGridView();
			this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apaterno_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amaterno_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Genero_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.mtbID = new System.Windows.Forms.MaskedTextBox();
			this.btnTerminado = new System.Windows.Forms.Button();
			this.txtPunteroHash = new System.Windows.Forms.TextBox();
			this.lblPuntero = new System.Windows.Forms.Label();
			this.btnDesbloquearID = new System.Windows.Forms.Button();
			this.btnOrdenamiento = new System.Windows.Forms.Button();
			this.btnTodos = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnBusBin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgvRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "A. Paterno";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "A. Materno";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(31, 279);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Direccion";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(30, 350);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Genero";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(31, 395);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefono";
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(137, 85);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(80, 20);
			this.txtId.TabIndex = 7;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Location = new System.Drawing.Point(137, 129);
			this.txtNombre.MaxLength = 30;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(190, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// txtApaterno
			// 
			this.txtApaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApaterno.Location = new System.Drawing.Point(137, 178);
			this.txtApaterno.MaxLength = 30;
			this.txtApaterno.Name = "txtApaterno";
			this.txtApaterno.Size = new System.Drawing.Size(190, 20);
			this.txtApaterno.TabIndex = 9;
			// 
			// txtAmaterno
			// 
			this.txtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAmaterno.Location = new System.Drawing.Point(137, 229);
			this.txtAmaterno.MaxLength = 30;
			this.txtAmaterno.Name = "txtAmaterno";
			this.txtAmaterno.Size = new System.Drawing.Size(190, 20);
			this.txtAmaterno.TabIndex = 10;
			// 
			// txtDireccion
			// 
			this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDireccion.Location = new System.Drawing.Point(137, 276);
			this.txtDireccion.MaxLength = 50;
			this.txtDireccion.Multiline = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(190, 55);
			this.txtDireccion.TabIndex = 11;
			// 
			// cmbGenero
			// 
			this.cmbGenero.FormattingEnabled = true;
			this.cmbGenero.Items.AddRange(new object[] {
			"F",
			"M"});
			this.cmbGenero.Location = new System.Drawing.Point(137, 351);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(99, 21);
			this.cmbGenero.TabIndex = 14;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnAgregar.Location = new System.Drawing.Point(143, 447);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(84, 46);
			this.btnAgregar.TabIndex = 15;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(37, 447);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 46);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Limpiar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(137, 398);
			this.txtTelefono.Mask = "0000000000";
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(80, 20);
			this.txtTelefono.TabIndex = 18;
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnModificar.Enabled = false;
			this.btnModificar.Location = new System.Drawing.Point(945, 72);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(82, 39);
			this.btnModificar.TabIndex = 22;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(857, 72);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(82, 39);
			this.btnEliminar.TabIndex = 23;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Enabled = false;
			this.btnAnterior.Location = new System.Drawing.Point(479, 451);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(82, 39);
			this.btnAnterior.TabIndex = 24;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.BtnAnteriorClick);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Enabled = false;
			this.btnSiguiente.Location = new System.Drawing.Point(579, 451);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(82, 39);
			this.btnSiguiente.TabIndex = 25;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguienteClick);
			// 
			// btnFin
			// 
			this.btnFin.Location = new System.Drawing.Point(680, 451);
			this.btnFin.Name = "btnFin";
			this.btnFin.Size = new System.Drawing.Size(82, 39);
			this.btnFin.TabIndex = 26;
			this.btnFin.Text = "> |";
			this.btnFin.UseVisualStyleBackColor = true;
			this.btnFin.Click += new System.EventHandler(this.BtnFinClick);
			// 
			// btnInicio
			// 
			this.btnInicio.Location = new System.Drawing.Point(377, 451);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(82, 39);
			this.btnInicio.TabIndex = 27;
			this.btnInicio.Text = "| <";
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.BtnInicioClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(523, 83);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(69, 23);
			this.btnBuscar.TabIndex = 28;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// dtgvRegistros
			// 
			this.dtgvRegistros.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dtgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvRegistros.ColumnHeadersHeight = 26;
			this.dtgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID_Column,
			this.Nombre_Column,
			this.Apaterno_Column,
			this.Amaterno_column,
			this.Direccion_Column,
			this.Genero_Column,
			this.Telefono_Column});
			this.dtgvRegistros.Location = new System.Drawing.Point(377, 129);
			this.dtgvRegistros.Name = "dtgvRegistros";
			this.dtgvRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dtgvRegistros.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dtgvRegistros.Size = new System.Drawing.Size(674, 312);
			this.dtgvRegistros.TabIndex = 29;
			// 
			// ID_Column
			// 
			this.ID_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID_Column.DataPropertyName = "dtgvID";
			this.ID_Column.HeaderText = "ID";
			this.ID_Column.Name = "ID_Column";
			this.ID_Column.ReadOnly = true;
			this.ID_Column.Width = 45;
			// 
			// Nombre_Column
			// 
			this.Nombre_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Nombre_Column.HeaderText = "Nombre";
			this.Nombre_Column.Name = "Nombre_Column";
			this.Nombre_Column.ReadOnly = true;
			this.Nombre_Column.Width = 75;
			// 
			// Apaterno_Column
			// 
			this.Apaterno_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.NullValue = null;
			this.Apaterno_Column.DefaultCellStyle = dataGridViewCellStyle3;
			this.Apaterno_Column.HeaderText = "Apellido Paterno";
			this.Apaterno_Column.Name = "Apaterno_Column";
			this.Apaterno_Column.ReadOnly = true;
			this.Apaterno_Column.Width = 125;
			// 
			// Amaterno_column
			// 
			this.Amaterno_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Amaterno_column.HeaderText = "Apellido Materno";
			this.Amaterno_column.Name = "Amaterno_column";
			this.Amaterno_column.ReadOnly = true;
			this.Amaterno_column.Width = 127;
			// 
			// Direccion_Column
			// 
			this.Direccion_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Direccion_Column.HeaderText = "Direccion";
			this.Direccion_Column.Name = "Direccion_Column";
			this.Direccion_Column.ReadOnly = true;
			this.Direccion_Column.Width = 86;
			// 
			// Genero_Column
			// 
			this.Genero_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Genero_Column.HeaderText = "Genero";
			this.Genero_Column.Name = "Genero_Column";
			this.Genero_Column.ReadOnly = true;
			this.Genero_Column.Width = 73;
			// 
			// Telefono_Column
			// 
			this.Telefono_Column.HeaderText = "Telefono";
			this.Telefono_Column.Name = "Telefono_Column";
			this.Telefono_Column.ReadOnly = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(612, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(260, 28);
			this.label8.TabIndex = 31;
			this.label8.Text = "MOSTRAR REGISTROS";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(398, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 23);
			this.label9.TabIndex = 32;
			this.label9.Text = "ID:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(50, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(240, 44);
			this.label10.TabIndex = 33;
			this.label10.Text = "ALTA REGISTRO";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(899, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(116, 15);
			this.label11.TabIndex = 34;
			this.label11.Text = "¿Que desea hacer?";
			// 
			// mtbID
			// 
			this.mtbID.Location = new System.Drawing.Point(445, 83);
			this.mtbID.Mask = "999999999";
			this.mtbID.Name = "mtbID";
			this.mtbID.Size = new System.Drawing.Size(63, 20);
			this.mtbID.TabIndex = 35;
			// 
			// btnTerminado
			// 
			this.btnTerminado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnTerminado.Enabled = false;
			this.btnTerminado.Location = new System.Drawing.Point(243, 447);
			this.btnTerminado.Name = "btnTerminado";
			this.btnTerminado.Size = new System.Drawing.Size(84, 43);
			this.btnTerminado.TabIndex = 36;
			this.btnTerminado.Text = "Terminado";
			this.btnTerminado.UseVisualStyleBackColor = false;
			this.btnTerminado.Visible = false;
			this.btnTerminado.Click += new System.EventHandler(this.BtnTerminadoClick);
			// 
			// txtPunteroHash
			// 
			this.txtPunteroHash.Enabled = false;
			this.txtPunteroHash.Location = new System.Drawing.Point(720, 83);
			this.txtPunteroHash.Name = "txtPunteroHash";
			this.txtPunteroHash.ReadOnly = true;
			this.txtPunteroHash.Size = new System.Drawing.Size(89, 20);
			this.txtPunteroHash.TabIndex = 37;
			// 
			// lblPuntero
			// 
			this.lblPuntero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuntero.Location = new System.Drawing.Point(632, 82);
			this.lblPuntero.Name = "lblPuntero";
			this.lblPuntero.Size = new System.Drawing.Size(82, 23);
			this.lblPuntero.TabIndex = 38;
			this.lblPuntero.Text = "Puntero: ";
			// 
			// btnDesbloquearID
			// 
			this.btnDesbloquearID.Location = new System.Drawing.Point(236, 83);
			this.btnDesbloquearID.Name = "btnDesbloquearID";
			this.btnDesbloquearID.Size = new System.Drawing.Size(91, 23);
			this.btnDesbloquearID.TabIndex = 39;
			this.btnDesbloquearID.Text = "Desbloquear ID";
			this.btnDesbloquearID.UseVisualStyleBackColor = true;
			this.btnDesbloquearID.Click += new System.EventHandler(this.BtnDesbloquearIDClick);
			// 
			// btnOrdenamiento
			// 
			this.btnOrdenamiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnOrdenamiento.Location = new System.Drawing.Point(962, 449);
			this.btnOrdenamiento.Name = "btnOrdenamiento";
			this.btnOrdenamiento.Size = new System.Drawing.Size(89, 39);
			this.btnOrdenamiento.TabIndex = 41;
			this.btnOrdenamiento.Text = "BURBUJA";
			this.btnOrdenamiento.UseVisualStyleBackColor = false;
			this.btnOrdenamiento.Click += new System.EventHandler(this.BtnOrdenamientoClick);
			// 
			// btnTodos
			// 
			this.btnTodos.Location = new System.Drawing.Point(786, 449);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(170, 39);
			this.btnTodos.TabIndex = 42;
			this.btnTodos.Text = "Mostrar todos los registros";
			this.btnTodos.UseVisualStyleBackColor = true;
			this.btnTodos.Click += new System.EventHandler(this.BtnTodosClick);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(243, 398);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(84, 23);
			this.btnBorrar.TabIndex = 43;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnBusBin
			// 
			this.btnBusBin.Location = new System.Drawing.Point(445, 54);
			this.btnBusBin.Name = "btnBusBin";
			this.btnBusBin.Size = new System.Drawing.Size(147, 23);
			this.btnBusBin.TabIndex = 44;
			this.btnBusBin.Text = "Busqueda Binaria";
			this.btnBusBin.UseVisualStyleBackColor = true;
			this.btnBusBin.Click += new System.EventHandler(this.BtnBusBinClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 519);
			this.Controls.Add(this.btnBusBin);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnTodos);
			this.Controls.Add(this.btnOrdenamiento);
			this.Controls.Add(this.btnDesbloquearID);
			this.Controls.Add(this.lblPuntero);
			this.Controls.Add(this.txtPunteroHash);
			this.Controls.Add(this.btnTerminado);
			this.Controls.Add(this.mtbID);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtgvRegistros);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnInicio);
			this.Controls.Add(this.btnFin);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.cmbGenero);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtAmaterno);
			this.Controls.Add(this.txtApaterno);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Archivo Texto";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtgvRegistros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		//}
		//}
	}
}
