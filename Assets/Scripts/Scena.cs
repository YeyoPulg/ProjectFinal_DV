using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scena : MonoBehaviour
{
    public GameObject perder;
    public GameObject ganar;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(false);
    }

    public void Perder()
    {
        perder.SetActive(true);
        Time.timeScale = 0;
    }
    public void Ganar()
    {
        ganar.SetActive(true);
        Time.timeScale = 0;
    }

    public void iniciar()
    {
        SceneManager.LoadScene(0);
    }
}
