using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;

    [SerializeField]
    AudioClip soundOpen, soundDenied;

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    GameObject endPointParticule;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && CanOpen)
        {
            //   Debug.Log(other.name + " est à l'interieur du trigger");
            //  GetComponent<Animator>().enabled = true;
            myAnimator.enabled = true;
            myAudioSource.PlayOneShot(soundOpen);
            endPointParticule.SetActive(true);
        }
        else
        {
            myAudioSource.PlayOneShot(soundDenied);
        }
    }


}
