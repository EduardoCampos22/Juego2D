using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Fuerza de salto
    public float jumpForce = 20f;

    // Velocidad horizontal del player
    public float speed = 5f;

    // Acceso al componente RigidBody2D
    private Rigidbody2D myRigidbody2D;

    private Animator animacion;

    private Manager gameManager;

    public bool grounded;

    public GameObject GameOverCamera;    


    // Start is called before the first frame update
    void Start()
    {
        // Enlaza con el componente en tiempo de ejecución
        myRigidbody2D = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        gameManager = FindObjectOfType<Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // La velocidad que le aplicamos en el componente vertical es playerJumpForce
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpForce);

            animacion.SetTrigger("Jump");
        }

        // Ahora establecemos un valor para la velocidad horizontal (Coordenada x)
        myRigidbody2D.velocity = new Vector2(speed, myRigidbody2D.velocity.y);

        animacion.SetBool("Grounded", grounded);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            gameManager.AddScore();
        }
        else if (collision.CompareTag("DeathZone") || collision.gameObject.CompareTag("ItemBad"))
        {
            // PlayerDead();            
            GameOverCamera.SetActive(true);
        }

    }


    /*
    void PlayerDead()
    {
    	SceneManager.LoadScene("level2d");
    }
    */
}
