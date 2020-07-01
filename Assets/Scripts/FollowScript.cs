using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform followObject;

    private Vector3 position;
    private Transform playerPosition;

    void Start()
    {
        position.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        position.x = followObject.transform.position.x;
        position.y = followObject.transform.position.y;

        transform.position = position;
    }
}
