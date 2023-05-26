using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Invoke("FallDown", .5f);
        }
    }

    void FallDown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;

        Destroy(transform.parent.gameObject, 2f);
    }



}
