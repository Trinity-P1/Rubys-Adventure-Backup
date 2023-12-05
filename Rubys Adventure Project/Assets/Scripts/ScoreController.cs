using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text Score;

    public int numFixed = 0;

    GameManagerScript gameManager; //to call the Game Manager Script to activate winGame

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TMP_Text>();
        Score.text = "Robots Fixed: " + numFixed;

        gameManager = FindObjectOfType<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numFixed == 2)
        {
            gameManager.winGame();
            Debug.Log("Win");
        }
    }

    public void IncreaseScore(){
        numFixed++;
        Score.text = "Robots Fixed: " + numFixed;
    }
}
