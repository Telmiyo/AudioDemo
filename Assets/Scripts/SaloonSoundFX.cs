using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaloonSoundFX : MonoBehaviour
{
    public SaloonSoundTrigger saloonSoundTrigger;

    public float insideVolume = 0.04f;
    public float outsideVolume = 0.002f;

    // Update is called once per frame
    void Update()
    {
        if (saloonSoundTrigger.isInSaloon)
        {
            GetComponent<AudioSource>().volume = insideVolume;
        } else
        {
            GetComponent<AudioSource>().volume = outsideVolume;
        }
    }
}
