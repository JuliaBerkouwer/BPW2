using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKoraal : MonoBehaviour {

    public GameObject bubbles;
    public AudioClip bubbleSound;         //Sound when shooting

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().clip = bubbleSound;
            GetComponent<AudioSource>().Play();

            if (bubbles != null)
            {
                GameObject bubbleParticles = Instantiate(bubbles, transform.position, Quaternion.identity);
            }

        }
    }
}
