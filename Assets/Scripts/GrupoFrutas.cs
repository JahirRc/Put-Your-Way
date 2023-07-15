using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrupoFrutas : MonoBehaviour
{
	public GameObject meta;

	public int siguienteEscena;

	public GameObject panelFinal;

	public GameObject botonFinal;

	void Start()
	{
		siguienteEscena = SceneManager.GetActiveScene().buildIndex + 1;
	}

	public void todasManzanasRecolec()
	{
		if(transform.childCount==1)
		{
			Debug.Log("No quedan manzanas, Victoria");
			//GameObject.FindGameObjectsWithTag("Meta");
			//meta.SetActive(true);
			if(SceneManager.GetActiveScene().buildIndex == 7)
			{
				Debug.Log("Ganaste el juego");

			}else{
				SceneManager.LoadScene(siguienteEscena);

				if(siguienteEscena > PlayerPrefs.GetInt("nivel"))
				{
					PlayerPrefs.SetInt("nivel", siguienteEscena);
				}
			}

		}
	}

}

