using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudioPlayer : MonoBehaviour
{
    public AudioClip[] audioClips;

    public float maxTime = 2.0f;
    private float debuff = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (debuff > 0.0f)
        {
            debuff -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (debuff > 0.0f || collision.gameObject.tag != "Player") return;
        debuff = maxTime;
        AudioSource audioSource = GetComponent<AudioSource>();

        audioSource.volume = Random.Range(0.2f, 0.4f);
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        audioSource.PlayOneShot(audioClips[Random.Range(0, audioClips.Length)]);
    }
}
