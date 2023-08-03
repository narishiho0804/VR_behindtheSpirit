using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogController : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[3];
    public int Life = 3;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lifeArray[Life - 1].SetActive(false);
            Life--;
            if (Life == 0)//もしライフが０になったらゲームオーバーシーンを切り替える
            {
                SceneManager.LoadScene("GameOverScene");
            }
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("GameClearScene");
        }
        if(collision.gameObject.tag == "Gun")
        {
            Destroy(collision.gameObject);
        }
    }


}
