using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltoTrampolin : MonoBehaviour
{
	public Animator animator;

	public float fuerzaSalto = 2f;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("Jugador") || (collision.transform.CompareTag("Caja")) || (collision.transform.CompareTag("CajaPesada")))
		{
			collision.gameObject.GetComponent<Rigidbody2D>().velocity=(Vector2.up * fuerzaSalto);
			animator.Play("Trampolin_Salto");
		}
	}
}
