using UnityEngine;
using System.Collections;

public class Control_personalizacion : MonoBehaviour 
{
	control_datosGlobalesPersonalizacion cdgp;
	//Actualizar_mascotas CMasc;
	Actualizar_ninos CNiños;

	//Renderer piel;
	//public GameObject Geo_piel;

	// Use this for initialization
	void Start () 
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		//CMasc = GameObject.Find ("Grupo_Mascotas").GetComponent<Actualizar_mascotas> ();
		CNiños = GameObject.Find ("prota_new2").GetComponent<Actualizar_ninos> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public void cambiar_sexo()
	{
		if (cdgp.Sexo == 0) 
		{
			cdgp.Sexo=1;

			CNiños.Niño.SetActive(false);
			CNiños.Niña.SetActive(true);
		} 
		else if (cdgp.Sexo == 1) 
		{
			cdgp.Sexo=0;
			
			CNiños.Niño.SetActive(true);
			CNiños.Niña.SetActive(false);
		}

	}
	public void cambiar_der()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
//*****************************COMPLEMENTOS*****************************************
		/*if (cdgp.complementos == true) 
		{
			if (cdgp.posicion_complementos == CNiños.AGeo_complementos.Length-1) 
			{
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (false);
				cdgp.posicion_complementos = 0;
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (true);

			}
			else
			{
				cdgp.posicion_complementos++;
				CNiños.AGeo_complementos [cdgp.posicion_complementos - 1].SetActive (false);
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (true);
				CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];

			}
		}*/
//*****************************PELO*****************************************
		if (cdgp.pelo == true) 
		{
			if (cdgp.posicion_pelo == CNiños.AColor_Pelo.Length-1) 
			{

				cdgp.posicion_pelo = 0;
				GameObject.Find ("Pelo").GetComponent<Renderer>().material = CNiños.AColor_Pelo [cdgp.posicion_pelo];
			} 
			else
			{
				cdgp.posicion_pelo++;
				GameObject.Find ("Pelo").GetComponent<Renderer>().material = CNiños.AColor_Pelo [cdgp.posicion_pelo];
			}
		}

//*****************************PIEL*****************************************
		if (cdgp.piel == true) 
		{
			if (cdgp.posicion_piel == cdgp.Atexture_Piel.Length-1) 
			{
				cdgp.posicion_piel = 0;
				GameObject.Find("Piel").GetComponent<Renderer>().material=CNiños.AColor_Piel[cdgp.posicion_piel];
			} 
			else
			{
				cdgp.posicion_piel++;
				GameObject.Find("Piel").GetComponent<Renderer>().material=CNiños.AColor_Piel[cdgp.posicion_piel];
			}
		}
//*****************************CAMISETA*****************************************
		if (cdgp.camiseta == true) 
		{
			if (cdgp.posicion_camiseta == cdgp.Atexture_camiseta.Length-1) 
			{
				cdgp.posicion_camiseta = 0;
				GameObject.Find("Sudadera").GetComponent<Renderer>().material=CNiños.AColor_camiseta[cdgp.posicion_camiseta];
				//CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];
			} 
			else
			{
				cdgp.posicion_camiseta++;
				GameObject.Find("Sudadera").GetComponent<Renderer>().material=CNiños.AColor_camiseta[cdgp.posicion_camiseta];
				//CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];
			}
		}
//*****************************PIERNAS*****************************************
		if (cdgp.piernas == true) 
		{
			if (cdgp.posicion_piernas == CNiños.AColor_Piernas.Length-1) 
			{
				cdgp.posicion_piernas = 0;
				GameObject.Find("Piernas").GetComponent<Renderer>().material=CNiños.AColor_Piernas[cdgp.posicion_camiseta];
			} 
			else
			{
				cdgp.posicion_piernas++;
				GameObject.Find("Piernas").GetComponent<Renderer>().material=CNiños.AColor_Piernas[cdgp.posicion_camiseta];
			}
		}
//*****************************MASCOTAS*****************************************
		/*if (cdgp.mascotas == true) 
		{
			if (cdgp.mascota == CMasc.Amascotas.Length-1) 
			{
				CMasc.Amascotas [cdgp.mascota].SetActive (false);
				cdgp.mascota = 0;
				CMasc.Amascotas [cdgp.mascota].SetActive (true);
			} 
			else
			{
				cdgp.mascota++;
				CMasc.Amascotas [cdgp.mascota - 1].SetActive (false);
				CMasc.Amascotas [cdgp.mascota].SetActive (true);
			}
		}*/


	}

	public void cambiar_izq()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
//*****************************COMPLEMENTOS*****************************************
		/*if (cdgp.complementos == true) 
		{
			if (cdgp.posicion_complementos == 0) 
			{
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (false);
				cdgp.posicion_complementos = CNiños.AGeo_complementos.Length-1;
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (true);
			} 
			else 
			{
				cdgp.posicion_complementos--;
				CNiños.AGeo_complementos [cdgp.posicion_complementos + 1].SetActive (false);
				CNiños.AGeo_complementos [cdgp.posicion_complementos].SetActive (true);
				CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];
			}
		}*/
//*****************************PELO*****************************************
		if (cdgp.pelo == true) 
		{
			if (cdgp.posicion_pelo == 0) 
			{
				cdgp.posicion_pelo =CNiños.AColor_Pelo.Length-1;
				GameObject.Find ("Pelo").GetComponent<Renderer>().material = CNiños.AColor_Pelo [cdgp.posicion_pelo];
			} 
			else 
			{
				cdgp.posicion_pelo--;
				GameObject.Find ("Pelo").GetComponent<Renderer>().material = CNiños.AColor_Pelo [cdgp.posicion_pelo];

			}
		}
//*****************************PIEL*****************************************
		if (cdgp.piel == true) 
		{
			if (cdgp.posicion_piel == 0) 
			{
				cdgp.posicion_piel = cdgp.Atexture_Piel.Length-1;
				GameObject.Find("Piel").GetComponent<Renderer>().material=CNiños.AColor_Piel[cdgp.posicion_piel];
			} 
			else
			{
				cdgp.posicion_piel--;
				GameObject.Find("Piel").GetComponent<Renderer>().material=CNiños.AColor_Piel[cdgp.posicion_piel];
			}
		}
//*****************************CAMISETA*****************************************
		if (cdgp.camiseta == true) 
		{
			if (cdgp.posicion_camiseta == 0) 
			{
				cdgp.posicion_camiseta = cdgp.Atexture_camiseta.Length-1;
				GameObject.Find("Sudadera").GetComponent<Renderer>().material=CNiños.AColor_camiseta[cdgp.posicion_camiseta];
				//CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];
			} 
			else
			{
				cdgp.posicion_camiseta--;
				GameObject.Find("Sudadera").GetComponent<Renderer>().material=CNiños.AColor_camiseta[cdgp.posicion_camiseta];
				//CNiños.AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer>().material.mainTexture=cdgp.Atexture_camiseta[cdgp.posicion_camiseta];
			}
		}
//*****************************PIERNAS*****************************************
		if (cdgp.piernas == true) 
		{
			if (cdgp.posicion_piernas == 0) 
			{
				cdgp.posicion_piernas = CNiños.AColor_Piernas.Length-1;
				GameObject.Find("Piernas").GetComponent<Renderer>().material=CNiños.AColor_Piernas[cdgp.posicion_camiseta];
			} 
			else 
			{
				cdgp.posicion_piernas--;
				GameObject.Find("Piernas").GetComponent<Renderer>().material=CNiños.AColor_Piernas[cdgp.posicion_camiseta];
			}
		}
//*****************************MASCOTAS*****************************************
		/*if (cdgp.mascotas == true) 
		{
			if (cdgp.mascota == 0) 
			{
				CMasc.Amascotas [cdgp.mascota].SetActive (false);
				cdgp.mascota = CMasc.Amascotas.Length-1;
				CMasc.Amascotas [cdgp.mascota].SetActive (true);
			} 
			else 
			{
				cdgp.mascota--;
				CMasc.Amascotas [cdgp.mascota + 1].SetActive (false);
				CMasc.Amascotas [cdgp.mascota].SetActive (true);
			}
		}*/

	}
}
