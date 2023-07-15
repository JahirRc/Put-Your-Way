using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoEnemigo : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("Jugador"))
		{
			Debug.Log("Player Damaged");
			collision.transform.GetComponent<Movimiento>().RecibirDano();
		}
	}
}
