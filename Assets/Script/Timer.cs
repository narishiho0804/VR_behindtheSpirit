using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Corou1");
    }

    //�R���[�`���֐����`
    private IEnumerator Corou1() //�R���[�`���֐��̖��O
    {
        //�R���[�`���̓��e
        Debug.Log("�X�^�[�g");
        yield return new WaitForSeconds(10.0f);
        Debug.Log("�X�^�[�g����5�b��");
    }
}
