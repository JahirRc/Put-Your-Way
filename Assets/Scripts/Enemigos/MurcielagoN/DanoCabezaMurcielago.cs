using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DanoCabezaMurcielago : MonoBehaviour
{
	public Collider2D collider2D;
	public Animator animator;
	public SpriteRenderer spriteRenderer;
	public GameObject particulaMuerte;
	public string caja;
	public AudioSource audio;

	public float fuerzaSalto = 2.5f;
	public int vidas = 3;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("Jugador") || collision.transform.CompareTag(caja))
		{
			collision.gameObject.GetComponent<Rigidbody2D>().velocity=(Vector2.up*fuerzaSalto);
			PerderVidas();
			CuentaVidas();
		}
	}

	public void PerderVidas()
	{
		vidas--;
		animator.Play("Hit");
		audio.Play();
	}

	public void CuentaVidas()
	{
		if(vidas==0)
		{
			particulaMuerte.SetActive(true);
			spriteRenderer.enabled = false;
			Invoke("MuerteEnemigo", 0.2f);
		}
	}

	public void MuerteEnemigo()
	{
		Destroy(gameObject);
	}

}
