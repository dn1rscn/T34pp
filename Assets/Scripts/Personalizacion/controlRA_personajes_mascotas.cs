using UnityEngine;
using System.Collections;

public class controlRA_personajes_mascotas : MonoBehaviour 
{
	control_datosGlobalesPersonalizacion cdgp;

	public GameObject mascotas;
	public GameObject avatar;

	// Use this for initialization
	void Start () 
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		if (cdgp.mascotas == true) 
		{
			mascotas.SetActive (true);
			avatar.SetActive(false);
		} 
		else 
		{
			mascotas.SetActive (false);
			avatar.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
