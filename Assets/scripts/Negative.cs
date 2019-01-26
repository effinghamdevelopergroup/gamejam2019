using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.scripts;

public class Negative : MonoBehaviour
{
    private GameController _globalProps;
    public float Speed;
    public int Damage = 1;
    public int Experience = 1;
    public GameObject deathFx;
    private Vector3 startPos;
    private Direction startDir;
    public GameObject Warning;
    private GameObject warning;

    // Start is called before the first frame update
    void Start()
    {
        _globalProps = GameObject.FindGameObjectWithTag("Global").GetComponent<GameController>();
        startPos = transform.position;
        //if (startPos.x < 0 && startPos.y < 0)
        //{
        //    startDir = Direction.West;
        //} else if (startPos.x > 0 )
        //{
        //    startDir = Direction.West;
        //}
        //_globalProps = 
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
            warning = CreateWarning();
        }
    }

    private void OnDestroy()
    {
        Instantiate(deathFx, transform.position, Quaternion.identity);
        Destroy(warning);
        // Show particle animation
    }

    private GameObject CreateWarning()
    {
        GameObject player = GameObject.Find("Player");
        GameObject newWarning = Instantiate(Warning, player.transform.position, Quaternion.identity);
        newWarning.GetComponent<WarningArrow>().Negative = gameObject;
        newWarning.transform.parent = player.transform;
        return newWarning;
    }

}
