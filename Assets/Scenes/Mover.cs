using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, _speed * Time.deltaTime);
    }
}
