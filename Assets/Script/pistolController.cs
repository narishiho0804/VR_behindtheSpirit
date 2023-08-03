using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pistolController : MonoBehaviour
{
    public GameObject bullet, bullePosition;
    public void pistolShot()
    {
        Instantiate(bullet, bullePosition.transform.position, transform.rotation);
        
    }
}
