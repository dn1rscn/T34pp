using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ControlDatosGlobales_Mundo3D: MonoBehaviour {
		
	public static ControlDatosGlobales_Mundo3D cont;

	public int AvatarSeleccionado = 0;
	public int MascotaSeleccionada = 0;

	public bool islaBosque=false;
	public bool islaMec=false;
	public bool islaFant=false;

	public int posicionPersonaje = 1;
	//si posicionPersonaje = 1 , el prota aparecera en la posicion inicial del nivel
	//si posicionPersonaje = 2 , el prota aparecera en la posicion media del nivel
	//si posicionPersonaje = 3 , el prota aparecera en la posicion final del nivel
	//si posicionPersonaje tiene un valor sin determinar, iniciara en la posicion inicial del nivel
	public bool primeraVez_IslaDino=true;

	void Awake ()
	{

		if (cont == null) {
			cont = this;
			DontDestroyOnLoad (gameObject);
		} else if (cont != this) {
			Destroy(gameObject);
		}
	}

}
