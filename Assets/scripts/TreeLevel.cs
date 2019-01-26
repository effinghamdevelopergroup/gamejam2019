using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLevel : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > transform.position.z-.5f)
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder=4;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }
}
