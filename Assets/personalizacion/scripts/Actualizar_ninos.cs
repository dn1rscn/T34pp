using UnityEngine;
using System.Collections;

public class Actualizar_ninos : MonoBehaviour 
{
	//public GameObject[] AGeo_complementos;
	public GameObject[] AGeo_Pelo;
	public GameObject[] AGeo_Piernas;
	
	public Texture[] Atexture_Piel;
	public Texture[] Atexture_camiseta;

	control_datosGlobalesPersonalizacion cdgp;

	// Use this for initialization
	void Start () 
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		//AGeo_complementos [cdgp.posicion_complementos].SetActive (true);
		AGeo_Pelo [cdgp.posicion_pelo].SetActive (true);
		GameObject.Find("Piel").GetComponent<Renderer>().material.mainTexture=Atexture_Piel[cdgp.posicion_piel];
		GameObject.Find("Sudadera").GetComponent<Renderer>().material.mainTexture=Atexture_camiseta[cdgp.posicion_camiseta];
		AGeo_Piernas [cdgp.posicion_piernas].SetActive (true);
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
