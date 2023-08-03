using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject playerPrefab;
    void Update()
    {
        GameObject playerObj = GameObject.Find(playerPrefab.name);
        if (playerObj == null)
        {
            GameObject newPlayerObj = Instantiate(playerPrefab);
            newPlayerObj.name = playerPrefab.name;
        }
    }
}
