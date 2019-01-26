using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negative : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = new Vector3(0.0f, 0.0f, 0.0f);
        float step = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, center, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        // Show particle animation
        // Increase score
    }
}
