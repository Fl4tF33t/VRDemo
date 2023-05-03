using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    Transform spawnPos;

    Rigidbody playerRB;
    [SerializeField]
    XRRayInteractor rayInteractor;

    Vector3 offset = new Vector3(-0.25f, 0.1f, -0.1f);

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    public void OnMenu()
    {
        Instantiate(menu, spawnPos.position + offset, Quaternion.Euler(new Vector3(80,0,0)));
    }

    public void OnFly()
    {
        playerRB.AddForce(Vector3.up * 10);
    }

    public void OnSink()
    {
        playerRB.AddForce(Vector3.down * 10);
    }

    public void OnInteractorChange()
    {
        rayInteractor.enabled = !rayInteractor.enabled;
    }
}
