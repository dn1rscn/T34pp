using UnityEngine;
using System.Collections;

public class Control_monedas : MonoBehaviour 
{
	public static Control_monedas cont;

	GameObject ctrlsecuencias;
	ControlSecuencias cs;
	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	controlEjercicioCanastas cec;

	public int monedas=0;

	public int monedas_dado;
	int monedas_combos;
	int monedas_aciertos;

	public int monedas_secuencia;
	int monedas_intentos;

	public int MonedasGenerales_canasta;
	int monedas_canastas;

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
		monedas = monedas + monedas_dado + monedas_secuencia + MonedasGenerales_canasta;
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
	public void calcular_monedasLogros()
	{
	}
}
