using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemy : MonoBehaviour
{
    private float velocidad = 10;
    [SerializeField] private float daño;

    private void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Player playerController = other.gameObject.GetComponent<Player>();
            playerController.Hurt(1);
            //other.GetComponent<Enemy>().TomarDaño(daño);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Obstaculo"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Limites"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Islas"))
        {
            Destroy(gameObject);
        }
    }
}
