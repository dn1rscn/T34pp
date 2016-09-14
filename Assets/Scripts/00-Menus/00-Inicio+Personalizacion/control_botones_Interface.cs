using UnityEngine;
using System.Collections;

public class control_botones_Interface : MonoBehaviour 
{
	//public GameObject personalizacion;
	//public GameObject ajustes;

	//public GameObject personaje;
	//public GameObject Grupo_mascotas;
	//public GameObject[] Amascotas;
	//Actualizar_mascotas CMasc;

	//Animator anim_mascotas;

	//control_datosGlobalesPersonalizacion cdgp;

	// Use this for initialization
	void Start () 
	{
		//cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		//CMasc = GameObject.Find ("Grupo_Mascotas").GetComponent<Actualizar_mascotas> ();
		//personalizacion.SetActive(false);
		//CMasc.Amascotas [cdgp.mascota].SetActive (false);
		/*if (cdgp.mascotas == true) 
		{
			CMasc.Amascotas [cdgp.mascota].SetActive (true);
			personaje.SetActive (false);
		} 
		else 
		{
			CMasc.Amascotas [cdgp.mascota].SetActive (false);
			personaje.SetActive (true);
		}*/
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	/*public void personalizar()
	{
		CMasc = GameObject.Find ("Grupo_Mascotas").GetComponent<Actualizar_mascotas> ();
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		personaje.SetActive (true);
		CMasc.Amascotas [cdgp.mascota].SetActive (false);
		cdgp.mascotas = false;
		if (cdgp.Vper_activo == false) 
		{
			personalizacion.SetActive (true);
			cdgp.Vper_activo = true;
		} 
		else if (cdgp.Vper_activo == true) 
		{
			personalizacion.SetActive(false);
			cdgp.Vper_activo=false;
		}
	}*/

	/*public void mascotas()
	{
		CMasc = GameObject.Find ("Grupo_Mascotas").GetComponent<Actualizar_mascotas> ();
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		cdgp.Vper_activo = false;
		personaje.SetActive (false);
		CMasc.Amascotas [cdgp.mascota].SetActive (true);
		cdgp.mascotas = true;
		cdgp.complementos = false;
		cdgp.pelo = false;
		cdgp.piel = false;
		cdgp.camiseta = false;
		cdgp.piernas = false;
		personalizacion.SetActive(false);

	}*/

	public void RA_personalizacion()
	{
		Application.LoadLevel("personalizar_RA");
	}
	public void PersonalizacionInicial()
	{
		print ("cam personaje");
		GameObject.Find("camara").GetComponent<Animator>().Play("CamPersonaje");
	}
	public void PersonalizacionJuego()
	{
		print ("hola");
	}
	public void mascotas()
	{
		GameObject.Find("camara").GetComponent<Animator>().Play("CamMascota");
	}
}
