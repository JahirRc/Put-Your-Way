using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsarBoton : MonoBehaviour
{
	public Animator animator;

	public BoxCollider2D boxCollider;

	public GameObject cuerdas;

	public string tag;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("Caja") || collision.transform.CompareTag("CajaPesada"))
		{
			animator.Play("Pulsado");
			boxCollider.enabled = false;
			GameObject.FindGameObjectsWithTag(tag);
		    Destroy(cuerdas, 0.5f);
		}
	}
}
