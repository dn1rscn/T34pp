using UnityEngine;
using System.Collections;

public class ControlSecuencias : MonoBehaviour 
{
	public bool p1=false;
	public bool p2=false;
	public bool p3=false;
	public int intentos=1;
	public bool[] Asecuencias;
	public int posicion;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this);
		/*for (i=0; i<Asecuencias.Length; i++) 
		{
			if(Asecuencias[i]==true)
			{
				Asecuencias[i].SetActive (true);
			}
			else if(Asecuencias[i]==false)
			{
				Asecuencias[i].SetActive(false);
			}
		}*/
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
