using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control_FinJuego : MonoBehaviour 
{
	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	public GameObject IfinJuego;

	GameObject puntuacionfin;
	Text TpuntuacionFin;

	// Use this for initialization
	void Start () 
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void finJuego()
	{
		IfinJuego.SetActive (true);

		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();

		TpuntuacionFin.text = "ACIERTOS: " + cdg.aciertos.ToString() + "/n COMBOS: "+cdg.combos.ToString()+ "/n LOGROS: ";
	}
}
