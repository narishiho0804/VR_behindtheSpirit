using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbleObject : MonoBehaviour
{
    public Transform missilePrefab;


    private void OnCollisionEnter(Collision collision)
    {
        Transform missileTransform = Instantiate(missilePrefab, transform.position, transform.rotation);
        missileTransform.localScale = transform.localScale;

        foreach (Rigidbody rigidbody in missileTransform.GetComponentsInChildren<Rigidbody>())
        {
            rigidbody.AddExplosionForce(150f, transform.position + Vector3.up * 0.5f, 5f);
        }
        Destroy(gameObject);
    }
    
}
