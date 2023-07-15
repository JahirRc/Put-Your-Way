using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
	//Para detectar si entramos al área de diálogos
	private bool estaEnRango;

	//Para ver si empezó el diálogo
	private bool empezoDialogo;

	//Para contar las líneas
	private int index;

	//Para la rapidez con la que se muestra el diálogo
	private float tiempoEscritura = 0.1f;

	//Para todas las líneas de diálogo
	[SerializeField, TextArea(4,6)] private string[] lineasDialogo;

	//Variable para mostrar el panel de diálogo
	[SerializeField] private GameObject panelDialogo;

	//Variable para mostrar el texto
	[SerializeField] private TMP_Text textoDialogo;

	public GameObject mago;

	public GameObject boton1;
	public GameObject boton2;
	public GameObject boton3;
	public GameObject slider;


	void Update()
	{
		if(estaEnRango && Input.GetKeyDown(KeyCode.H))
		{
			if(!empezoDialogo)
			{
				EmpezarDialogo();
			}else if(textoDialogo.text == lineasDialogo[index])
			{
				SiguienteLinea();
			}
			else
			{
				StopAllCoroutines();
				textoDialogo.text = lineasDialogo[index];
			}
		}

	}

	private void EmpezarDialogo()
	{
		empezoDialogo = true;
		panelDialogo.SetActive(true);
		mago.SetActive(true);
		boton1.SetActive(false);
		boton2.SetActive(false);
		boton3.SetActive(false);
		slider.SetActive(false);
		index = 0;
		Time.timeScale = 0f;
		StartCoroutine(MostrarDialogo());
	}

	private void SiguienteLinea()
	{
		index++;
		if(index < lineasDialogo.Length)
		{
			StartCoroutine(MostrarDialogo());
		}else{
			empezoDialogo = false;
			panelDialogo.SetActive(false);
			mago.SetActive(false);
			boton1.SetActive(true);
		    boton2.SetActive(true);
		    boton3.SetActive(true);
		    slider.SetActive(true);
			Time.timeScale = 1f;
		}
	}

	private IEnumerator MostrarDialogo()
	{
		textoDialogo.text = string.Empty;
		foreach(char ch in lineasDialogo[index])
		{
			textoDialogo.text += ch;
			yield return new WaitForSecondsRealtime(tiempoEscritura);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("Jugador"))
		{
			estaEnRango = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("Player"))
		{
			estaEnRango = false;
		}
	}
	/*//Para el texto
	public TextMeshProUGUI dialog;
	public string[] lineas;
	int index;
	public float velP;

	//Para los botones
	public GameObject botonC;
	public GameObject botonS;

	public GameObject panelD;
	public GameObject botonL;

	//Para ver si ya hablamos
	private bool hecho = false;

	private void Update()
	{
		if(dialog.text == lineas[index])
		{
			botonC.SetActive(true);
		}
	}

	IEnumerator TextoDialogo()
	{
		botonC.SetActive(false);
		botonL.SetActive(false);
		foreach(char letra in lineas[index].ToCharArray())
		{
			dialog.text += letra;

			yield return new WaitForSeconds(velP);
		}
	}

	public void siguienteP()
	{
		botonC.SetActive(false);
		if(index < lineas.Length - 1)
		{
			index++;
			dialog.text = "";
			StartCoroutine(TextoDialogo());
		}else{
			dialog.text = "";
			botonC.SetActive(false);
			botonS.SetActive(true);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.CompareTag("Jugador") && hecho == false)
		{
			botonL.SetActive(true);
		}else{
			botonL.SetActive(false);
		}
	}

	public void botonLeer()
	{
		panelD.SetActive(true);
		StartCoroutine(TextoDialogo());
	}

	public void botonSalir()
	{
		panelD.SetActive(false);
		botonL.SetActive(false);
		hecho = true;
	}
	*/
}
