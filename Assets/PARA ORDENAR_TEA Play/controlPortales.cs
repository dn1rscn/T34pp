using UnityEngine;
using System.Collections;

public class controlPortales : MonoBehaviour {

	Animator animator_PanelCanvas;

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	// Use this for initialization
	void Start ()
	{
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		animator_PanelCanvas = GameObject.Find ("Panel_Canvas").GetComponent<Animator> ();
	}
	
	void OnTriggerEnter(Collider coli)
	{
		print ("trigger");
		print ("Colision con"+coli.gameObject.name);

		if (coli.gameObject.name == "Prota_TEAPlay")
		{
			print ("Colision con"+coli.gameObject.name);
			if(gameObject.name=="Pictogramas_1")
			{
				CDG_Mundo3D.posicionPersonaje = 2;

				print("cargarPictogramas1");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarPictogramas1",100*Time.deltaTime);
			}
			else if(gameObject.name=="Pictogramas_2")
			{
				CDG_Mundo3D.posicionPersonaje = 2;

				print("cargarPictogramas2");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarPictogramas2",100*Time.deltaTime);
			}
			else if(gameObject.name=="Trigger_Secuencias")
			{
				print("cargarSecuencias");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarSecuencias",100*Time.deltaTime);
			}
			else if(gameObject.name=="Tube014")
			{
				print("cargarEmociones1");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarEmociones1",100*Time.deltaTime);
			}
			else if(gameObject.name=="IslaFantasma")
			{
				if(Application.loadedLevelName=="03_1-Mundo3D_IslaDino")
				{
					CDG_Mundo3D.posicionPersonaje = 1;
				}
				else if(Application.loadedLevelName=="04_1-Mundo3D_IslaRobot")
				{
					CDG_Mundo3D.posicionPersonaje = 3;
				}
				print("cargarIslaFantasma");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarIslaFantasma",100*Time.deltaTime);
			}
			else if(gameObject.name=="IslaDino")
			{
				CDG_Mundo3D.posicionPersonaje = 3;
				
				print("cargarIslaDino");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarIslaDino",100*Time.deltaTime);
			}
			else if(gameObject.name=="IslaRobot")
			{
				CDG_Mundo3D.posicionPersonaje = 1;
				
				print("cargarIslaRobot");
				animator_PanelCanvas.Play("pasarABlanco");
				Invoke("cargarIslaRobot",100*Time.deltaTime);
			}
		}
	}

	void cargarPictogramas1(){
		Application.LoadLevel("03_2-Nivel1-PICTOGRAMAS");
	}
	void cargarPictogramas2(){
		Application.LoadLevel("03_3-Nivel2-PICTOGRAMAS");
	}
	void cargarSecuencias(){
		Application.LoadLevel("SECUENCIAS_menu_seleccion");
	}
	void cargarBonus(){
		Application.LoadLevel("03_3-Nivel2-PICTOGRAMAS");
	}

	void cargarIslaFantasma(){
		Application.LoadLevel("05_1-Mundo3D_IslaFantasma");
	}
	void cargarIslaDino(){
		Application.LoadLevel("03_1-Mundo3D_IslaDino");
	}
	void cargarIslaRobot(){
		Application.LoadLevel("04_1-Mundo3D_IslaRobot");
	}
	void cargarEmociones1(){
		Application.LoadLevel("Escena1.1");
	}
}
