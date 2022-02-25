using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    [SerializeField] private int power=1;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"New collision with {other}");
        Rigidbody getRigidbody = other.rigidbody;
        if (getRigidbody)
        {
            ImpulsePunch(getRigidbody);
        }
    }

    private void ImpulsePunch(Rigidbody enemy)
    {
        Vector3 forceVector = (enemy.transform.position - transform.position).normalized;
        enemy.AddForce(forceVector * power, ForceMode.Impulse);
    }

}
