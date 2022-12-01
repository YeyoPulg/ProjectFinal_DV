using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Camara")]
    private Vector3 view;
    [SerializeField] private Camera camara;

    [Header("Jugador")]
    [SerializeField] private float velocidad;
    [SerializeField] private float playerLife;
    public Scena scena;
    private Vector2 direc;
    private Vector2 entrada;
    private Rigidbody2D rb;
    public bool isAlive;
    //[SerializeField] private Enemy enemy;
    [SerializeField] private float daño;
    //private SpriteRenderer playerSprite;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;
    }

    void Update()
    {
        view = camara.ScreenToWorldPoint(Input.mousePosition);
        float an_rad = Mathf.Atan2(-view.y + transform.position.y, -view.x + transform.position.x);
        float an_grad = (180 / Mathf.PI) * an_rad - 90;
        transform.rotation = Quaternion.Euler(0, 0, an_grad);

        if (isAlive)
        {
            entrada.x = Input.GetAxisRaw("Horizontal");
            entrada.y = Input.GetAxisRaw("Vertical");
            direc = entrada.normalized;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direc * velocidad * Time.fixedDeltaTime);
    }

    public void Hurt(float hurt)
    {
        playerLife -= hurt;
        
        if (playerLife <= 0)
        {
            isAlive = false;
            
            if (isAlive== false)
            { 
                //playerSprite.enabled = false;
                Destroy(gameObject);
                //bug.Log("ENTRY_0");
                //enemy.PlayerIsDead();
                //emy.PlayerIsDead();
                scena.Perder();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().Bajardaño(daño);
        }
    }
}
