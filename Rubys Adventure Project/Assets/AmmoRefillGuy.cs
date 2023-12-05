using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRefillGuy : MonoBehaviour
{

    //made new NPC controller so I can give one NPC different functions, there was prob a better way to do this but I ain't got time for that - Hudson

     public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }
}
