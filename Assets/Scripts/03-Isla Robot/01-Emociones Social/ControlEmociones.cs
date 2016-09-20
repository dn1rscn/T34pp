using UnityEngine;
using System.Collections;

public class ControlEmociones : MonoBehaviour 
{
	public int fallos=0;
	public int aciertos=0;
	public bool[] ASocialNivel1;
	public bool[] ASocialNivel3;
	public bool[] AEmociones;
	public int EjercicioSocial=0;
	public int NivelEmociones=0;

	public bool respuesta;
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
