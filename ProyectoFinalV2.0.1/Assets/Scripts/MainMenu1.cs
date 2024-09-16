using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void EscenaReferencias()
    {
        SceneManager.LoadScene("Referencias");
    }
    public void EscenaControles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void EscenaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void EscenaMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
