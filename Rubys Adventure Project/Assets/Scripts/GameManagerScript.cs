using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;

    public GameObject winGameUI;

    public GameObject bgMusic;
    public GameObject winMusic;
    public GameObject loseMusic; //Trinity's second SFX

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
           restartScene();
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        loseMusic.SetActive(true);
        bgMusic.SetActive(false);

    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void winGame()
    {
        winGameUI.SetActive(true);
        winMusic.SetActive(true);
        bgMusic.SetActive(false);
    }
}
