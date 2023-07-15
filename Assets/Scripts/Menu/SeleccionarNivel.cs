using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeleccionarNivel : MonoBehaviour
{
	public Button[] botonesNivel;

	void Start()
	{
		int nivel = PlayerPrefs.GetInt("nivel", 1);

		for(int i = 0; i<botonesNivel.Length; i++)
		{
			if(i + 1 > nivel){
				botonesNivel[i].interactable = false;
			}
		}
	}
}
