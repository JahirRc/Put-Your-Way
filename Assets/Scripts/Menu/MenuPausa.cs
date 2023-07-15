using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
	public GameObject menuPausa;
	private bool presionado = false;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Q) && presionado == false)
    	{
    		Time.timeScale = 0;
    		menuPausa.SetActive(true);
    		presionado = true;
    	}else if(Input.GetKeyDown(KeyCode.Q) && presionado == true){
    		Time.timeScale = 1;
    	    menuPausa.SetActive(false);
    	    presionado = false;
    	}
	}

	public void Volver()
	{
		Time.timeScale = 1;
    	menuPausa.SetActive(false);
    	presionado = false;
	}

	public void MenuPrincipal()
	{
		Time.timeScale = 1;
    	menuPausa.SetActive(false);
    	presionado = false;
		SceneManager.LoadScene("Menu");
	}

	public void Salir()
	{
		Application.Quit();
	}
}
