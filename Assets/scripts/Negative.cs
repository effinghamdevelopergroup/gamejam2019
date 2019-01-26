using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negative : MonoBehaviour
{
    private GameController _globalProps;
    public float Speed;
    public int Damage = 1;
    public int Experience = 1;
    // Start is called before the first frame update
    void Start()
    {
        _globalProps = GameObject.FindGameObjectWithTag("Global").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = Speed * Time.deltaTime;
        Vector3 house = GameObject.FindGameObjectWithTag("House").transform.position;
        Vector3 proximity = house - transform.position;

        Vector3 planeWidth = GameObject.FindGameObjectWithTag("Plane").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, house, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shield")
        {
            _globalProps.Score += Experience;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "House")
        {
            _globalProps.Score -= Damage;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Proximity")
        {
            Debug.Log("Warning!");
        }
    }

    private void OnDestroy()
    {
        // Show particle animation
    }
}
