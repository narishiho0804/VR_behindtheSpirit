using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public Transform DestructionParticle;
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
