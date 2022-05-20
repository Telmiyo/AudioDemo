using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaloonSoundTrigger : MonoBehaviour
{
    public bool isInSaloon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInSaloon = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInSaloon = false;
        }
    }
}
