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
        speed += 11;
        anim.SetBool("move", false);

        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            Debug.Log("Up");
            anim.SetBool("move", true);
            pos.z += MoveRate;
        }
            
        if (Input.GetKey("s"))
        {
            Debug.Log("Down");
            anim.SetBool("move", true);
            pos.z -= MoveRate;
        }
            
        if (Input.GetKey("a"))
        {
            Debug.Log("Left");
            pos.x -= MoveRate;
            anim.SetBool("move", true);
            UpdateAnimations(-1);
        }
            
        if (Input.GetKey("d"))
        {
            Debug.Log("Right");
            pos.x += MoveRate;
            anim.SetBool("move", true);
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
