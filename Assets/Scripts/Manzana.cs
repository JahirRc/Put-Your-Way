using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Manzana : MonoBehaviour
{
    public AudioSource audio;

	public int valorManzana = 1;
	    
	private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Jugador"))
        {
        	GetComponent<SpriteRenderer>().enabled = false;
        	gameObject.transform.GetChild(0).gameObject.SetActive(true);
        	Destroy(gameObject, 0.5f);
        	Puntuacion.instance.CambiarPuntuacion(valorManzana);
            audio.Play();
        }
    }

}
