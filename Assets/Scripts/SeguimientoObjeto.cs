using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoObjeto : MonoBehaviour
{
    void Update()
    {
        Vector2 posicionPantalla = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    	Vector2 posicionMundo = Camera.main.ScreenToWorldPoint(posicionPantalla);
    	transform.position = posicionMundo;
    }
}
