using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingData : MonoBehaviour
{
    public List<GameObject> buildingBlocks;
    public List<GameObject> buildingBlocksOutline;

    BuildingController buildingController;

    // Start is called before the first frame update
    void Start()
    {
        buildingController = GetComponent<BuildingController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CanBeCreated(RaycastHit hit)
    {
        if (hit.collider.gameObject.layer == 3)
        {
            return true;
        }
        return false;
    }


    public bool CanBeDestroyed(RaycastHit hit)
    {
        if (hit.collider.gameObject.layer == 3)
        {
            if (hit.collider.gameObject.CompareTag("BuildingBlock"))
            {
                return true;
            }
        }
        return false;
    }
}
