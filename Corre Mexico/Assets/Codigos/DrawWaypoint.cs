using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawWaypoint : MonoBehaviour
{
    //[ExecuteInEditMode]
    public List<Transform> waypoints = new List<Transform>();

    //int index = 0;
    public bool disableInGame;

    void Update()
    {
        /*if (!disableInGame)
        //{
            Transform[] tem = GetComponentsInChildren<Transform>();
            if (tem.Length > 0)
            {
                waypoints.Clear();
                index = 0;
                foreach (Transform t in tem)
                {
                    if (t != transform)
                    {
                        index++;
                        t.name = "Way " + index.ToString();
                        waypoints.Add(t);
                        index++;
                    }
                }
            }
       // }*/
    }

    void OnDrawGizmos()
    {
        if(waypoints.Count>0)
        {
            Gizmos.color = Color.green;
            foreach(Transform t in waypoints)
                Gizmos.DrawSphere(t.position,1f);

            //Gizmos.color = Color.red;

            /*for(int a=0;a<waypoints.Count;a++)
            {
                Gizmos.DrawLine(waypoints[a].position, waypoints[a + 1].position);
            }*/
        }
    }
}