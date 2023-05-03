using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    [SerializeField]
    GameObject button;
    [SerializeField]
    Transform pressedPos;
    [SerializeField]
    Transform unpressedPos;
    public GameObject random;

    AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dfd");
        button.transform.position = pressedPos.position;
        sound.Play();
        Instantiate(random);
    }

    private void OnTriggerExit(Collider other)
    {
        button.transform.position = unpressedPos.position;
    }
}
