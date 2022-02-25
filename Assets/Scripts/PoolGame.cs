using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolGame : MonoBehaviour
{
    [SerializeField] private int power;

    void Start()
    {
        Rigidbody cueBall = GetComponent<Rigidbody>();
        Vector3 direct = new Vector3(1, 0, 0);
        cueBall.AddForce(direct * power, ForceMode.Impulse);
        
    }

}
