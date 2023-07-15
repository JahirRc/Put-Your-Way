using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPlanta : MonoBehaviour
{
	private float tiempoEspera;
	public float tiempoParaAtacar = 1;

	public Animator animator;
	public GameObject prefabBala;
	public Transform spawnBala;

	private void Start()
	{
		tiempoEspera = tiempoParaAtacar;
	}

	private void Update()
	{
		if(tiempoEspera<=0)
		{
			tiempoEspera = tiempoParaAtacar;
			animator.Play("Planta_Attack");
			Invoke("LanzarBala", 0.5f);
		}else{
			tiempoEspera -= Time.deltaTime;
		}
	}

	public void LanzarBala()
	{
		GameObject nuevaBala;
		nuevaBala = Instantiate(prefabBala,spawnBala.position,spawnBala.rotation);
	}

	public void RecibirDano(){
        animator.Play("Planta_Hit");
    }

    private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.transform.CompareTag("Jugador") || collision.transform.CompareTag("CajaPesada")){
			Debug.Log("Planta Dañada");
			RecibirDano();
		}
	}

}
