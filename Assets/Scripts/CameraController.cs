using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float ydash;
    [SerializeField] private float xdash;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x+xdash,player.position.y+ydash,transform.position.z);
    }
}
