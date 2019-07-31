using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTeleportScript : MonoBehaviour
{
    public bool goingUpTeleport;//if true, this will be the teleporter taking you from the top to the bottom
    public Vector3 goingUpTeleportTarget;
    public Vector3 goingDownTeleportTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (goingUpTeleport)
        {
            col.gameObject.transform.position = goingUpTeleportTarget;
        }else if (!goingUpTeleport)
        {
            col.gameObject.transform.position = goingDownTeleportTarget;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
