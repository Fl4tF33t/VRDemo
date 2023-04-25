using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    Transform spawnPos;
    public void OnMenu()
    {
        Debug.Log("Pressed");
        Instantiate(menu, spawnPos.position, Quaternion.Euler(Vector3.zero));
    }
}
