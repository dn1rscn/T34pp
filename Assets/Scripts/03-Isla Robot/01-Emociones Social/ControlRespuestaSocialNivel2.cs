using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaSocialNivel2 : MonoBehaviour 
{
	ControlAleatorioSocialNivel2 CAN2;

	ControlEmociones CE;
	
	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;
	
	public GameObject IfinJuego;
	
	//public GameObject BotonVolverGrande;
	
	//public GameObject SiguienteSituacion;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasSocialNivel2;
	Text TmonedasSocialNivel2;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CE.respuesta = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.respuesta == false) 
		{
			CAN2 = GameObject.Find ("ctrlAleatorio").GetComponent<ControlAleatorioSocialNivel2> ();
			switch (CAN2.PreguntaAleat) {

			case 1:
				if (gameObject.GetComponent<Image> ().sprite.name == "Enfado") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
			case 2:
				if (gameObject.GetComponent<Image> ().sprite.name == "Asco") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
			case 3:
				if (gameObject.GetComponent<Image> ().sprite.name == "Verguenza") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
			}
		}
	}
	void correcto()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		print ("correcto");
		IfinJuego.SetActive(true);
		
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		
		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasSocialNivel2 = GameObject.Find ("monedas");
		TmonedasSocialNivel2 = monedasSocialNivel2.GetComponent<Text> ();
		
		cM.calcular_monedaSocialNivel1 ();
		cM.calcular_monedasGenerales ();
		
		if (CE.fallos == 0) 
		{
			estrella1.SetActive (true);
			estrella2.SetActive (true);
			estrella3.SetActive (true);
		} 
		else 
		{
			if (CE.fallos == 1) 
			{
				estrella1.SetActive (true);
				estrella2.SetActive (true);
			} 
			else 
			{
				estrella1.SetActive (true);
			}
		}
		
		//SiguienteSituacion.SetActive (true);
		
		TpuntuacionFin.text = "\nCOMPLETADO";
		
		TmonedasSocialNivel2.text = cM.monedasSocialNivel1.ToString();

		CE.fallos = 0;
		cM.monedasSocialNivel1 = 0;
		CE.respuesta = true;
		
		
	}
	void error()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		print ("error");
		
		CE.fallos++;
	}
}
