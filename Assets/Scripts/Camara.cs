using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    public Vector2 min;
    public Vector2 max;
    public float suavizado;
    Vector2 velocity;

    private void FixedUpdate()
    {
        float posx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, suavizado);
        float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, suavizado);

        transform.position = new Vector3(Mathf.Clamp(posx, min.x, max.x), Mathf.Clamp(posy, min.y, max.y),transform.position.z);
    }
}
