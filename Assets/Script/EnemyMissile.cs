using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMissile : MonoBehaviour
{
    public GameObject target;
    public float speed = 2f;
    public Transform DestructionParticle;

    private void Start()
    {
        target = GameObject.Find("Dog");
    }
    private void Update()
    {
        transform.LookAt(target.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gun") // VR‚ÌŽè‚Å”j‰ó
        {
            Transform DestructionParticleTransform = Instantiate(DestructionParticle, collision.contacts[0].point, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("”j‰ó");
        }
    }
    
}
