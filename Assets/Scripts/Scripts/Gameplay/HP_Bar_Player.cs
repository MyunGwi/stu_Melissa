using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Bar_Player : MonoBehaviour
{
    public Transform hpBar;

    void Start ()
    {
        if (hpBar == null) 
        {
            Debug.LogWarning("Il manque HP Bar !");
            Debug.Break();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Item playerItem = GameObject.FindGameObjectWithTag("Player")?.GetComponent<Item>();
        if (playerItem != null) 
        {
            hpBar.localScale = new Vector3( playerItem.HpRatio, 1f, 1f);
        
        }
    }
}
