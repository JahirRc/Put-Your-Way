using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
	public float velocidad = 2;
	public float desaparecer = 2;
	public bool izquierda;

	private void Start()
	{
		Destroy(gameObject,desaparecer);
	}

	private void Update()
	{
		if(izquierda)
		{
			transform.Translate(Vector2.left*velocidad*Time.deltaTime);
			}else{
				transform.Translate(Vector2.right*velocidad*Time.deltaTime);
			}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("CajaPesada") || collision.transform.CompareTag("Caja") || collision.transform.CompareTag("Jugador")){
			Destroy(gameObject);
		}
	}
}
