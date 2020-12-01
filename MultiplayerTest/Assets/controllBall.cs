using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class controllBall : NetworkBehaviour
{
    Transform _MoveableObject;
    private void Start()
    {
        _MoveableObject = transform;
    }

    Vector3 move;

    void Update()
    {
        if(isLocalPlayer)
        {
            move = new Vector3(
                System.Convert.ToInt32(Input.GetKey(KeyCode.A)) - System.Convert.ToInt32(Input.GetKey(KeyCode.D)),
                0,
                System.Convert.ToInt32(Input.GetKey(KeyCode.S)) - System.Convert.ToInt32(Input.GetKey(KeyCode.W)));
            
            _MoveableObject.transform.Translate(move * Time.deltaTime);

        }
    }
}
