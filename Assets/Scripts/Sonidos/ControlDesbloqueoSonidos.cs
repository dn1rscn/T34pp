using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlDesbloqueoSonidos : MonoBehaviour
	{

	ControlSonidos CS;
	public Sprite[] imagenes_unlocked;
	public Sprite[] imagenes_Locked;


	public GameObject[] Acontrol_Sonidos;
	int i;

	// Use this for initialization
	void Start () 
	{
		CS = GameObject.Find ("ctrSonidos").GetComponent<ControlSonidos> ();
		
		for (i=0; i<CS.ASonidos.Length; i++) 
		{
			if(CS.ASonidos[i]==true)
			{
				Acontrol_Sonidos[i].GetComponent<Image>().sprite = imagenes_unlocked[i];
				Acontrol_Sonidos[i].GetComponent<Button>().enabled=true;
			}
			else if(CS.ASonidos[i]==false)
			{
				Acontrol_Sonidos[i].GetComponent<Image>().sprite=imagenes_Locked[i];
				Acontrol_Sonidos[i].GetComponent<Button>().enabled=false;
			}
		}
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
