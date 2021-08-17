using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 13, 0);
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, 0.3f);
    }
}