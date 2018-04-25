using UnityEngine;
using System.Collections;

public class Script_check : MonoBehaviour
{
    //static Script_car_check tranform;
    //static GameObject playerTransform;
	// Use this for initialization
	void Start ()
    {
        //playerTransform = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        //Is it the Player who enters the collider?
        if (!other.CompareTag("Player"))
            return; //If it's not the player dont continue


        if (transform == Script_car_check.checkpointA[Script_car_check.currentCheckpoint].transform)
        {
            //Check so we dont exceed our checkpoint quantity
            if (Script_car_check.currentCheckpoint + 1 < Script_car_check.checkpointA.Length)
            {
                //Add to currentLap if currentCheckpoint is 0
                if (Script_car_check.currentCheckpoint == 0)
                    Script_car_check.currentLap++;
                Script_car_check.currentCheckpoint++;
            }
            else
            {
                //If we dont have any Checkpoints left, go back to 0
                Script_car_check.currentCheckpoint = 0;
            }
        }


    }
}
