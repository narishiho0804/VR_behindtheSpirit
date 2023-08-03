using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDisplay : MonoBehaviour
{
    public GameObject dogobject;

    // Start is called before the first frame update
    void Start()
    {
        dogobject.SetActive(false);
        Invoke("dogSet", 5.0f);
    }

    void dogSet()
    {
        dogobject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
