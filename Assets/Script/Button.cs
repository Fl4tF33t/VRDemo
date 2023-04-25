using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("button hit");
    }
}
