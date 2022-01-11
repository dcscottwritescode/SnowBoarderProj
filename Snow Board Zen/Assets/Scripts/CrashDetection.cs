using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{

    [SerializeField] float sceneDelayCrash = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadSceneCrash", sceneDelayCrash);
            Debug.Log("You have crashed! Please start from the beginning...");
        }    
    }

    void ReloadSceneCrash()
    {
        SceneManager.LoadScene(0);
    }
}
