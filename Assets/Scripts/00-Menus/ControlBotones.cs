using UnityEngine;
using System.Collections;

public class ControlBotones : MonoBehaviour 
{
	public string Mundo;

	public void Exit ()
	{
		Application.Quit();
	}
	public void Facebook ()
	{
		Application.OpenURL ("https://www.facebook.com/PrometeoStudios-949884905102365");
	}
	public void twitter ()
	{
		Application.OpenURL ("https://twitter.com/PrometeoStudios");
	}
}
