using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform FirePoint;
    public Transform MainCamera;

    public float interactionRange = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
         shooting();
        }
        
    }

    void shooting()
    {
        Ray ray = new Ray(MainCamera.transform.position, MainCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange))
        {

            Debug.DrawRay(MainCamera.transform.position, MainCamera.transform.forward * interactionRange, Color.green, 1f);

            //if (hit.collider.TryGetComponent<IInterfaces>(out IInterfaces interactable))
            //{
            //    interactable.Interect();
            //}
        }

    }
}
