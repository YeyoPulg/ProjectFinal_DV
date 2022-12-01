using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
   
    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemycontroler = other.GetComponent<Enemy>();
            enemycontroler.Bajardaño(daño);
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
