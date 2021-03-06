﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Botones_interfazMapa : MonoBehaviour 
{

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	public GameObject Fondo_IBosque;
	public GameObject Fondo_IFantasma;
	public GameObject Fondo_IRobot;

	public float Tiempo;

	public bool seleccion;

	public GameObject Loading;

	// Use this for initialization
	void Start () 
	{
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		seleccion = false;
		Loading.SetActive(false);

		if (CDG_Mundo3D.islaBosque == true) 
		{
			Fondo_IBosque.SetActive (true);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (false);
		}
		if (CDG_Mundo3D.islaMec == true) 
		{
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (true);
			Fondo_IRobot.SetActive (false);
		}
		if (CDG_Mundo3D.islaFant == true) 
		{
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void Volver_mundo ()
	{
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();
		if (CDG_Mundo3D.islaBosque == true) 
		{
			Application.LoadLevel ("03_1-Mundo3D_IslaDino");
		}
		if (CDG_Mundo3D.islaMec == true) 
		{
			Application.LoadLevel ("04_1-Mundo3D_IslaRobot");
		}
		if (CDG_Mundo3D.islaFant == true) 
		{
			Application.LoadLevel ("05_1-Mundo3D_IslaFantasma");
		}
	}
	public void Isla_Bosque()
	{
		if (seleccion == false) 
		{
			print (Tiempo);
			Fondo_IBosque.SetActive (true);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (false);

			seleccion=true;
			Loading.SetActive(true);

			Invoke ("ToBosque", Tiempo);
		}
	}
	public void Isla_FAntasma()
	{
		if (seleccion == false) 
		{
			print (Tiempo);
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (true);
			Fondo_IRobot.SetActive (false);

			seleccion=true;
			Loading.SetActive(true);

			Invoke ("ToFantasma", Tiempo);
		}

	}
	public void Isla_Robot()
	{
		if (seleccion == false) 
		{
			print (Tiempo);
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (true);

			seleccion = true;
			Loading.SetActive(true);

			Invoke ("ToRobot", Tiempo);
		}

	}

	void ToBosque()
	{
		Debug.Log ("A Isla Bosque");
	}
	void ToFantasma()
	{
		Debug.Log ("A Isla Fantasma");
	}
	void ToRobot()
	{
		Debug.Log ("A Isla Robot");
	}
}
