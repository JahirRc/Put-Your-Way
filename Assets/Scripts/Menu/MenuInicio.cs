using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
	public int nivel;

	public void irJugar()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + nivel);
	}

	public void irSalir()
	{
		Debug.Log("Saliendo");
		Application.Quit();
	}
}
