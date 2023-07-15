using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarCaja : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	
	private void OnCollisionEnter2D(Collision2D collison)
	{
		if(collison.transform.CompareTag("BalaPlanta"))
		{
			spriteRenderer.enabled = false;
		}
	}
}
