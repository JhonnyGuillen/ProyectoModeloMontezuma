using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast : MonoBehaviour
{
    public int rango;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rango))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.GetComponent<lightswitch>().luz == true)
                {
                    hit.collider.GetComponent<lightswitch>().OnOffLuz();
                }
            }
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);
    }
}
