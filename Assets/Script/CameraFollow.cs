using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //Player
    public Transform Player;

    //Offset(distance between player and camera)
    public Vector3 offsetCam;

    private void Start()
    {
        //Initial offset calculation
        offsetCam = Player.position - transform.position;
    }

    private void LateUpdate()
    {
        //Camera follow player
        this.transform.position = Player.position - offsetCam;
    }

}
