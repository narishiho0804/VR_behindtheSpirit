using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSEAlarm : MonoBehaviour
{
    
    public GameObject target;
    public AudioClip sound1;
    AudioSource audioSource;
    public bool invaded;

    // Start is called before the first frame update
    void Start()
    {

        // ComponentÇéÊìæ
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if(target.GetComponent<MissileAlarm>().DogSE == true)
            {
                // âπÅisound1ÅjÇñ¬ÇÁÇ∑
                audioSource.PlayOneShot(sound1);
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "CautionArea")
        {
            invaded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "CautionArea")
        {
            invaded = false;
        }
    }


}
