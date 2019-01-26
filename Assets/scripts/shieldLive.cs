using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldLive : MonoBehaviour
{
    private GameController _global;
    private float growAmount =0.1f;
    private float growrate=.1f;
    private float stayUpTime =.2f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (growAmount<1.2f)
        {
            transform.localScale=new Vector3(growAmount, growAmount, growAmount);
            growAmount += growrate;
        }
        else
        {
            stayUpTime -= Time.deltaTime;
        }
        if(stayUpTime<=0)
        {
            Destroy(gameObject);
        }
    }
}
