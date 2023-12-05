using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCollectible : MonoBehaviour
{
    public AudioClip slowClip;
    public float slowTime = 0;

    public int slowBonus = 0;

    private RubyController controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
       if (controller.speed == 3.0f)
        {
            controller.speed -= slowBonus;

            gameObject.SetActive(false);

            controller.PlaySound(slowClip); //Trinity's 1st audio addition
            Invoke(nameof(ResetEffect), slowTime);
        }
        
        

        

    }

    private void ResetEffect()
    {
        controller.speed += slowBonus;

        Destroy(gameObject);
    }

}
