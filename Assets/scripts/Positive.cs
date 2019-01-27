using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.scripts;

public class Positive : MonoBehaviour
{
    private GameController _globalProps;
    public float Speed;
    public int Experience = 1;
    public GameObject deathFx;
    public GameObject shieldFx;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().sortingOrder = 2;

        _globalProps = GameObject.FindGameObjectWithTag("Global").GetComponent<GameController>();
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float step = Speed * Time.deltaTime;
        Vector3 house = GameObject.FindGameObjectWithTag("House").transform.position;
        
        transform.position = Vector3.MoveTowards(transform.position, house, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
            Instantiate(shieldFx, transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "House")
        {
            _globalProps.Score += Experience;
            Destroy(gameObject);
            Instantiate(deathFx, transform.position, Quaternion.identity);
        }
    }

    private void OnDestroy()
    {
        

        // Show particle animation
    }

}
