/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 05/10/2020
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Archivo_Texto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm(){
			InitializeComponent();	
			MuestraID();
		}
		
		int ubicacion = 0;
		int idFijo;		
		string ptrModificar;
		long TamanoArchivo;
		const long tamanoRegistro = 193;		
		bool RegistroLleno = false;
		bool Profesor = false;
		Alumno oAlumno;
		AlumnoHash oAH = new AlumnoHash();
		Pruebas oPruebas;
		Hashtable oHT = new Hashtable();
		
		void MuestraID(){
			if(!Profesor){
				if(File.Exists("Alumno.dat")){
					oAlumno = new Alumno();	
					TamanoArchivo = oAlumno.GetTamanoArchivo();	
					idFijo = oAlumno.BuscaMayorID() + 1;
					if(!RegistroLleno) CargaRegistrosHash();					
				}else{
					idFijo = 1;
				}
				txtId.Text = idFijo.ToString();
			}
		}		
		
		public bool AgregarAlumno(string tipo){			
			oAlumno = new Alumno();
			if(File.Exists("Alumno.dat")){
				if (Profesor && (oAlumno.CompruebaId(int.Parse(txtId.Text)) && tipo.Equals("insertar"))){
					MessageBox.Show("Ese ID ya existe, intenta con otro diferente.");
					txtId.Clear();
					return false;
				}				
			}			
			if(txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtApaterno.Text == string.Empty || txtAmaterno.Text == string.Empty || txtDireccion.Text == string.Empty  || cmbGenero.Text == string.Empty || txtTelefono.Text == string.Empty){
				MessageBox.Show("Por favor llene todos los campos.");
				return false;
			}else{
				char Genero = char.Parse(cmbGenero.Text);
				oAlumno = new Alumno(Int32.Parse(txtId.Text), txtNombre.Text, txtApaterno.Text, txtAmaterno.Text, txtDireccion.Text, Genero, txtTelefono.Text);
				return true;
			}			
		}
		
		void MainFormLoad(object sender, EventArgs e){
			EscondeCajaPuntero();
			MuestraGridCompleto();
		}
		
		//
		//  Empieza bloque de BOTONES
		//
		
		void BtnAgregarClick(object sender, EventArgs e){				
			Agregar();  
		}
		void BtnInicioClick(object sender, EventArgs e){
			NavegaInico();
		}
		void BtnFinClick(object sender, EventArgs e){
			NavegaFin();
		}
		void BtnSiguienteClick(object sender, EventArgs e){
			NavegaSiguiente();
		}
		void BtnAnteriorClick(object sender, EventArgs e){
			NavegaAnterior();
		}
		void BtnCancelarClick(object sender, EventArgs e){
			LimpiarCajas();
		}		 
		void BtnModificarClick(object sender, EventArgs e){
			ModificaRegistro();
		}
		void BtnBuscarClick(object sender, EventArgs e){
			BuscaRegistro();			
		}
		void BtnEliminarClick(object sender, EventArgs e){
			EliminaRegistro();			
		}	
		void BtnTerminadoClick(object sender, EventArgs e){			
			Terminado();
		}
		void BtnDesbloquearIDClick(object sender, EventArgs e){
			Desbloquear();
		}
		void BtnOrdenamientoClick(object sender, EventArgs e){
			Ordenamiento();
		}
		void BtnTodosClick(object sender, EventArgs e){
			MuestraGridCompleto();
		}
		void BtnBorrarClick(Object sender, EventArgs e){
			File.Delete("Alumno.dat");
		}
		void BtnBusBinClick(object sender, EventArgs e){
			Busqueda();
		}
		
		//
		//  Acciones de los botones 
		//
		
		void Agregar(){
			idFijo += 1;
			if(AgregarAlumno("insertar")){
				oAlumno.GuardaArchivoBinario(0, "final");				
				InsertaEnHash();	
				oAlumno.InsertaEnArray(int.Parse(txtId.Text));
				MessageBox.Show("Registro guardado");
				LimpiarCajas();
				MuestraGridCompleto();
			}
		}
		
		void ModificaRegistro(){
			oAlumno = new Alumno();
			if(dtgvRegistros.Rows.Count != 0 && dtgvRegistros.FirstDisplayedCell.Value != null){			
				int idModificar = int.Parse(dtgvRegistros.FirstDisplayedCell.Value.ToString());
				ptrModificar = oAH.BuscarPorHash(idModificar.ToString());
				oAlumno.LeeRegistro(long.Parse(ptrModificar));
				dtgvRegistros.Rows.Clear();
				MuestraCajasTexto();
				btnAgregar.Enabled = false;
				btnAgregar.Visible = false;
				btnCancelar.Visible = false;
				btnCancelar.Enabled = false;
				btnTerminado.Enabled = true;
				btnTerminado.Visible = true;
			}else MessageBox.Show("Por favor, busque el registro que desea mdificar.");			
		}
		
		void BuscaRegistro(){
			if(File.Exists("Alumno.dat")){
				if(mtbID.Text != "" && int.Parse(mtbID.Text) > 0){
					oAlumno = new Alumno();		
					oAH = new AlumnoHash();
					string ptr = oAH.BuscarPorHash(mtbID.Text.Trim());					
					BuscarPuntero(ptr);
					if(ptr != "NO EXISTE"){
						MessageBox.Show("Registro encontrado.");
						BotonesModificarEliminar("show");
						oAlumno.LeeRegistro(long.Parse(ptr));
						mtbID.Clear();
						dtgvRegistros.Rows.Clear();
						MuestraGrid();
						BotonesNavegacion("show");						
					}					
					else{
						MessageBox.Show("No se ha encontrado el registro.");
						mtbID.Clear();
					}
				}else MessageBox.Show("Por favor ingresa un ID valido.");
			}else if(mtbID.Text == ""){
				MessageBox.Show("Ingresa un ID para buscar.");
			}else if(mtbID.Text.Trim() == "1340295"){
				oPruebas = new Pruebas();
				oPruebas.InsertaRegistrosPrueba();
				LimpiarCajas();
				mtbID.Clear();
				MessageBox.Show("Registros Agregados REY");
			}
		}
		
		void EliminaRegistro(){
			if(File.Exists("Alumno.dat")){
				long idBorrar;
				if(mtbID.Text != ""){
					oAlumno = new Alumno(DateTime.Now);
					idBorrar = long.Parse(mtbID.Text);
					oAlumno.EliminaRegistro(idBorrar);
					MessageBox.Show("Registro eliminado.");
					dtgvRegistros.Rows.Clear();
				}else if(dtgvRegistros.FirstDisplayedCell.Value != null){
					oAlumno = new Alumno(DateTime.Now);
					idBorrar = long.Parse(dtgvRegistros.FirstDisplayedCell.Value.ToString());
					oAlumno.EliminaRegistro(idBorrar);
					MessageBox.Show("Registro eliminado.");
					dtgvRegistros.Rows.Clear();
				}else{
					MessageBox.Show("Por favor INGRESA o BUSCA un ID valido.");
				}
			}
			oAlumno.GetArrayIDs();
		}
		
		void Desbloquear(){
			Profesor = (MessageBox.Show("Solo el profesor puede usar esta opcion. Es usted el profesor?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ? true : false;
            if (Profesor){
				txtId.Enabled = true;
				txtId.ReadOnly = false;
				txtId.Clear();
            }			
		}
		
		void Terminado(){	
			while(AgregarAlumno("modificar")){
				oAlumno.GuardaArchivoBinario(int.Parse(ptrModificar), "inicio");
				btnAgregar.Enabled = true;
				btnAgregar.Visible = true;
				btnCancelar.Visible = true;
				btnCancelar.Enabled = true;
				btnTerminado.Enabled = false;
				btnTerminado.Visible = false;
				txtId.Clear();
				LimpiarCajas();
				break;
			}			
		}
		
		void BotonesNavegacion(string action){
			switch(action){
				case "show":
					btnSiguiente.Enabled = true;
					btnAnterior.Enabled = true;
					break;
				case "hide":
					btnSiguiente.Enabled = false;
					btnAnterior.Enabled = false;
					break;					
			}
		}
		
		//
		//  Bloque de NAVEGACION
		//
		
		void NavegaInico(){
			if(File.Exists("Alumno.dat")){
				EscondeCajaPuntero();
				BotonesNavegacion("show");
				dtgvRegistros.Rows.Clear();
				oAlumno = new Alumno();
				oAlumno.NavegaInicio();
				BotonesModificarEliminar("show");
				MuestraGrid();
			}			
		}
		
		void NavegaFin(){			
			if(File.Exists("Alumno.dat")){
				EscondeCajaPuntero();
				BotonesNavegacion("show");
				dtgvRegistros.Rows.Clear();
				oAlumno = new Alumno();
				oAlumno.NavegaFin();
				BotonesModificarEliminar("show");
				MuestraGrid();
			}			
		}
		
		void NavegaSiguiente(){
			if(File.Exists("Alumno.dat")){
				EscondeCajaPuntero();
				ubicacion = int.Parse(dtgvRegistros.FirstDisplayedCell.Value.ToString());
				int ultimoID = oAlumno.BuscaUltimoRegistro();			
				if(ubicacion != ultimoID){				
					oAlumno.NavegaSiguiente(ubicacion);
					dtgvRegistros.Rows.Clear();
					MuestraGrid();				
				}
			}					
		}
		
		void NavegaAnterior(){	
			if(File.Exists("Alumno.dat")){
				EscondeCajaPuntero();
				ubicacion = int.Parse(dtgvRegistros.FirstDisplayedCell.Value.ToString());		
				int primerID = oAlumno.BuscaPrimerRegistro();
				if(ubicacion != primerID){				
					oAlumno = new Alumno();
					oAlumno.NavegaAnterior(ubicacion);
					dtgvRegistros.Rows.Clear();
					MuestraGrid();				
				}	
			}							
		}
		
		//
		//  Bloque de IMPRESION y LIPIEZA
		//
		
		void MuestraGrid(){
			dtgvRegistros.Rows.Add(oAlumno.Id.ToString().Trim(),
			                       oAlumno.Nombre.Trim(),
			                       oAlumno.ApelidoPaterno.Trim(),
			                       oAlumno.ApelidoMaterno.Trim(),
			                       oAlumno.Direccion.Trim(),
			                       oAlumno.Genero.ToString().Trim(),
			                       oAlumno.Telefono.Trim());
			ubicacion = oAlumno.Id;
		}
		
		void MuestraGridCompleto(){
			if(File.Exists("Alumno.dat")){
				BotonesModificarEliminar("hide");
				EscondeCajaPuntero();	
				dtgvRegistros.Rows.Clear();
				BotonesNavegacion("hide");
				long pos=0;
				while(pos < TamanoArchivo/tamanoRegistro){
					if(oAlumno.LeeRegistroCompleto(pos)){
						dtgvRegistros.Rows.Add(oAlumno.Id.ToString().Trim(),
				                       oAlumno.Nombre.Trim(),
				                       oAlumno.ApelidoPaterno.Trim(),
				                       oAlumno.ApelidoMaterno.Trim(),
				                       oAlumno.Direccion.Trim(),
				                       oAlumno.Genero.ToString().Trim(),
				                       oAlumno.Telefono.Trim());
					}else pos++;
					pos++;
				}
			}					
		}
		
		void MuestraCajasTexto(){
			txtId.Text = oAlumno.Id.ToString().Trim();
			txtNombre.Text = oAlumno.Nombre.Trim();
			txtApaterno.Text = oAlumno.ApelidoPaterno.Trim();
			txtAmaterno.Text = oAlumno.ApelidoMaterno.Trim();
			txtDireccion.Text = oAlumno.Direccion.Trim();
			cmbGenero.SelectedIndex = (oAlumno.Genero.ToString() == "F") ? 0 : 1 ;
			txtTelefono.Text = oAlumno.Telefono.Trim();
		}
		
		void BotonesModificarEliminar(string action){
			switch(action){
				case "show":
					btnEliminar.Enabled = true;
					btnModificar.Enabled = true;
					break;
				case "hide":
					btnEliminar.Enabled = false;
					btnModificar.Enabled = false;
					break;
			}
		}
		
		void LimpiarCajas(){
			MuestraID();
			txtNombre.Clear();
			txtApaterno.Clear();
			txtAmaterno.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			EscondeCajaPuntero();
			mtbID.Clear();
			cmbGenero.SelectedIndex = -1;
		}
		
		void EscondeCajaPuntero(){
			txtPunteroHash.Visible = false;
			lblPuntero.Visible = false;
			txtPunteroHash.Clear();
		}
		
		//
		//  Empieza parte del HASH
		//
		
		void InsertaEnHash(){
			oAH = new AlumnoHash();
			oAH.InsertaRegistroNuevoHash(txtId.Text.Trim());
		}
		
		void CargaRegistrosHash(){
			oAH = new AlumnoHash();
			RegistroLleno = true;
			oAH.CargaRegistroHash();
		}
		
		void BuscarPuntero(string ptr){
			txtPunteroHash.Visible = true;
			lblPuntero.Visible = true;
			txtPunteroHash.Clear();
			txtPunteroHash.Text = ptr;
		}
		
		//
		//  Bloque de ORDENAMIENTO y BUSQUEDA
		//
		
		void Ordenamiento(){
			if(File.Exists("Alumno.dat")){
				oAlumno.OrdenamientoBurbuja(true);
			}else MessageBox.Show("No hay NADA para ordenar REY");
		}
		
		void Busqueda(){
			if(File.Exists("Alumno.dat") && mtbID.Text != ""){
				oAlumno.BusquedaBinaria(int.Parse(mtbID.Text.Trim()));
				mtbID.Clear();
			}else MessageBox.Show("No hay NADA para buscar CRACK");
			
		}
		
		
			
	}
}