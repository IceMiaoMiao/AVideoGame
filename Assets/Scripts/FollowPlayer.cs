using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    
    void Update()
    {
        this.transform.position = player.transform.position-offset;
    }
}
