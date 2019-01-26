using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Dictionary<int, Vector3> Positions = new Dictionary<int, Vector3>();
    public GameObject negative;
    public float SpawnRate;
    public float Speed;
    public long Score;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 4;
        SpawnRate = 3.0f;
        Positions[0] = new Vector3(-20,0, -20);
        Positions[1] = new Vector3(-15, 0, -20);
        Positions[2] = new Vector3(-10, 0, -30);
        Positions[3] = new Vector3(-20, 0, -10);
        Positions[4] = new Vector3(-40, 0, -5);
        Positions[5] = new Vector3(-25, 0, -20);
        Positions[6] = new Vector3(30, 0, 20);
        Positions[7] = new Vector3(50, 0, 20);
        Positions[8] = new Vector3(25, 0, 30);
        Positions[9] = new Vector3(15, 0, 35);
        Positions[10] = new Vector3(20, 0, 20);
        InvokeRepeating("CreateNegative", SpawnRate, SpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateNegative()
    {
        System.Random rand = new System.Random();
        GameObject newNeg = Instantiate(negative, Positions[rand.Next(0, 11)], Quaternion.identity);
        newNeg.GetComponent<Negative>().Speed = this.Speed;
    }
}
