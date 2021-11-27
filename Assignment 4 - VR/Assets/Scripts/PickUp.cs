using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    public Camera mainCamera;
    public LayerMask layerMask;
     

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out RaycastHit raycastHit, float.MaxValue,layerMask))
        {
            this.transform.position = raycastHit.point;



        }
       // this.transform.position = theDest.position;

    }

    void OnMouseUp() {


        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
    

   
}
