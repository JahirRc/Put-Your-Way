using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaVertical : MonoBehaviour
{
	public float velocidad = 0.5f;
	public float tiempoEspera;
	public Transform[] puntos;
	public float tiempoInicio = 2;
	private int i = 0;

	void Start()
	{
		tiempoEspera = tiempoInicio;
	}

	void Update()
	{
		transform.position = Vector2.MoveTowards(transform.position, puntos[i].transform.position, velocidad * Time.deltaTime);
		if(Vector2.Distance(transform.position,puntos[i].transform.position)<0.1f)
		{
			if(tiempoEspera<=0)
			{
				if(puntos[i]!=puntos[puntos.Length-1])
				{
					i++;
				}else{
					i = 0;
				}
				tiempoEspera = tiempoInicio;
			}else{
				tiempoEspera -= Time.deltaTime;
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		collision.collider.transform.SetParent(transform);
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		collision.collider.transform.SetParent(null);
	}
}
