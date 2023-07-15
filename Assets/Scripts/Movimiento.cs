using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Movimiento : MonoBehaviour
{
	public float velocidad;
	public float fuerzaSalto;
	public LayerMask capaSuelo;
	private bool mirandoDerecha = true;

	private Rigidbody2D rb;
	public Animator animator;
	private BoxCollider2D boxCollider;

	public AudioSource audio;
    public AudioSource audio2;

	public Slider vida;
	public float danoEnemigo;

    public bool puedeMoverse = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();
    }

    bool Suelo()
    {
    	RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y),0f,Vector2.down,0.2f,capaSuelo);
        return raycastHit.collider != null;
    }


    void ProcesarSalto()
    {
    	if(Input.GetKeyDown(KeyCode.Space) && Suelo())
    	{
    		rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    		audio.Play();
    	}
    }

    void ProcesarMovimiento(){
    	float inputMovimiento = Input.GetAxis("Horizontal");
    	if(inputMovimiento != 0f){
    		animator.SetBool("Running", true);
    	}else{
    		animator.SetBool("Running", false);
    	}
    	rb.velocity =  new Vector2(inputMovimiento * velocidad, rb.velocity.y);
    	GestionarOrientacion(inputMovimiento);
    }

    void GestionarOrientacion(float inputMovimiento){
    	if( (mirandoDerecha = true && inputMovimiento <0))
    	{
    		transform.localEulerAngles = new Vector3(0,180,0);
    	}else if (mirandoDerecha == false && inputMovimiento>0){
    		transform.localEulerAngles = new Vector3(0,0,0);
    	}

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Manzanas"))
        {
            FindObjectOfType<GrupoFrutas>().todasManzanasRecolec();
            vida.value+=0.4f;
        }else if(other.gameObject.CompareTag("Naranjas")){
            FindObjectOfType<GrupoFrutas>().todasManzanasRecolec();
            fuerzaSalto+=5;
            vida.value+=0.8f;
        }
    }

    public void RecibirDano(){
        animator.Play("Hit");
        vida.value -= danoEnemigo;
        audio2.Play();
        if(vida.value==0){
        	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
    	if(collision.transform.CompareTag("Pinchos"))
    	{
            audio2.Play();
    		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	}
    }
}
