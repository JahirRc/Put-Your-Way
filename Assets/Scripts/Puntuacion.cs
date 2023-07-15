using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
	public static Puntuacion instance;
	public TextMeshProUGUI texto;
	int puntuacion;

    void Start()
    {
    	if(instance == null)
    	{
    		instance = this;
    	}
    }

    public void CambiarPuntuacion(int valorM)
    {
    	puntuacion += valorM;
    	texto.text = "X" + puntuacion.ToString();
    }
}
