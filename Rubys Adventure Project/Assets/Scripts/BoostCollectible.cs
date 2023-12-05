using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alfred's additional script for the Quikiwi (get it?)

public class BoostCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller.speed == 3.0f)
        {
            controller.speed = 4.5f;
	        Destroy(gameObject);

            controller.PlaySound(collectedClip); //Alfred's 2nd audio addition
        }
    }
}

