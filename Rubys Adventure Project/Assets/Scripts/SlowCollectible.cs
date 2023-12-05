using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCollectible : MonoBehaviour
{
    public AudioClip slowClip;
    public float slowTime = 4.0f;

    public int slowBonus = 0;

    //float timerDisplay;       //these are now handled by ruby controller - Hudson

    //bool slowActive = false;

    private RubyController controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        controller = other.GetComponent<RubyController>();

        if(controller != null){                             // added this so errors arent thrown when the fruit gets hit be a cog  - Hudson
            if (controller.speed >= 3.0f)
            {
                controller.speed -= slowBonus;
                Destroy(gameObject);

                controller.slowActive = true;

                controller.slowTimer = slowTime;

                //gameObject.SetActive(false);

                controller.PlaySound(slowClip); //Trinity's 1st audio addition

                //timerDisplay -= Time.deltaTime;
                //if (timerDisplay < 0)
                //{
                //    Invoke(nameof(ResetEffect), slowTime);
                //}
        }
        }  
        
    }

    //moved timer to ruby update function as this gets deleted after picked up  - Hudson

    /*
    void Update()
    {
        if(slowActive){
            slowTimer -= Time.deltaTime;     
            if (timerDisplay <= 0)
            {
                slowActive = false;
                ResetEffect();
            }
        }
    }
    */

    // Reset also now obsolete as it won't be available after the affect is applied - Hudson

    /*
    private void ResetEffect()
    {
        controller.speed += slowBonus;

        Debug.Log("reset works");
    }
    */
}
