using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo;
    [SerializeField] private GameObject bala;
    private float timeElapsed;
    [SerializeField] private float spawntime = 2.5f;
    //private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawntime)
        {
            Disparar();
        }
    }

        private void Disparar()
        {
            timeElapsed = 0f;
            Instantiate(bala, ControladorDisparo.position, ControladorDisparo.rotation);
        }
}
