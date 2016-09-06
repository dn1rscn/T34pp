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
		Application.LoadLevel ("Nivel1_dado2.0");
	}
	public void CargarPICTOGRAMAS_Nivel2(){
		Application.LoadLevel ("Nivel2_dado2.0");
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
	public void cargarSonidos()
	{
		Application.LoadLevel ("Sonidos_menu_Seleccion");
	}
	public void CargarSonidosNivel1()
	{
		Application.LoadLevel ("SonidosNivel1");
	}
	public void CargarSonidosNivel2()
	{
		Application.LoadLevel ("SonidosNivel2");
	}
	public void CargarSonidosNivel3()
	{
		Application.LoadLevel ("SonidosNivel3");
	}
	public void CarcarSocial()
	{
		Application.LoadLevel ("1-Social_SelecNivel");
	}
	public void CargarSocialNivel1()
	{
		Application.LoadLevel ("1.1-Social_Nivel1_selecEjercicio");
	}
	public void CargarGlobo ()
	{
		Application.LoadLevel ("1.1.1-Social_Nivel1_Globo");
	}
	public void CargarHelado()
	{
		Application.LoadLevel ("1.1.2-Social_Nivel1_Helado");
	}
	public void CargarTormenta()
	{
		Application.LoadLevel ("1.1.3-Social_Nivel1_Tormenta");
	}
	public void CargarSocialNivel2()
	{
		Application.LoadLevel ("1.2-Social_Nivel2");
	}
	public void CargarSocialNivel3()
	{
		Application.LoadLevel ("1.3-Social_Nivel3_selecEjercicio");
	}
	public void CargarGloboNivel3()
	{
		Application.LoadLevel ("1.3.1-Social_Nivel3_Globo");
	}
	public void CargarHeladoNivel3()
	{
		Application.LoadLevel ("1.3.2-Social_Nivel3_Helado");
	}
	public void CargarTormentaNivel3()
	{
		Application.LoadLevel ("1.3.3-Social_Nivel3_Tormenta");
	}
	public void CargarEmociones()
	{
		Application.LoadLevel ("2-Emociones_SelecNivel");
	}
	public void CargarEmocionesNivel1()
	{
		Application.LoadLevel ("2.1-Emociones_Nivel1");
	}
	public void CargarEmocionesNivel2()
	{
		Application.LoadLevel ("2.2-Emociones_Nivel2");
	}
	public void CargarEmocionesNivel3()
	{
		Application.LoadLevel ("2.3-Emociones_Nivel3");
	}


	//**********************************************************************************

	public void CargarEscenaPERSONALIZAR()
	{
		Application.LoadLevel ("personalizacion1");
	}
}

