using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


   
    public GameObject gameOverUI;
    public GameObject WinUI;
    

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

    }

    public void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void Win()
    {
        WinUI.SetActive(true);
    }
    public void EscenaMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
