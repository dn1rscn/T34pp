using UnityEngine;
using System.Collections;

public class ControlEmociones : MonoBehaviour 
{
	public int fallos=0;
	public int aciertos=0;
	public bool[] ASocial;
	public bool[] AEmociones;
	public int posicion=0;
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
