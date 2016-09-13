using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuesta : MonoBehaviour 
{
	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;

	GameObject monedasDado;
	Text TmonedasDado;

	public GameObject[] vidas;

	public GameObject IfinJuego;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;

	Animator animator_Cartel1;
	Animator animator_Cartel2;
	Animator animator_Cartel3;


	// Use this for initialization
	void Start () 
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();
		resetearDado ();
		actualizarPuntuacion ();
		IfinJuego.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SeleccionRespuesta ()
	{

		if(!cdg.resp){

			//print (gameObject.name);
			//print (cdg.correcto);
			//FUNCION PARA DETECTAR LA RESPUESTA
			if (gameObject.name == "Cartel1" && cdg.correcto == 1) 
			{
				cdg.resp = true;
				correcto();
			} 
			else 
			{
				if (gameObject.name == "Cartel2" && cdg.correcto == 2) 
				{
					cdg.resp = true;
					correcto();
				} 
				else 
				{

					if (gameObject.name == "Cartel3" && cdg.correcto == 3) 
					{
						cdg.resp = true;
						correcto();
					}

					//FALLO DE REPUESTA
					else 
					{
						error();

					}
				}
			}
		}
	}

	void correcto()
	{

		print ("correcto");

		cdg.aciertos++;
		cdg.aciertosSeguidos++;

		//ejecutarSonidoAcierto
		//GameObject.Find("SonidoAcierto").GetComponent<AudioSource>().Play();

		//GameObject.Find("Fantasma_Mascota").GetComponent<Animator>().Play("acierto");
		
		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("acierto");

		actualizarPuntuacion ();

		if (cdg.aciertosSeguidos == 3) 
		{
			cdg.combos++;
			cdg.aciertosSeguidos=0;
		}
	}
	void error()
	{
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		print ("error");

		cdg.fallos++;
		cdg.aciertosSeguidos=0;


		//ejecutar animacionError
		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("Fallo");
		
		//ejecutarSonidoFallo
		//GameObject.Find("SonidoFallo").GetComponent<AudioSource>().Play();

		if (cdg.fallos == 5) 
		{
			IfinJuego.SetActive (true);
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();

			monedasDado = GameObject.Find ("monedas");
			TmonedasDado = monedasDado.GetComponent<Text> ();

			cM.calcular_monedasDado ();
			cM.calcular_monedasGenerales ();

			if (cdg.aciertos >= 5) {
				Invoke ("ActivarEstrella1", 1.0f);
			}
			if (cdg.aciertos >= 10) {
				Invoke ("ActivarEstrella2", 2.0f);
			}
			if (cdg.aciertos >= 15) {
				Invoke ("ActivarEstrella3", 3.0f);
			}

			
			TpuntuacionFin.text = "\nACIERTOS: " + cdg.aciertos.ToString () + "\nCOMBOS: " + cdg.combos.ToString () + "\nLOGROS: ";

			TmonedasDado.text = cM.monedas_dado.ToString();

			resetearDado();

		} 
		else 
		{
			vidas [cdg.fallos-1].SetActive (false);
		}
	}

	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();

		Tpuntuacion.text = cdg.aciertos.ToString();
	}


	void ActivarEstrella1()
	{
		estrella1.SetActive (true);
	}
	void ActivarEstrella2()
	{
		estrella2.SetActive (true);
	}
	void ActivarEstrella3()
	{
		estrella3.SetActive (true);
	}
	void resetearDado()
	{
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		cdg.aciertos = 0;
		cdg.fallos = 0;
		cdg.aciertosSeguidos = 0;
		cdg.combos = 0;
		cM.monedas_dado = 0;
	}
}
