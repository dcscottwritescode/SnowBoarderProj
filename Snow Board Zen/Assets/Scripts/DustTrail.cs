using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{

    [SerializeField] ParticleSystem dustEffect;
    [SerializeField]AudioClip dustSFX;

    void OnCollisionEnter2D(Collision2D other) 
    {
       if(other.gameObject.tag == "Ground")
       {
           GetComponent<AudioSource>().PlayOneShot(dustSFX);
           dustEffect.Play();
       } 
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        GetComponent<AudioSource>().Stop();
        dustEffect.Stop();
    }
}
