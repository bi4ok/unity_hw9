using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    [SerializeField] private float startTimeToBoom;
    [SerializeField] private float power;
    [SerializeField] private float radius;
    private float timeToBoom;

    private void Start()
    {
        timeToBoom = startTimeToBoom;
        radius = radius == 0 ? 0.01f : radius;
    }
    private void Update()
    {
        timeToBoom -= Time.deltaTime;
        if (timeToBoom <= 0)
        {
            Boom();
        }
    }

    private void Boom()
    {
        Rigidbody[] boomObjeects = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody boomObject in boomObjeects)
        {
            float distanceToObject = Vector3.Distance(transform.position, boomObject.transform.position);

            if (distanceToObject <= radius)
            {
                Vector3 direction = boomObject.transform.position - transform.position;
                boomObject.AddForce(direction.normalized * power * (1 - (distanceToObject / radius)), ForceMode.Impulse);
            }
        }

        timeToBoom = startTimeToBoom;
    }
}
