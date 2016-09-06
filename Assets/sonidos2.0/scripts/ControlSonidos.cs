using UnityEngine;
using System.Collections;

public class ControlSonidos : MonoBehaviour 
{
	//public int nivel=0;
	public int fallos=0;
	public int aciertos=0;
	public bool[] ASonidos;
	public int posicion;
	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
