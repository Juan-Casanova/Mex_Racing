using UnityEngine;
using System.Collections;

public class Script_car_check : MonoBehaviour {

    public Transform[] checkpointArray;
    public static Transform[] checkpointA;
    public static int currentCheckpoint = 0;
    public static int currentLap = 0;
    static Vector3 starPos;
    public int Lap;
    // Use this for initialization
    void Start ()
    {
        starPos = transform.position;
        currentCheckpoint = 0;
        currentLap = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Lap = currentLap;
        checkpointA = checkpointArray;
    }
}
