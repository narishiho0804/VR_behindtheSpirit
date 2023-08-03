using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText; // UIテキストオブジェクト

    private float countdownTime = 3f; // カウントダウン開始秒数

    void Start()
    {
        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false); // カウントダウンテキスト非表示
        
    }
}
