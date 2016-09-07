using UnityEngine;
using System.Collections;

public class Actualizar_ninos : MonoBehaviour 
{
	//public GameObject[] AGeo_complementos;
	public Material[] AColor_Pelo;
	public Material[] AColor_Piernas;
	public Material[] AColor_Piel;
	public Material[] AColor_camiseta;

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
		} 
		else if (cdgp.Sexo == 1) 
		{
			Niño.SetActive(false);
			Niña.SetActive(true);
		}

		//AGeo_complementos [cdgp.posicion_complementos].SetActive (true);
		GameObject.Find ("Pelo").GetComponent<Renderer>().material = AColor_Pelo [cdgp.posicion_pelo];
		GameObject.Find("Piel").GetComponent<Renderer>().material=AColor_Piel[cdgp.posicion_piel];
		//GameObject.Find("Sudadera").GetComponent<Renderer>().material.mainTexture=Atexture_camiseta[cdgp.posicion_camiseta];
		GameObject.Find("Sudadera").GetComponent<Renderer>().material=AColor_camiseta[cdgp.posicion_camiseta];
		GameObject.Find("Piernas").GetComponent<Renderer>().material=AColor_Piernas[cdgp.posicion_camiseta];
		//AGeo_Piernas [cdgp.posicion_piernas].SetActive (true);
		//if (cdgp.posicion_complementos != 0) 
		//{
		//	AGeo_complementos [cdgp.posicion_complementos].GetComponent<Renderer> ().material.mainTexture = cdgp.Atexture_camiseta [cdgp.posicion_camiseta];
		//}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
