using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentSphere : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigid = other.attachedRigidbody;
        Debug.Log(otherRigid);
        if (otherRigid)
        {
            otherRigid.useGravity = false;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody otherRigid = other.attachedRigidbody;

        if (otherRigid)
        {
            otherRigid.useGravity = true;
        }
    }
}
