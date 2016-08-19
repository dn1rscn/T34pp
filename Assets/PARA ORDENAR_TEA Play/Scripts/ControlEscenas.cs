using UnityEngine;
using System.Collections;

public class ControlEscenas : MonoBehaviour {


	Animator animator_PanelCanvas;
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;


	// Use this for initialization
	void Start () {

		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();


		if(GameObject.Find("Panel_Canvas"))
		{
		animator_PanelCanvas = GameObject.Find("Panel_Canvas").GetComponent<Animator>();
		}
	}
	
	public void siguienteEscena() {
		
		if (Application.loadedLevelName == "03_Mundo3D" || Application.loadedLevelName == "04_Nivel1-PICTOGRAMAS") {
			//animator_PanelCanvas.Play ("pasarABlanco");
		}
		//Invoke ("cargarEscena", 100 * Time.deltaTime);

	}

	public void cargarEscena (){

		if (Application.loadedLevelName == "01_MenuInicial"){

			//Ejecutamos la animacion de la camara
			GameObject.Find("Main Camera").GetComponent<Animator>().SetBool("camaraPlay",true);
			//Y hacemos que los botones del inicio se vayan
			DesaparecerBotonesINTRO();
	
		}

		else if (Application.loadedLevelName == "02_VideoINTRO"){
			
			Application.LoadLevel ("03_Mundo3D");
		}

		if (Application.loadedLevelName == "03_Mundo3D"){
		//	animator_PanelCanvas.Play("pasarABlanco");
			Application.LoadLevel ("04_Nivel1-PICTOGRAMAS");
		}
		
		if (Application.loadedLevelName == "04_Nivel1-PICTOGRAMAS"){
		//	animator_PanelCanvas.Play("pasarABlanco");
			Application.LoadLevel ("03_Mundo3D");
		}

	}


	public void pasarABlanco(){
		GameObject.Find("Panel").GetComponent<Animator>().Play("PasarABlanco");
	}

	public void HacerAparecerBotonesINTRO(){
		GameObject.Find("BotonesINICIO").GetComponent<Animator>().Play("Aparecer");
	}
	public void DesaparecerBotonesINTRO(){
		GameObject.Find("BotonesINICIO").GetComponent<Animator>().SetBool("desaparecerBotones",true);
	}

	public void CargarInicio(){


		Application.LoadLevel ("01_MenuInicial");
	}

	public void CargarSeleccionDePersonajesDINO(){
		//guardarPosicionProta
		//guardarPosicionMascota
		Application.LoadLevel ("02_SeleccionPersonajes");
	}

	public void CargarSeleccionDePersonajesROBOT(){
		//guardarPosicionProta
		//guardarPosicionMascota
		Application.LoadLevel ("04_SeleccionPersonajes_IslaRobot");
	}

	public void CargarSeleccionDePersonajesFANTASMA(){
		//guardarPosicionProta
		//guardarPosicionMascota
		Application.LoadLevel ("05_SeleccionPersonajes_IslaFantasma");
	}


	//******************CARGAR ISLAS*****************************************************
	public void CargarIslaDinoDirecto()
	{
		Application.LoadLevel ("03_1-Mundo3D_IslaDino");
		CDG_Mundo3D.islaBosque = true;
		CDG_Mundo3D.islaMec = false;
		CDG_Mundo3D.islaFant = false;
	}

	public void CargarIslaDino(){

		if(!CDG_Mundo3D.primeraVez_IslaDino)
		{
			Application.LoadLevel ("03_1-Mundo3D_IslaDino");
			CDG_Mundo3D.islaBosque = true;
			CDG_Mundo3D.islaMec = false;
			CDG_Mundo3D.islaFant = false;
		} 
		else{
			Application.LoadLevel ("01_MenuInicial");
		}
	}
	public void CargarIslaRobot(){
		Application.LoadLevel ("04_1-Mundo3D_IslaRobot");
		CDG_Mundo3D.islaBosque = false;
		CDG_Mundo3D.islaMec = true;
		CDG_Mundo3D.islaFant = false;
	}
	public void CargarIslaFantasma(){
		Application.LoadLevel ("05_1-Mundo3D_IslaFantasma");
		CDG_Mundo3D.islaBosque = false;
		CDG_Mundo3D.islaMec = false;
		CDG_Mundo3D.islaFant = true;
	}

	//**********************************************************************************

	//******************CARGAR EJERCICIOS*****************************************************
	public void CargarPICTOGRAMAS_Nivel1(){
		Application.LoadLevel ("03_2-Nivel1-PICTOGRAMAS");
	}
	public void CargarPICTOGRAMAS_Nivel2(){
		Application.LoadLevel ("03_3-Nivel2-PICTOGRAMAS");
	}


	public void CargarBONUS_IslaDINO(){
		Application.LoadLevel ("04_2-BONUS-PuzzlesLvl1");
		
	}
	public void CargarBONUS_IslaROBOT(){
		Application.LoadLevel ("04_2-BONUS-PuzzlesLvl2");
		
	}
	public void CargarBONUS_IslaFANTASMA(){
		Application.LoadLevel ("04_2-BONUS-PuzzlesLvl3");
		
	}

	public void CargarSECUENCIAS(){
		Application.LoadLevel ("SECUENCIAS_menu_seleccion");
		
	}
	public void secuencia_Dientes()
	{
		Application.LoadLevel ("SECUENCIAS_Dientes");
	}

	public void secuencia_telefono()
	{
		Application.LoadLevel ("SECUENCIAS_LlamarTelefono");
	}
	public void secuencia_Pan()
	{
		Application.LoadLevel ("SECUENCIAS_ComprarPan");
	}
	public void secuencia_calle()
	{
		Application.LoadLevel ("SECUENCIAS_CruzarCalle");
	}
	public void canasta()
	{
		Application.LoadLevel ("ejercicioCanastas");
	}


	//**********************************************************************************

	public void CargarEscenaPERSONALIZAR()
	{
		Application.LoadLevel ("personalizacion1");
	}
}

