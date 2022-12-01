using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform controldisparo;
    [SerializeField] private GameObject shoot;
    private AudioSource disparo;
    private void Awake()
    {
        disparo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooter();
            disparo.Play();
        }
    }

    private void Shooter()
    {
        Instantiate(shoot, controldisparo.position, controldisparo.rotation);
    }
}
