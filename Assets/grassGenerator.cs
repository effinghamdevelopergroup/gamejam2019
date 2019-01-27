using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassGenerator : MonoBehaviour
{

    public GameObject[] grass;

    // Start is called before the first frame update
    void Start()
    {
        for (int g=0; g < 400; g++)
        {
            GameObject blade = Instantiate(grass[Random.Range(0, 2)], new Vector3(Random.Range(-133,133), 0.01f, Random.Range(-133, 133)),Quaternion.identity);
            blade.transform.localScale = new Vector3(1+Random.Range(0,.3f),1, 1 + Random.Range(0, .3f));
           // blade.GetComponent<SpriteRenderer>().sortingOrder = 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
