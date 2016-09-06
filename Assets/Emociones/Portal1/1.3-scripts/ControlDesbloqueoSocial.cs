using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlDesbloqueoSocial : MonoBehaviour 
{
	ControlEmociones CE;
	public Sprite[] imagenes_unlocked;
	public Sprite[] imagenes_Locked;

	public GameObject[] Acontrol_Social;
	int i;

	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		for (i=0; i<CE.ASocial.Length; i++) 
		{
			if(CE.ASocial[i]==true)
			{
				Acontrol_Social[i].GetComponent<Image>().sprite = imagenes_unlocked[i];
				Acontrol_Social[i].GetComponent<Button>().enabled=true;
			}
			else if(CE.ASocial[i]==false)
			{
				Acontrol_Social[i].GetComponent<Image>().sprite=imagenes_Locked[i];
				Acontrol_Social[i].GetComponent<Button>().enabled=false;
			}
		}

		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
