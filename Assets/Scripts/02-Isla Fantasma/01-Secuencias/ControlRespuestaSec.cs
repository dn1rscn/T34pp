using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ControlRespuestaSec : MonoBehaviour 
{
	public Sprite primera;
	public Sprite segunda;
	public Sprite tercera;
	public GameObject P1;
	public GameObject P2;
	public GameObject P3;
	GameObject ctrlsecuencias;
	ControlSecuencias cs;
	
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
	
	GameObject monedasSecuencia;
	Text TmonedasSecuencia;

	GameObject puntuacionfin;
	Text TpuntuacionFin;

	// Use this for initialization
	void Start () 
	{
		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();
		//BotonVolverGrande.SetActive(false);
		actualizarPuntuacion ();
		IfinJuego.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	

	public void click()
	{
		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();

		if (gameObject.GetComponent<Image> ().sprite.name == "Primera") 
		{
			P1.GetComponent<Image> ().sprite = primera;
			Destroy(gameObject);
			cs.p1=true;
		}
		else if (gameObject.GetComponent<Image> ().sprite.name == "Segunda"&&cs.p1==true) 
		{
			P2.GetComponent<Image> ().sprite = segunda;
			Destroy(gameObject);
			cs.p2=true;
		}
		else if (gameObject.GetComponent<Image> ().sprite.name == "Tercera"&&cs.p1==true&&cs.p2==true) 
		{
			P3.GetComponent<Image> ().sprite = tercera;
			Destroy(gameObject);
			cs.p3=true;

			Invoke("finjuego",2);

			//HAS ACERTADO
			GameObject.Find("SonidoAcierto").GetComponent<AudioSource>().Play();
			
			//ejecutar animacionAcierto
			GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("acierto");
			//GameObject.Find("Boton_Volver").SetActive(false);

			Debug.Log("finjuego1");
			finjuego();

		}
		else 
		{
			print("fallo");

			cs.intentos++;
			actualizarPuntuacion();

			//ejecutar animacionError
			GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("Fallo");
			
			//ejecutarSonidoFallo
			GameObject.Find("SonidoFallo").GetComponent<AudioSource>().Play();
		}
	}

	void finjuego()
	{
		Debug.Log("finjuego2");
		IfinJuego.SetActive(true);

		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasSecuencia = GameObject.Find ("monedas");
		TmonedasSecuencia = monedasSecuencia.GetComponent<Text> ();
		
		cM.calcular_monedasSecuencia ();
		cM.calcular_monedasGenerales ();
		
		if (cs.intentos == 3) 
		{
			ActivarEstrella1();
			SiguienteSecuencia.SetActive(true);
			if(cs.Secuencia<cs.Asecuencias.Length)
			{
				cs.Asecuencias[cs.Secuencia]=true;
			}
		}
		if (cs.intentos == 2) 
		{
			ActivarEstrella1();
			ActivarEstrella2();
			SiguienteSecuencia.SetActive(true);
			if(cs.Secuencia<cs.Asecuencias.Length)
			{
				cs.Asecuencias[cs.Secuencia]=true;
			}
			//desbloquearportal
		}
		if (cs.intentos == 1) {
			ActivarEstrella1();
			ActivarEstrella2();
			ActivarEstrella3();
			SiguienteSecuencia.SetActive(true);
			if(cs.Secuencia<cs.Asecuencias.Length)
			{
				cs.Asecuencias[cs.Secuencia]=true;
			}
		}
		
		
		TpuntuacionFin.text = "\nINTENTOS: " + cs.intentos.ToString () + "\nLOGROS: ";
		
		TmonedasSecuencia.text = cM.monedas_secuencia.ToString();

		resetar_secuencias ();

	}

	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();
		
		Tpuntuacion.text = cs.intentos.ToString();
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

	public void resetar_secuencias()
	{
		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();

		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		cs.intentos = 1;
		cM.monedas_secuencia = 0;
		cs.p1 = false;
		cs.p2 = false;
		cs.p3 = false;
	}
	
}
