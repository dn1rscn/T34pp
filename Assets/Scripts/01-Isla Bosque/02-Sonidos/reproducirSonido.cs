using UnityEngine;
using System.Collections;

public class reproducirSonido : MonoBehaviour 
{

	public AudioSource[] ASonidos;

	ControlSonidos CS;
	RespuestaSonidos RS;

	public GameObject MaquinaDiscos;


	/*public AudioSource Olla;
	public AudioSource Timbre;
	public AudioSource Telefono;
	public AudioSource Micro;*/
	public GameObject BotonPlay;
	public GameObject BotonRepetir;


	
	public int SonidoAleatorio;
	
	// Use this for initialization
	void Start () 
	{
		CS = GameObject.Find ("ctrSonidos").GetComponent<ControlSonidos> ();
		//BotonPlay.SetActive (true);
		//BotonRepetir.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	public void Repetir()
	{
		//MaquinaDiscos.GetComponent<Animation> ().Play ("replay");
		//MaquinaDiscos.GetComponent<Animation> ().Play ("disco");

		//AnimReplay.Play ("replay");
		ASonidos [SonidoAleatorio].Play ();
	}
	
	public void StopSonido()
	{
		ASonidos [SonidoAleatorio].Stop ();
		/*for (int i=0; i<ASonidos.Length; i++) 
		{
			ASonidos [i].Stop ();
		}*/
	}

	public void Reproducir()
	{
		RS = GameObject.Find ("control respuesta").GetComponent<RespuestaSonidos> ();

		if (RS.respuesta == true) {
			RS.respuesta = false;

			//MaquinaDiscos.GetComponent<Animation> ().Play ("play");
			//MaquinaDiscos.GetComponent<Animation> ().Play ("disco");

			SonidoAleatorio = Random.Range (0, 4);
			ASonidos [SonidoAleatorio].Play ();
			//BotonPlay.SetActive (false);
			//BotonRepetir.SetActive (true);
		} else if (RS.respuesta == false) 
		{
			//MENSAJE MASCOTA NO HAY RESPUESTA
		}
		
	}
}