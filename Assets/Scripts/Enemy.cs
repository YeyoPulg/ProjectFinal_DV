using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float vida;
    [SerializeField] List<Transform> waypoints;
    float velocidad = 1;
    float distanCambio = 0.2f;
    byte sigpos = 0;
    [SerializeField] private float dano;
    public Scena scena;
    private bool playerIsDead = true;
    //private SpriteRenderer enemySprite;

    

    private void Start()
    {
        //enemySprite= GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        //Debug.Log("ENTRY_2");
        if (playerIsDead)
        {
            //Debug.Log("ENTRY_3");
            transform.position = Vector3.MoveTowards(transform.position, waypoints[sigpos].transform.position, velocidad * Time.deltaTime);
            if (Vector3.Distance(transform.position, waypoints[sigpos].transform.position) < distanCambio)
            {
                sigpos++;
                if (sigpos >= waypoints.Count)
                {
                    sigpos = 0;
                }
            }
            float an_rad = Mathf.Atan2(-player.position.y + transform.position.y, -player.position.x + transform.position.x);
            float an_grad = (180 / Mathf.PI) * an_rad - 90;
            transform.rotation = Quaternion.Euler(0, 0, an_grad);
            
        }
        else
        {
            return;
        }
     }

    public void Bajardaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            //enemySprite.enabled = false;
            Destroy(gameObject);
            CountEnemyDead.numpuntaje++;
            if(CountEnemyDead.numpuntaje >= 7)
            {
                scena.Ganar();
            }
            
        }
    }

    public void PlayerIsDead()
    {
        //Debug.Log("ENTRY_1");
        playerIsDead = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            other.GetComponent<Player>().Hurt(dano);
        }
    }
}
