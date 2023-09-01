using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject PlayerVehicle;
    public Vector3 Offset;
    public Vector3 driverSeatOffset;
    private Vector3 _startingOffset;
    private bool _isCameraOnDriverSeat;
    private void Start()
    {
        _startingOffset = Offset;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_isCameraOnDriverSeat)
            {
                Offset = _startingOffset;
                _isCameraOnDriverSeat = false;
            }
            else
            {
                Offset = driverSeatOffset;
                _isCameraOnDriverSeat = true;
            }
        }
    }

    void LateUpdate()
    {
        transform.position = PlayerVehicle.transform.position + Offset;
    }
}
