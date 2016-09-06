using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlDatosGlobales_PICTOGRAMAS : MonoBehaviour 
{
	public int PicAleat;
	//public int PicAleat_cartel1;
	//public int PicAleat_cartel2;
	//public int PicAleat_cartel3;
	//public int PicAleat_dado;
	public int cart1=0;
	public int cart2=0;
	public int cart3=0;
	public int correcto=0;
	public bool resp=false;
	public int aciertos=0;
	public int fallos=0;
	public int aciertosSeguidos=0;
	public int combos=0;

	//public Material [] palabras;
	public Sprite [] pictogramas;
	public Material[] ImDado;

	public GameObject Cartel1;
	public GameObject Cartel2;
	public GameObject Cartel3;

	// Use this for initialization
	void Start () 
	{
		//PicAleat_cartel1 = 0;
		//PicAleat_cartel2 = 0;
		//PicAleat_cartel3 = 0;
		//PicAleat_dado = 0;
		//DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
