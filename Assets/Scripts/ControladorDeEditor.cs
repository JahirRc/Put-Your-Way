using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeEditor : MonoBehaviour
{
	public ControlarObjeto[] botonesItem;
	public GameObject[] objetos;
	public int botonPresionadoActual;

    private void Update()
    {
    	Vector2 posicionPantalla = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    	Vector2 posicionMundo = Camera.main.ScreenToWorldPoint(posicionPantalla);

    	if(Input.GetMouseButtonDown(0) && (botonesItem[botonPresionadoActual].clickeado))
    	{
    		botonesItem[botonPresionadoActual].clickeado = false;
    		Instantiate(objetos[botonPresionadoActual], new Vector3(posicionMundo.x, posicionMundo.y,0),Quaternion.identity);
    	}
    }
}
