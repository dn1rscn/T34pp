using UnityEngine;
using System.Collections;

public class Control_monedas : MonoBehaviour 
{
	public static Control_monedas cont;

	GameObject ctrlsecuencias;
	ControlSecuencias cs;
	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	ControlSonidos CS;
	controlEjercicioCanastas cec;

	ControlEmociones CE;

	public int monedas=0;

	public int monedas_dado;
	int monedas_combos;
	int monedas_aciertos;

	public int monedas_secuencia;
	int monedas_intentos;

	public int MonedasGenerales_canasta;
	int monedas_canastas;

	public int MonedasSonidos;
	int monedasAciertos_Sonidos;

	public int monedasSocialNivel1;

	public int monedasEmociones;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void Awake ()
	{
		
		if (cont == null) {
			cont = this;
			DontDestroyOnLoad (gameObject);
		} else if (cont != this) {
			Destroy(gameObject);
		}
	}

	public void calcular_monedasGenerales()
	{
		monedas = monedas + monedas_dado + monedas_secuencia + MonedasGenerales_canasta + MonedasSonidos + monedasSocialNivel1;
	}

	public void calcular_monedasDado()
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();

		monedas_combos = cdg.combos * 20;
		monedas_aciertos = cdg.aciertos * 3;
		monedas_dado = monedas_combos + monedas_aciertos;
	}

	public void calcular_monedasSecuencia()
	{
		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();

		switch (cs.intentos) 
		{
			case 1:
				monedas_intentos=200;
				break;
			case 2:
				monedas_intentos=100;
				break;
			case 3:
				monedas_intentos=50;
				break;
			case 4:
				monedas_intentos=10;
				break;
		}

		monedas_secuencia = monedas_intentos;

	}
	public void calcular_monedasCanasta()
	{
		cec = GameObject.Find ("gameFlow").GetComponent<controlEjercicioCanastas> ();

		monedas_canastas = cec.puntuacionJugador * 3;
		MonedasGenerales_canasta = monedas_canastas + 20;

	}
	public void calcular_monedasSonidos()
	{

		CS = GameObject.Find ("ctrSonidos").GetComponent<ControlSonidos> ();

		monedasAciertos_Sonidos = CS.aciertos * 3;
		MonedasSonidos = monedasAciertos_Sonidos;
	}
	public void calcular_monedaSocialNivel1()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.fallos == 0) 
		{
			monedasSocialNivel1 = 100;
		} 
		else 
		{
			monedasSocialNivel1 = 30;
		}
	}
	public void calcular_monedasEmocionesNivel1()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.fallos <= 3) 
		{
			monedasEmociones = 300 - (100 * CE.fallos);
		}
	}
	public void calcular_monedasEmocionesNivel2()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		if (CE.fallos <= 5) 
		{
			monedasEmociones = 500 - (100 * CE.fallos);
		}
	}
	public void calcular_monedasEmocionesNivel3()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		if (CE.fallos <= 7) 
		{
			monedasEmociones = 700 - (100 * CE.fallos);
		}
	}
}
