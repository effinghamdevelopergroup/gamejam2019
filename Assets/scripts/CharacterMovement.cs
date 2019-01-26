using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 20f;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
            pos.z += MoveRate;
        if (Input.GetKey("s"))
            pos.z -= MoveRate;
        if (Input.GetKey("a"))
        {
            pos.x -= MoveRate;
            UpdateAnimations(-1);
        }
            
        if (Input.GetKey("d"))
        {
            pos.x += MoveRate;
            UpdateAnimations(1);
        }
            

        transform.position = pos;

        

    }

    float MoveRate
    {
        get { return speed * Time.deltaTime; }
    }


    void UpdateAnimations(float x)
    {
        anim.SetFloat("direction",x);
    }


}
