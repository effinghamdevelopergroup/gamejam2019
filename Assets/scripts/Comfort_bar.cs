using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comfort_bar : MonoBehaviour
{
    public float Currentcomfort { get; private set; }
    public float Maxcomfort { get; private set; }
    public GameController Global;
    public Slider comfortbar;

    // Start is called before the first frame update
    void Start()
    {
        Global = gameObject.GetComponent<GameController>();
        Maxcomfort = 100f;
        // Reset comfort to 50 on game load
        Currentcomfort = Maxcomfort;

    }

    void DealDamage(float damageValue)
    {
        Currentcomfort -= damageValue;
        if (Currentcomfort <=0)
        {
            //Die();
        }        
    }

    float CalculateComfort()
    {
        return Global.Score;
    }

// Update is called once per frame
void Update()
    {
        comfortbar.value = CalculateComfort();
        if (Input.GetKeyDown(KeyCode.G))
        {
            DealDamage(5);
        }
       
            
    }
}

