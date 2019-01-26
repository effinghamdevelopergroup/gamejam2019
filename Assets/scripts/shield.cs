using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public GameObject shieldPulse;
    public Transform launchPoint;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("shielding", false);
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("shielding",true);
            
        }
    }

    public void GenerateShield()
    {
        GameObject shieldInstant = Instantiate(shieldPulse, launchPoint);
    }

}
