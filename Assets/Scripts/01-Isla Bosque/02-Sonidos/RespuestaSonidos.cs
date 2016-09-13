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
	
	GameObject monedasSonidos;
	Text TmonedasSonidos;

	GameObject puntuacionfin;
	Text TpuntuacionFin;

	public GameObject BotonPlay;
	public GameObject BotonRepetir;
	public GameObject BotonSiguienteNivel;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;

	// Use this for initialization
	void Start () 
	{
		CS = GameObject.Find ("ctrSonidos").GetComponent<ControlSonidos> ();
		RS = GameObject.Find ("reproducir sonido").GetComponent<reproducirSonido> ();
		actualizarPuntuacion ();
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

		actualizarPuntuacion ();

		print ("correcto");
	}
	void incorrecto()
	{
		CS.fallos++;
		if(CS.fallos==5)
		{
			IfinJuego.SetActive (true);

			RS.StopSonido();

			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasSonidos = GameObject.Find ("monedas");
			TmonedasSonidos = monedasSonidos.GetComponent<Text> ();

			cM=GameObject.Find("controlMonedas").GetComponent<Control_monedas>();
			
			cM.calcular_monedasSonidos ();
			cM.calcular_monedasGenerales ();
			
			if (CS.aciertos >= 5) 
			{
				Invoke ("ActivarEstrella1", 1.0f);
				//desbloquear su¡iguiente nivel
				BotonSiguienteNivel.SetActive(true);
				if(CS.posicion+1<CS.ASonidos.Length)
				{
					CS.ASonidos[CS.posicion=CS.posicion+1]=true;
				}
			}
			if (CS.aciertos >= 10) {
				Invoke ("ActivarEstrella2", 2.0f);
			}
			if (CS.aciertos >= 15) {
				Invoke ("ActivarEstrella3", 3.0f);
			}
			
			
			TpuntuacionFin.text = "\nACIERTOS: " + CS.aciertos.ToString ();
			
			TmonedasSonidos.text = cM.MonedasSonidos.ToString();
			
			CS.aciertos = 0;
			CS.fallos = 0;
			//cdg.aciertosSeguidos = 0;
			//cdg.combos = 0;
			cM.MonedasSonidos = 0;
		}
		else
		{
			vidas [CS.fallos-1].SetActive (false);
		}
		print ("incorrecto");
	}
	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();
		
		Tpuntuacion.text = CS.aciertos.ToString();
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
