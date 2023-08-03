using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    


    // Update is called once per frame
    void Update()
    {
        Vector3 force;

        force = this.gameObject.transform.forward * speed;
        GetComponent<Rigidbody>().AddForce(force);

        Destroy(gameObject, 5.0f);
    }
}
