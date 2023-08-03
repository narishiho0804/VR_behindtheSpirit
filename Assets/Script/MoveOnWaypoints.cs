using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class MoveOnWaypoints : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2;
    int index = 0;
    public bool isLoop = true;
    


    private void Start()
    {
        //this.transform.LookAt(waypoints[index].transform);
    }
    void FixedUpdate()
    {
        transform.LookAt(waypoints[index].transform);

        //Quaternion quaternion = Quaternion.LookRotation(waypoints[index].transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, speed);
    }
    // Update is called once per frame
    void Update()
    {

        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, speed * Time.deltaTime);
        transform.position = newPos;
        //transform.LookAt(waypoints[index].transform);
        

       

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            if (index < waypoints.Count - 1)
            {
                index++;
            }
            else
            {
                if (isLoop)
                {
                    index = 0;
                }
            }
        }
    }
}
