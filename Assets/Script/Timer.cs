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

    //コルーチン関数を定義
    private IEnumerator Corou1() //コルーチン関数の名前
    {
        //コルーチンの内容
        Debug.Log("スタート");
        yield return new WaitForSeconds(10.0f);
        Debug.Log("スタートから5秒後");
    }
}
