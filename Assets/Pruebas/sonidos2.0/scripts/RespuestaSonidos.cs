using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RespuestaSonidos : MonoBehaviour 
{
	ControlSonidos CS;
	reproducirSonido RS;

	public GameObject[] vidas;

	public GameObject IfinJuego;

	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasDado;
	Text TmonedasDado;

	GameObject puntuacionfin;
	Text TpuntuacionFin;

	public GameObject BotonPlay;
	public GameObject BotonRepetir;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;

	// Use this for initialization
	void Start () 
	{
		CS = GameObject.Find ("ctrSonidos").GetComponent<ControlSonidos> ();
		RS = GameObject.Find ("reproducir sonido").GetComponent<reproducirSonido> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void respuesta1()
	{
		if(RS.SonidoAleatorio==0)
		{
			correcto();
		}
		else
		{
			incorrecto();
		}
		
	
	}

	public void respuesta2()
	{
		if(RS.SonidoAleatorio==1)
		{
			correcto();
		}
		else
		{
			incorrecto();
		}
	}
	public void respuesta3()
	{
		if(RS.SonidoAleatorio==2)
		{
			correcto();
		}
		else
		{
			incorrecto();
		}
	}
	public void respuesta4()
	{
		if(RS.SonidoAleatorio==3)
		{
			correcto();
		}
		else
		{
			incorrecto();
		}
	}

	void correcto()
	{
		CS.aciertos++;
		BotonPlay.SetActive (true);
		BotonRepetir.SetActive (false);
		RS.StopSonido ();

		print ("correcto");
	}
	void incorrecto()
	{
		CS.fallos++;
		if(CS.fallos==5)
		{
			IfinJuego.SetActive (true);
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasDado = GameObject.Find ("monedas");
			TmonedasDado = monedasDado.GetComponent<Text> ();
			
			//cM.calcular_monedasDado ();
			//cM.calcular_monedasGenerales ();
			
			if (CS.aciertos >= 5) {
				Invoke ("ActivarEstrella1", 1.0f);
				//desbloquear su¡iguiente nivel
			}
			if (CS.aciertos >= 10) {
				Invoke ("ActivarEstrella2", 2.0f);
			}
			if (CS.aciertos >= 15) {
				Invoke ("ActivarEstrella3", 3.0f);
			}
			
			
			TpuntuacionFin.text = "\nACIERTOS: " + CS.aciertos.ToString ();
			
			//TmonedasDado.text = cM.monedas_dado.ToString();
			
			CS.aciertos = 0;
			CS.fallos = 0;
			//cdg.aciertosSeguidos = 0;
			//cdg.combos = 0;
//			cM.monedas_dado = 0;
		}
		else
		{
			vidas [CS.fallos-1].SetActive (false);
		}
		print ("incorrecto");
	}
	void ActivarEstrella1()
	{
		Debug.Log("estrella1");
		//yield return new WaitForSeconds (2.0f);
		estrella1.SetActive (true);
	}
	void ActivarEstrella2()
	{
		//yield return new WaitForSeconds (2.0f);
		estrella2.SetActive (true);
	}
	void ActivarEstrella3()
	{
		//yield return new WaitForSeconds (2.0f);
		estrella3.SetActive (true);
	}
}
