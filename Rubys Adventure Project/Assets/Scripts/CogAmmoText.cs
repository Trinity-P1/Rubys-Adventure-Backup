using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CogAmmoText : MonoBehaviour
{
    public TMP_Text Ammo;

    public int cogNum = 5;
    
    RubyController currentAmmo; 

    // Start is called before the first frame update
    void Start()
    {
        Ammo = GetComponent<TMP_Text>();
        Ammo.text = "X " + cogNum;
        currentAmmo = FindObjectOfType<RubyController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AmmoCountUpdate(int change)
    {
        cogNum = change;
        Ammo.text = "X " + cogNum;
    }

}
