using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject position;
    public GameObject target;

    void OnTriggerEnter()
    {
        Instantiate(target, new Vector3(position.transform.position.x,
                                        position.transform.position.y,
                                        position.transform.position.z),
                                        Quaternion.identity);
    }

}
