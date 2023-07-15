using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaRomper : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public GameObject partesRotas;
	public int vidas = 1;

	private void OnCollisionEnter2D(Collision2D collison)
	{
		if(collison.transform.CompareTag("BalaPlanta") || collison.transform.CompareTag("CabezaHongo"))
		{
			perderVida();
		}
	}

	public void perderVida()
	{
		vidas--;
		verificarVida();
	}

	public void verificarVida()
	{
		if(vidas<=0)
		{
			partesRotas.SetActive(true);
			spriteRenderer.enabled = false;
			Invoke("destruirCaja",0.5f);
		}
	}

	public void destruirCaja()
	{
		Destroy(gameObject);
	}
}
