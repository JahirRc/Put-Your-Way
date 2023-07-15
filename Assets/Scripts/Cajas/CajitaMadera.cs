using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajitaMadera : MonoBehaviour
{
	public int ID;
	private ControladorDeEditor editor;
	private GameObject caja;

    private DanoSalto dano;

    void Start()
    {
       editor = GameObject.FindGameObjectWithTag("ControladorDeEditor").GetComponent<ControladorDeEditor>(); 
    }

    public void OnMouseDown()
    {
    	Destroy(this.gameObject);
    	editor.botonesItem[ID].cantidad++;
       	editor.botonesItem[ID].textoCantidad.text = editor.botonesItem[ID].cantidad.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("BalaPlanta") || collision.transform.CompareTag("CabezaHongo"))
        {
            Destroy(this.gameObject);
        }
    }
}
