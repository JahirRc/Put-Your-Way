using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlarObjeto : MonoBehaviour
{
	public int ID;
	public int cantidad;
	public TextMeshProUGUI textoCantidad;
	public bool clickeado = false;

	private ControladorDeEditor editor;
    //public Button boton;
    
    void Start()
    {
        textoCantidad.text = cantidad.ToString();
        editor = GameObject.FindGameObjectWithTag("ControladorDeEditor").GetComponent<ControladorDeEditor>();
    }

    /*void Update()
    {
        clickBoton();
        desabilitar();
    }*/

    public void clickBoton()
    {
    	if(/*Input.GetKeyDown(KeyCode.G) &&*/ cantidad > 0 /*&& clickeado==false*/)
    	{
    		clickeado = true;
    		cantidad--;
    		textoCantidad.text = cantidad.ToString();
    		editor.botonPresionadoActual = ID;
    	}
    }

    /*public void desabilitar()
    {
        if(clickeado == true){
            boton.interactable = false;
        }else{
            boton.interactable = true;
        }
    }*/

}
