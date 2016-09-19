using UnityEngine;
using System.Collections;

public class Actualizar_ninos : MonoBehaviour 
{
	//public GameObject[] AGeo_complementos;
	//public Material[] AColor_Pelo;
	//public Material[] AColor_Piernas;
	//public Material[] AColor_Piel;
	//public Material[] AColor_camiseta;
	public Texture[] AtexturasNiño;
	public Texture[] AtexturasNiña;

	public GameObject Niño;
	public GameObject Niña;
	
	//public Texture[] Atexture_Piel;
	//public Texture[] Atexture_camiseta;

	control_datosGlobalesPersonalizacion cdgp;

	// Use this for initialization
	void Start () 
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		if (cdgp.Sexo == 0) 
		{
			Niño.SetActive(true);
			Niña.SetActive(false);
			GameObject.FindWithTag ("Pelo").GetComponent<Renderer>().material.mainTexture = AtexturasNiño [cdgp.posicion_pelo];
			GameObject.FindWithTag("Piel").GetComponent<Renderer>().material.mainTexture=AtexturasNiño[cdgp.posicion_piel];
			GameObject.FindWithTag("Sudadera").GetComponent<Renderer>().material.mainTexture=AtexturasNiño[cdgp.posicion_camiseta];
			GameObject.FindWithTag("Piernas").GetComponent<Renderer>().material.mainTexture=AtexturasNiño[cdgp.posicion_camiseta];
		} 
		else if (cdgp.Sexo == 1) 
		{
			Niño.SetActive(false);
			Niña.SetActive(true);
			GameObject.FindWithTag ("Pelo").GetComponent<Renderer>().material.mainTexture = AtexturasNiña [cdgp.posicion_pelo];
			GameObject.FindWithTag("Piel").GetComponent<Renderer>().material.mainTexture=AtexturasNiña[cdgp.posicion_piel];
			GameObject.FindWithTag("Sudadera").GetComponent<Renderer>().material.mainTexture=AtexturasNiña[cdgp.posicion_camiseta];
			GameObject.FindWithTag("Piernas").GetComponent<Renderer>().material.mainTexture=AtexturasNiña[cdgp.posicion_camiseta];
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
