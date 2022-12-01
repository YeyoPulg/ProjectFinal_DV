using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountEnemyDead : MonoBehaviour
{
    public static int numpuntaje = 0; //INICIALIZAR VARIABLE PUNTAJE

    // Start is called before the first frame update
    void Start()
    {
        numpuntaje = 0; //SE REINICIA EL PUNTAJE AL INICIAR EL JUEGO

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = numpuntaje.ToString(); //DANDO VALOR DE PUNTAJE CONVIRTIENDOLO EN TEXTO
    }

}
