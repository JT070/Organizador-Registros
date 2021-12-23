/*
 * Created by SharpDevelop.
 * User: JT_070
 * Date: 04/11/2020
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Archivo_Texto
{
	/// <summary>
	/// Description of Pruebas.
	/// </summary>
	public class Pruebas
	{
		public Pruebas(){
			
		}
		
		Alumno oAlumno;
		
		public void InsertaRegistrosPrueba(){
			oAlumno = new Alumno(654, "Javier", "Trejo", "Trejo", "Norte 20", 'M', "5543434343");
			oAlumno.GuardaArchivoBinario(0, "final");	
			oAlumno = new Alumno(879, "Ruben", "Tovar", "Jimenez", "Norte 265", 'M', "2222222222");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(321, "Luis Angel", "Herrera", "Palao", "Sur 79879", 'M', "3333333333");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(415, "Mariana", "Vazquez", "Silva", "Poniente 2132", 'F', "4444444444");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(365, "Peniel", "Trejo", "Rodriguez", "Norte 25", 'F', "5555555555");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(855, "Luis Antonio", "Pena", "Cardoso", "poniente 465", 'M', "6666666666");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(651, "Rodo", "Lopez", "Valencia", "Covadonga Peligro no entres", 'M', "7777777777");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(369, "Goku", "Lopez", "Martinez", "El planeta Tiera", 'M', "8888888888");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(156, "Horacio", "Tacubeno", "Cruz", "Sur 18", 'M', "9999999999");
			oAlumno.GuardaArchivoBinario(0, "final");
			oAlumno = new Alumno(302, "Pandemio Guadalupe", "De la Cruz", "De los Santos", "Sur 12", 'M', "0101010101");
			oAlumno.GuardaArchivoBinario(0, "final");
		}
		
		
	}
}
