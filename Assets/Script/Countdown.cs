using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText; // UI�e�L�X�g�I�u�W�F�N�g

    private float countdownTime = 3f; // �J�E���g�_�E���J�n�b��

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
        countdownText.gameObject.SetActive(false); // �J�E���g�_�E���e�L�X�g��\��
        
    }
}
