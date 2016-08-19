using UnityEngine;
using System.Collections;

public class ControlDado2 : MonoBehaviour 
{
	Rigidbody rbd;

	public float fuerzaSalto;

	float fuerzaGiroX;
	float fuerzaGiroY;
	float fuerzaGiroZ;

	Renderer miRender;

	int PicAleat;

	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	ControlCartel CCP;
	GameObject cartel_P;

	public float tiempo;

	public Material[] pictogramas_dado;


	bool lanzar = true;


	void Start () 
	{
		DGlobales = GameObject.Find ("DatosGlobales");			
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();
		
		cartel_P = GameObject.Find ("cartel_palabras");
		CCP = cartel_P.GetComponent<ControlCartel> ();

		rbd = GetComponent<Rigidbody> ();

		cdg.resp=true;

	}

	void salto()			//funcion salto dado
	{
		rbd.AddForce (0f, fuerzaSalto, 0f); 						//fuerza para el salto
		rbd.AddTorque (fuerzaGiroX, fuerzaGiroY, fuerzaGiroZ); 		//fuerza de giro
	}


	void OnMouseDown ()
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();

		cartel_P = GameObject.Find ("cartel_palabras");
		CCP = cartel_P.GetComponent<ControlCartel> ();

		//LANZAMIENTO
		if (lanzar == true && cdg.resp==true) 				//si no hay respuesta y el dado no esta en el suelo no se puede lanzar			
		{
			cdg.PicAleat = Random.Range (0, pictogramas_dado.Length); 			//pictograma aleatorio

			fuerzaGiroX = Random.Range (200f, 200000f);      			//fuerza de giro (x, y, z) aleatorias
			fuerzaGiroY = Random.Range (200f, 200000f);
			fuerzaGiroZ = Random.Range (200f, 200000f);

			miRender = GetComponent<Renderer> ();

			Invoke("pictogramaAleatorio",tiempo);			//pictograma aleatorio

			salto ();

			CCP.carteles ();
			lanzar = false;			//dado no esta en suelo
			cdg.resp = false;		//no hay respuesta
		}
		//MENSAJE CUANDO NO HAY RESPUESTA
		else 
		{
			print ("no respuesta");	
		}

	}

	//SUELO
	void OnCollisionEnter (Collision coli)			//detectamos que el dado esta en el suelo
	{
		if (coli.gameObject.name == "Suelo") 
		{
			lanzar = true;
		} 
	}

	void pictogramaAleatorio()
	{
		miRender.sharedMaterial = pictogramas_dado [cdg.PicAleat];			//cambio de pictograma DEL DADO Y DE LA RESPUESTA CORRECTA
		
	}

}
