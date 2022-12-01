using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Colections : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
        }
    }
}
