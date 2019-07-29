using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{
    public Transform target;
    public float rotationalDamp = .5f;
    public float movementSpeed = 10f;

    void Update()
    {
        Turn();
        Move();
    }


    void Turn()
    {
        Vector3 pos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);

    }


    void Move()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
