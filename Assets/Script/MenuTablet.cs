using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTablet : MonoBehaviour
{
    Transform distancePoint;

    // Start is called before the first frame update
    void Start()
    {
        distancePoint = GameObject.Find("XR Origin").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, distancePoint.position);

        if(distance> 10)
        {
            Destroy(this.gameObject);
        }
    }
}
