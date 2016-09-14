using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Botones_interfaz : MonoBehaviour 
{
	Animator anim;
	GameObject scroll_inv;
	bool INV_Estado;

	GameObject Bpuntuacion;
	Text Tpuntuacion;
	Control_monedas cM;
	GameObject ControlMonedas;

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	// Use this for initialization
	void Start () 
	{
		//scroll_inv = GameObject.Find ("inventario");
		//anim = scroll_inv.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Mapa()
	{
		Application.LoadLevel ("escenaMapaGeneral");
	}
	public void IM()
	{
		Application.LoadLevel ("escenaIslaMecanica_mapa");
	}
	public void IB()
	{
		Application.LoadLevel ("escenaIslaDino_mapa");
	}
	public void RAIM()
	{
		Application.LoadLevel ("escenaRA_IM");
	}
	public void RAIB()
	{
		Application.LoadLevel ("escenaRA_IB");
	}
	public void volver()
	{
		Application.LoadLevel ("escenaInterfaz");
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

	void actualizar_Monedas()
	{
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		Bpuntuacion=GameObject.Find ("Text_puntuacion");
		Tpuntuacion=Bpuntuacion.GetComponent<Text>();
		
		Tpuntuacion.text=cM.monedas.ToString();
	}
}
