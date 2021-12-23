/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 05/10/2020
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 
 //El constructor incializa el objeto de un clase
 //Puede haber tantos constructires en una clase como nostros deseemos
 //Los atributos deben de ir privados porque, segun el principio de POO de "Encapsulamiento",
 //estos solo se pueden poder modificar dentro de la misma clase.
 
 
using System;
using System.IO;
using System.Windows.Forms;

namespace Archivo_Texto{
	public class Alumno{  //Esta es la clase
		
		//Atributos [Privados por principio de encapsulamiento]
		private int id;
		private string nombre;
		private string apellidoPaterno;
		private string apellidoMaterno;
		private string direccion;
		private char genero;
		private string telefono;
		private DateTime fecha;
		
		//Métodos [get/set] (de Java)
		//public void setId(int id){
		//	this.id = id;
		//}
		//public int getId(){
		//	return id;
		//}				
		
		//Propiedades [get/set]
		// disable ConvertToAutoProperty
		public int Id{
			get { return id; }
			set { id = value; }
		}
		public string Nombre{
			get { return nombre; }
			set { nombre = value; }
		}
		public string ApelidoPaterno{
			get { return apellidoPaterno; }
			set { apellidoPaterno = value; }
		}
		public string ApelidoMaterno{
			get { return apellidoMaterno; }
			set { apellidoMaterno = value; }
		}
		public string Direccion{
			get { return direccion; }
			set { direccion = value; }
		}
		public char Genero{
			get { return genero; }
			set { genero = value; }
		}
		public string Telefono{
			get { return telefono; }
			set { telefono = value; }
		}
		public DateTime Fecha{
			get { return fecha; }
			set { fecha = value; }
		}
		
		
		/*El constructor...
		 * Debe tener le mismo nombre de la clase
		 * Sirve para incializar los atributos
		 * Puede haber tantos constructores como deseemos
		 * No utiliza retorno de datos
		 * No utiliza la palabra reservada void
		 * No utiliza la palabra reservada return
		 */
		
		public Alumno(){ 
		}		
		public Alumno(DateTime fecha){
			this.fecha = fecha;
		}		
		public Alumno(int id, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, char genero, string telefono){
			this.id = id;
			this.nombre = nombre;
			this.apellidoPaterno = apellidoPaterno;
			this.apellidoMaterno = apellidoMaterno;
			this.direccion = direccion;
			this.genero = genero;
			this.telefono = telefono;
		}		
		
		FileStream oFileStream;
		BinaryWriter oBinaryWriter;
		BinaryReader oBinaryReader;
		AlumnoHash oAH = new AlumnoHash();
		
		const int longitudFecha = 31;
		const string fechaVacia = "                              ";
		const long tamanoRegistro = 193;
		const string vacio = "";
		long tamanoArchivo;
		int[] arrIDs = new int[50];
		
		public void GuardaArchivoBinario(int pntr, string tipo){			
			try{
				oFileStream = new FileStream("Alumno.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
				oBinaryWriter = new BinaryWriter(oFileStream);			
				if(tipo == "inicio") oBinaryWriter.Seek(pntr, SeekOrigin.Begin);
				else oBinaryWriter.Seek(pntr, SeekOrigin.End);				
				oBinaryWriter.Write(id);								  // 4 	 	= 4
				oBinaryWriter.Write(nombre.PadRight(30));				  // 30 + 1 = 31
				oBinaryWriter.Write(apellidoPaterno.PadRight(30));	 	  // 30 + 1 = 31
				oBinaryWriter.Write(apellidoMaterno.PadRight(30));  	  // 30 + 1 = 31
				oBinaryWriter.Write(direccion.PadRight(50));           	  // 50 + 1 = 51 
				oBinaryWriter.Write(genero);							  // 1 		= 1	 
				oBinaryWriter.Write(telefono.PadRight(12));     	      // 12 + 1 = 13  
				oBinaryWriter.Write(vacio.PadRight(30));				  // 30 + 1 = 31 --> [193]	
				tamanoArchivo = oFileStream.Length;
				oAH = new AlumnoHash(tamanoArchivo);
				CierraArchivoBinario("writer");
			}catch(Exception e){
				MessageBox.Show("Error! :  " + e);
			}finally{
				oBinaryWriter.Close();
			}
		}		
		
		public int BuscaUltimoRegistro(){
			GetArrayIDs();
			long idUltimo=0;			
			oAH = new AlumnoHash();
			long pos=0;
			pos = (tamanoArchivo/tamanoRegistro);
			while(true){
				idUltimo = arrIDs[pos];
				string ptr = oAH.BuscarPorHash(idUltimo.ToString());
				if(ptr != "NO EXISTE"){
					oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
					oBinaryReader = new BinaryReader(oFileStream);
					oFileStream.Seek(long.Parse(ptr), SeekOrigin.Begin);
					id = oBinaryReader.ReadInt32();
					CierraArchivoBinario("reader");
					return id;
				}
				if(pos == 0){
					MessageBox.Show("ALGO SALIO MAL XD");
					return 0;
				}
				pos -= 1;	
			}
		}
		
		public int BuscaPrimerRegistro(){
			GetArrayIDs();
			long idPrimero = 0;			
			oAH = new AlumnoHash();
			long pos=0;
			while(true){
				idPrimero = arrIDs[pos];
				string ptr = oAH.BuscarPorHash(idPrimero.ToString());
				if(ptr != "NO EXISTE"){
					oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
					oBinaryReader = new BinaryReader(oFileStream);
					oFileStream.Seek(long.Parse(ptr), SeekOrigin.Begin);
					id = oBinaryReader.ReadInt32();
					CierraArchivoBinario("reader");
					return id;
				}
				if(pos == 0){
					MessageBox.Show("ALGO SALIO MAL XD");
					return 0;
				}
				pos += 1;	
			}
			
		}
		
		public int BuscaMayorID(){
			GetArrayIDs();
			int IdMayor = 0;
			oAH = new AlumnoHash();
			for(int i=0; i<arrIDs.Length; i++){
				if(IdMayor < arrIDs[i]){
					IdMayor = arrIDs[i];
				}
			} return IdMayor;
		}		
		
		public void GetArrayIDs(){
			oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
			oBinaryReader = new BinaryReader(oFileStream);			
			tamanoArchivo = oFileStream.Length;	
			oAH = new AlumnoHash();
			long tmp = 0; int pos=0;	
			while(tmp <= tamanoArchivo-tamanoRegistro){
				oFileStream.Seek(tmp, SeekOrigin.Begin);
				id = oBinaryReader.ReadInt32();
				if(oAH.BuscarPorHash(id.ToString()) != "NO EXISTE"){
					arrIDs[pos] = id;
					pos++;	
				} tmp += tamanoRegistro;										
			} CierraArchivoBinario("reader");
		}
		
		public bool CompruebaId(int IdComprobar){
			GetArrayIDs();
			for(int i=0; i<arrIDs.Length; i++)
				if(IdComprobar == arrIDs[i]) return true; //Es decir, ese ID ya existe
			return false;			
		}
		
		public void InsertaEnArray(int ID){
			GetArrayIDs();
			arrIDs[(tamanoArchivo/tamanoRegistro)-1] = ID;
		}		
		
		public void EliminaRegistro(long posicion){
			oAH = new AlumnoHash();
			long punteroEliminar = oAH.GetPtrByHash(posicion.ToString()) + tamanoRegistro - longitudFecha;
			oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.ReadWrite);
			oBinaryWriter = new BinaryWriter(oFileStream);
			oFileStream.Seek(punteroEliminar, SeekOrigin.Begin);
			oBinaryWriter.Write(fecha.ToString().PadRight(30));
			CierraArchivoBinario("writer");
		}		
		
		public void NavegaInicio(){	
			int primerID = BuscaPrimerRegistro();
			oAH = new AlumnoHash();
			string ptr = oAH.BuscarPorHash(primerID.ToString());
			LeeRegistro(long.Parse(ptr));			
		}
		
		public void NavegaFin(){
			int ultimoID = BuscaUltimoRegistro();
			oAH = new AlumnoHash();
			string ptr = oAH.BuscarPorHash(ultimoID.ToString());
			LeeRegistro(long.Parse(ptr));	
		}
		
		public void NavegaSiguiente(int ubicacion){	
			int ultimoRegistro = BuscaUltimoRegistro();			
			for(int i=0; i<arrIDs.Length; i++){					
				if(ubicacion == arrIDs[i]){
					for(int j=i; j<arrIDs.Length; j++){						
						string ptr = oAH.BuscarPorHash(arrIDs[j+1].ToString());
						if(ptr != "NO EXISTE"){
							LeeRegistro(long.Parse(ptr));
							break;
						}
						if(arrIDs[j+1] == ultimoRegistro){
							//MessageBox.Show("YA NO HAY NADA MAS ADELANTE");
							break;
						}
						//MessageBox.Show("NO EXISTE, BUSCO EL QUE SIGUE");						
					}					
				}				
			}			
		}
		
		public void NavegaAnterior(int ubicacion){	
			int primerRegistro = BuscaPrimerRegistro();	
			for(int i=arrIDs.Length-1; i>=0; i--){	
				if(ubicacion == arrIDs[i]){
					for(int j=i; j>=0; j--){
						string ptr = oAH.BuscarPorHash(arrIDs[j-1].ToString());
						if(ptr != "NO EXISTE"){
							LeeRegistro(long.Parse(ptr));
							break;
						}
						if(arrIDs[j-1] == primerRegistro){
							//MessageBox.Show("YA NO HAY NADA MAS ATRAS");
							break;
						}
						//MessageBox.Show("NO EXISTE, BUSCO EL ANTERIOR");						
					}					
				}				
			}			
		}
		
		public void LeeRegistro(long ptr){
			oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
			oBinaryReader = new BinaryReader(oFileStream);
			oFileStream.Seek(ptr, SeekOrigin.Begin);
			id = oBinaryReader.ReadInt32();
			nombre = oBinaryReader.ReadString();
			apellidoPaterno = oBinaryReader.ReadString();
			apellidoMaterno = oBinaryReader.ReadString();
			direccion = oBinaryReader.ReadString();
			genero = oBinaryReader.ReadChar();
			telefono = oBinaryReader.ReadString();
			CierraArchivoBinario("reader");
		}
		
		public bool LeeRegistroCompleto(long pos){
			oAH = new AlumnoHash();
			GetArrayIDs();
			string ptr = oAH.BuscarPorHash(arrIDs[pos].ToString());
			if(ptr != "NO EXISTE"){
				//oAH = new AlumnoHash();
				oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
				oBinaryReader = new BinaryReader(oFileStream);
				oFileStream.Seek(long.Parse(ptr), SeekOrigin.Begin);
				id = oBinaryReader.ReadInt32();
				nombre = oBinaryReader.ReadString();
				apellidoPaterno = oBinaryReader.ReadString();
				apellidoMaterno = oBinaryReader.ReadString();
				direccion = oBinaryReader.ReadString();
				genero = oBinaryReader.ReadChar();
				telefono = oBinaryReader.ReadString();
				CierraArchivoBinario("reader");
				return true;
			}
			CierraArchivoBinario("reader");
			return false;			
		}
		
		void CierraArchivoBinario(string tipo){
			switch(tipo){
				case "reader":
					oBinaryReader.Close();
					oFileStream.Close();
					break;
				case "writer":
					oBinaryWriter.Flush();
					oBinaryWriter.Close();
					break;
			}			
		}		
		
		public long GetTamanoArchivo(){
			oFileStream = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
			oBinaryReader = new BinaryReader(oFileStream);
			tamanoArchivo = oFileStream.Length;
			CierraArchivoBinario("reader");
			return tamanoArchivo;
		}
		
		public void OrdenamientoBurbuja(bool nuevo){
			oAH = new AlumnoHash();
			GetArrayIDs();
			int cantidadRegistros = oAH.ObtenTamanioHT();			
			int[] arrBurbujo = new int[arrIDs.Length];
			int a, b, i=0, cambios=0;
			while(true){
				if(i < cantidadRegistros-1){
					a = arrIDs[i];
					b = arrIDs[i+1];
					if(b < a){
						cambios ++;
						arrIDs[i] = b;
						arrIDs[i+1] = a;
					}
					i++;
				}
				if(i == cantidadRegistros-1){
					if(cambios == 0) break;
					i = 0;
					cambios = 0;
				}
			}
			if(nuevo) CreaNuevoArchivo(cantidadRegistros);
		}
		
		void CreaNuevoArchivo(int n){
			for(int i=0; i<n; i++){
				long ptr = oAH.GetPtrByHash(arrIDs[i].ToString());
				LeeRegistro(ptr);
				oFileStream = (i == 0) ? new FileStream("Alumno2.dat", FileMode.Create, FileAccess.ReadWrite) : new FileStream("Alumno2.dat", FileMode.Append, FileAccess.Write);
				try{				
					oBinaryWriter = new BinaryWriter(oFileStream);
					oBinaryWriter.Seek(0, SeekOrigin.End);
					oBinaryWriter.Write(id);								  // 4 	 	= 4
					oBinaryWriter.Write(nombre.PadRight(30));				  // 30 + 1 = 31
					oBinaryWriter.Write(apellidoPaterno.PadRight(30));	 	  // 30 + 1 = 31
					oBinaryWriter.Write(apellidoMaterno.PadRight(30));  	  // 30 + 1 = 31
					oBinaryWriter.Write(direccion.PadRight(50));           	  // 50 + 1 = 51 
					oBinaryWriter.Write(genero);							  // 1 		= 1	 
					oBinaryWriter.Write(telefono.PadRight(12));     	      // 12 + 1 = 13  
					oBinaryWriter.Write(vacio.PadRight(30));				  // 30 + 1 = 31 --> [193]	
					tamanoArchivo = oFileStream.Length;
					oAH = new AlumnoHash(tamanoArchivo);
					CierraArchivoBinario("writer");
				}catch(Exception e){
					MessageBox.Show("Error! :  " + e);
				}finally{
					oBinaryWriter.Close();
				}
			}
			File.Delete("Alumno.dat");
			File.Move("Alumno2.dat", "Alumno.dat");
			GetArrayIDs();
		}
		
		public void BusquedaBinaria(int num){			
			GetArrayIDs();
			OrdenamientoBurbuja(false);
			oAH = new AlumnoHash();
			int cantidadRegistros = oAH.ObtenTamanioHT();
	        int low = 0, high = cantidadRegistros-1, middle = 0;
	        bool found = false;
	        while (low <= high && found == false){
	            middle = (low + high) / 2;
				if (arrIDs[middle] == num) found = true;				
	            if (arrIDs[middle] > num) high = middle - 1;
	            else low = middle + 1;
	        }	        
	        string mensaje = (found == false) ? "El ID [ " + num + " ] NO esta en el arreglo." : "El ID [ " + num + " ] esta en la posicion : " + (middle+1);
	        MessageBox.Show(mensaje);
		}
		
		
	}
}
