using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaEmociones : MonoBehaviour 
{
	ControlEmocionesAleatorio CEA;
	ControlEmociones CE;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;
	
	public GameObject IfinJuego;
	
	//public GameObject BotonVolverGrande;
	
	public GameObject SiguienteSecuencia;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasEmociones;
	Text TmonedasEmociones;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CE.respuesta = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.respuesta == false) 
		{
			CEA = GameObject.Find ("ctrAleatorio").GetComponent<ControlEmocionesAleatorio> ();

			if ("P" + gameObject.GetComponent<Image> ().sprite.name == GameObject.Find ("Pregunta").GetComponent<Image> ().sprite.name) {
				Correcto ();
			} else {
				Error ();
			}
		}
	}

	void Correcto()
	{
		print ("correcto");
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		print (CEA.ARespuesta.Length);
		//Nivel 1
		if (CEA.ARespuesta.Length == 3) 
		{
			IfinJuego.SetActive(true);
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasEmociones = GameObject.Find ("monedas");
			TmonedasEmociones = monedasEmociones.GetComponent<Text> ();
			
			cM.calcular_monedasEmocionesNivel1 ();
			cM.calcular_monedasGenerales ();

			print(CE.fallos);
			if (CE.fallos == 2) 
			{
				ActivarEstrella1();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 1) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 0) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				ActivarEstrella3();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			
			
			TpuntuacionFin.text = "\nFALLOS: " + CE.fallos.ToString ();
			
			TmonedasEmociones.text = cM.monedasEmociones.ToString();
			
			cM.monedasEmociones=0;
			CE.fallos=0;
			CE.respuesta=true;
		}
		//nivel2
		if (CEA.ARespuesta.Length == 5) 
		{
			IfinJuego.SetActive(true);
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasEmociones = GameObject.Find ("monedas");
			TmonedasEmociones = monedasEmociones.GetComponent<Text> ();
			
			cM.calcular_monedasEmocionesNivel2 ();
			cM.calcular_monedasGenerales ();
			
			if (CE.fallos == 3||CE.fallos==4) 
			{
				ActivarEstrella1();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 1||CE.fallos==2) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 0) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				ActivarEstrella3();
				SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			
			
			TpuntuacionFin.text = "\nFALLOS: " + CE.fallos.ToString ();
			
			TmonedasEmociones.text = cM.monedasEmociones.ToString();
			
			cM.monedasEmociones=0;
			CE.fallos=0;
			CE.respuesta=true;
		}
		//nivel3
		if (CEA.ARespuesta.Length == 7) 
		{
			IfinJuego.SetActive(true);
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasEmociones = GameObject.Find ("monedas");
			TmonedasEmociones = monedasEmociones.GetComponent<Text> ();
			
			cM.calcular_monedasEmocionesNivel3 ();
			cM.calcular_monedasGenerales ();
			
			if (CE.fallos == 4||CE.fallos==5) 
			{
				ActivarEstrella1();
				//SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 2||CE.fallos==3) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				//SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			if (CE.fallos == 0||CE.fallos==1) 
			{
				ActivarEstrella1();
				ActivarEstrella2();
				ActivarEstrella3();
				//SiguienteSecuencia.SetActive(true);
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
			}
			
			
			TpuntuacionFin.text = "\nFALLOS: " + CE.fallos.ToString ();
			
			TmonedasEmociones.text = cM.monedasEmociones.ToString();
			
			cM.monedasEmociones=0;
			CE.fallos=0;
			CE.respuesta=true;
		}
	}
	void Error()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		print ("fallo");
		CE.fallos++;
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
