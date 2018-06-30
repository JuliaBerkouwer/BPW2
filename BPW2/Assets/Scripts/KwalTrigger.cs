using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KwalTrigger : MonoBehaviour
{
    public GameObject[] allJellyFish;
    public bool debugMode = false;
    public Toggle kwalToggle;
    public Toggle[] sharkToggles; 

    private void Update()
    {
        if (debugMode)
        {
            debugMode = false;
            foreach (GameObject t in allJellyFish)
            {
                t.GetComponent<BetweenPoints>().enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        int allTrue = 0;
        foreach(Toggle t in sharkToggles)
        {
            if(t.isOn)
                allTrue++;
        }
        
        if (other.gameObject.tag == "Player" && allTrue == 3)
        {
            kwalToggle.isOn = true;
            foreach (GameObject t in allJellyFish)
            {
                t.GetComponent<BetweenPoints>().enabled = true;
            }
        }
    }
}
