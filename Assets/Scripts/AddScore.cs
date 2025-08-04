using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private BoxCollider2D scoreCollider;
    private AudioSource audioSource;

    private void Start()
    {
        scoreCollider = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.Play();
        
        GlobalVars.score += 1;
        if (GlobalVars.score > GlobalVars.highScore)
        {
            GlobalVars.highScore = GlobalVars.score;
        }
        Destroy(scoreCollider.gameObject, audioSource.clip.length);
    }
}
