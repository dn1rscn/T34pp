using UnityEngine;
using System.Collections;

public class control_ventanas_personalizar : MonoBehaviour 
{
	control_datosGlobalesPersonalizacion cdgp;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void cambiar_complementos()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		cdgp.complementos = true;
		cdgp.pelo = false;
		cdgp.piel = false;
		cdgp.camiseta = false;
		cdgp.piernas = false;

	}
	public void cambiar_pelo()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		cdgp.complementos = false;
		cdgp.pelo = true;
		cdgp.piel = false;
		cdgp.camiseta = false;
		cdgp.piernas = false;
	}
	public void cambiar_piel()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		cdgp.complementos = false;
		cdgp.pelo = false;
		cdgp.piel = true;
		cdgp.camiseta = false;
		cdgp.piernas = false;
	}
	public void cambiar_camiseta()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		cdgp.complementos = false;
		cdgp.pelo = false;
		cdgp.piel = false;
		cdgp.camiseta = true;
		cdgp.piernas = false;
	}
	public void cambiar_piernas()
	{
		cdgp = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		cdgp.complementos = false;
		cdgp.pelo = false;
		cdgp.piel = false;
		cdgp.camiseta = false;
		cdgp.piernas = true;
	}
}
