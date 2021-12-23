/*
 * Created by SharpDevelop.
 * User: Javier
 * Date: 11/11/2020
 * Time: 23:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Archivo_Texto
{
	/// <summary>
	/// Description of AlumnoHash.
	/// </summary>
	public class AlumnoHash
	{
		
		
		public long TamanoArchivo { get; set; }
		public string ID { get; set; }
		//public int Puntero { get; set; }
		
		public AlumnoHash(){
		}
		public AlumnoHash(long tamanoArchivo){
			this.TamanoArchivo = tamanoArchivo;
		}
		
		const int longitudFecha = 31;
		const string fechaVacia = "                              ";
		const long tamanoRegistro = 193;
		const string vacio = "";
		string[,] KeysPntr;
		
		readonly Hashtable oHT = new Hashtable();
		
		FileStream oFS;
		BinaryReader oBR;
		ICollection oKeys;
		
		public void CargaRegistroHash(){
			long pntrFecha = tamanoRegistro - longitudFecha;
			long pntr = 0;
			string fechaString;
			int idReg;
			oFS = new FileStream("Alumno.dat", FileMode.Open, FileAccess.Read);
			oBR = new BinaryReader(oFS);
			int CantidadRegistros = int.Parse((oFS.Length / tamanoRegistro).ToString());
			for(int i=0; i<CantidadRegistros; i++){
				oFS.Seek(pntr, SeekOrigin.Begin);
				idReg = oBR.ReadInt32();
				oFS.Seek(pntrFecha, SeekOrigin.Begin);
				fechaString = oBR.ReadString();
				if(fechaString == fechaVacia){
					if(oHT.ContainsKey(idReg)){
						MessageBox.Show("CREO QUE NUNCA ENTRO AQUI :V");
						oHT.Remove(idReg);
					}
					oHT.Add(idReg.ToString(), pntr);
				}					
				pntrFecha += tamanoRegistro;							
				pntr += tamanoRegistro;
				TamanoArchivo += tamanoRegistro;
			}
			oBR.Close();
			oFS.Close();		
		}
		
		public void InsertaRegistroNuevoHash(string ID){
			if(oHT.ContainsKey(ID)){
				MessageBox.Show("ENTRO A BORRAR");
				oHT.Remove(ID);
			}
			oHT.Add(ID, (TamanoArchivo-tamanoRegistro) );
		}
		
		public string BuscarPorHash(string ID){
			if(oHT.Count == 0){
				CargaRegistroHash();
			}
			return (oHT.ContainsKey(ID)) ? oHT[ID].ToString() : "NO EXISTE";
		}	
		
		public long GetPtrByHash(string ID){
			if(oHT.Count == 0){
				CargaRegistroHash();
			}
			return long.Parse(oHT[ID].ToString());
		}	
		
		public int ObtenTamanioHT(){
			oHT.Clear();
			CargaRegistroHash();
			return oHT.Count;
		}
		
		public string[,] ObtenArreglo(){
			oHT.Clear();
			CargaRegistroHash();
			KeysPntr = new string[oHT.Count, oHT.Count];
			int i = 0;
			oKeys = oHT.Keys;
			foreach(object Key in oKeys){
				KeysPntr[0,i] = Key.ToString();
				KeysPntr[1,i] = oHT[Key].ToString();
				i++;
			} return KeysPntr;
		}
		
		
	}
}
