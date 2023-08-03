using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileAlarm : MonoBehaviour
{
    public bool DogSE;

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "DogSE")
        {
            DogSE = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "DogSE")
        {
            DogSE = false;
        }
    }


}
