using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaSocialNivel3 : MonoBehaviour 
{
	controlRespAleatoria CRA;
	
	ControlEmociones CE;
	
	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;
	
	public GameObject IfinJuego;
	
	//public GameObject BotonVolverGrande;
	
	public GameObject SiguienteSituacion;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasSocialNivel1;
	Text TmonedasSocialNivel1;
	
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
	
	public void respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.respuesta == false) {
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			//print (gameObject.GetComponent<Image> ().sprite);
			print (CRA.RespuestaAleat);
			print (gameObject.name);
		
			if (gameObject.name == "respuesta1" && CRA.RespuestaAleat == 1) {
				//cdg.resp = true;
				correcto ();
			} else { 
				if (gameObject.name == "respuesta2" && CRA.RespuestaAleat == 2) {
					//cdg.resp = true;
					correcto ();
				} else {
					error ();
				}
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
		
		monedasSocialNivel1 = GameObject.Find ("monedas");
		TmonedasSocialNivel1 = monedasSocialNivel1.GetComponent<Text> ();
		
		cM.calcular_monedaSocialNivel1 ();
		cM.calcular_monedasGenerales ();
		if (CE.fallos == 0) 
		{
			estrella1.SetActive (true);
			estrella2.SetActive (true);
			estrella3.SetActive (true);
			
			SiguienteSituacion.SetActive (true);
			if(CE.EjercicioSocial<CE.ASocialNivel3.Length)
			{
				CE.ASocialNivel3[CE.EjercicioSocial]=true;
			}
		} 
		else 
		{
			if (CE.fallos == 1) 
			{
				estrella1.SetActive (true);
				estrella2.SetActive (true);
				
				SiguienteSituacion.SetActive (true);
				if(CE.EjercicioSocial<CE.ASocialNivel3.Length)
				{
					CE.ASocialNivel3[CE.EjercicioSocial]=true;
				}
			} 
			else 
			{
				estrella1.SetActive (true);
				
				SiguienteSituacion.SetActive (true);
				if(CE.EjercicioSocial<CE.ASocialNivel3.Length)
				{
					CE.ASocialNivel3[CE.EjercicioSocial]=true;
				}
			}
		}
		
		
		TpuntuacionFin.text = "\nCOMPLETADO";
		
		TmonedasSocialNivel1.text = cM.monedasSocialNivel1.ToString();
		
		
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
