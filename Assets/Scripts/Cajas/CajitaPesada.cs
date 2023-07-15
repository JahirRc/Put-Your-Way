using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajitaPesada : MonoBehaviour
{
	public int ID;
	private ControladorDeEditor editor;
	private GameObject cajaPesada;
    public string enemigoC;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("PlantaCabeza") || collision.transform.CompareTag("MurcielagoNCabeza"))
        {
            Destroy(this.gameObject);
        }
    }
}
