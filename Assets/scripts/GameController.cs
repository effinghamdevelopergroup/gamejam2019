using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Dictionary<Direction, Vector3> Directions = new Dictionary<Direction, Vector3>();
    public GameObject negative;
    public float NegativeSpawnRate;
    public float NegativeSpeed;
    public long Score;
    // Start is called before the first frame update
    void Start()
    {
        Directions[Direction.East] = GameObject.Find("East").transform.position;
        Directions[Direction.West] = GameObject.Find("West").transform.position;
        Directions[Direction.North] = GameObject.Find("North").transform.position;
        Directions[Direction.South] = GameObject.Find("South").transform.position;
        NegativeSpeed = 4;
        NegativeSpawnRate = 3.0f;
        
        InvokeRepeating("CreateNegative", NegativeSpawnRate, NegativeSpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateNegative()
    {
        Vector3 offsetNorthSouth;
        Vector3 offsetEastWest;
        Vector3 spawn = Directions[Direction.East];
        System.Random rand = new System.Random();
            offsetNorthSouth = new Vector3(rand.Next(
                (int)Directions[Direction.West].x,
                (int)Directions[Direction.East].x), 0, 0);
            offsetEastWest = new Vector3(0, 0, rand.Next(
                (int)Directions[Direction.South].z,
                (int)Directions[Direction.North].z));
        int side = rand.Next(0, 4);
        if (side == 0){ spawn = Directions[Direction.East] + offsetEastWest; }
        if (side == 1) { spawn = Directions[Direction.West] + offsetEastWest; }
        if (side == 2) { spawn = Directions[Direction.South] + offsetNorthSouth; }
        if (side == 3) { spawn = Directions[Direction.North] + offsetNorthSouth; }
        GameObject newNeg = Instantiate(negative,
            spawn,
            Quaternion.identity);
        newNeg.GetComponent<Negative>().Speed = NegativeSpeed;
    }

    private enum Direction
    {
        East,
        West,
        South,
        North
    }
}
