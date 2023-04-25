using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    Transform spawnPos;

    Rigidbody playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public void OnMenu()
    {
        Debug.Log("Pressed");
        Instantiate(menu, spawnPos.position, Quaternion.Euler(Vector3.zero));
    }

    public void OnFly()
    {
        playerRB.AddForce(Vector3.up);
    }

    public void OnSink()
    {
        playerRB.AddForce(Vector3.down);
    }
}
