using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogAmmo : MonoBehaviour
{

    public AudioClip ammoRefilled;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.currentAmmo < controller.maxAmmo)
            {
                controller.AddAmmo(controller.maxAmmo);
                Destroy(gameObject);

                controller.PlaySound(ammoRefilled);         // Hudson's first audio addition
            }
        }
    }
}
