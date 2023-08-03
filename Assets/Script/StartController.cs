using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Start")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(collision.gameObject.tag == "Title")
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
