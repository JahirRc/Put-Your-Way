using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaGir : MonoBehaviour
{
	public int ID;
	private ControladorDeEditor editor;
	private GameObject plataformaGir;

    private DanoSalto dano;

    void Start()
    {
       editor = GameObject.FindGameObjectWithTag("ControladorDeEditor").GetComponent<ControladorDeEditor>(); 
    }

    void OnMouseDown()
    {
    	Destroy(gameObject);
    	editor.botonesItem[ID].cantidad++;
       	editor.botonesItem[ID].textoCantidad.text = editor.botonesItem[ID].cantidad.ToString();
    }
}