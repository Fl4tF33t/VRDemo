using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Rendering.UI;
using UnityEngine.XR.Interaction.Toolkit;
public class BuildingController : MonoBehaviour
{
    public  XRRayInteractor rayInteractor;
    public GameObject outlinePrefab;
    public GameObject selectedBlockPrefab;
    RaycastHit hit;
    Vector3 point;
    BuildingData buildingData;

    private void Start()
    {
        buildingData = GetComponent<BuildingData>();
    }


    private void Update()
    {
        if (rayInteractor.TryGetCurrent3DRaycastHit(out hit))
        {
            point = hit.point;

            point += hit.normal * .1f;
            point = new Vector3(Mathf.Floor(point.x), Mathf.Floor(point.y), Mathf.Floor(point.z));
            point += Vector3.one * .5f;

            outlinePrefab.transform.position = point;
        }
    }

    public void OnHoverEnter()
    {
        outlinePrefab.SetActive(true);
    }

    public void OnHoverExit()
    {
        outlinePrefab.SetActive(false);
    }
    public void OnSelected()
    {
        if (buildingData.CanBeCreated(hit))
        {
            Instantiate(selectedBlockPrefab, point, Quaternion.identity);
        }
    }
}
