using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTeleportScript : MonoBehaviour
{
    
    public float targetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        //if (goingUpTeleport)
        //{
        //    Vector3 temp = col.gameObject.transform.position;
        //    temp.y = goingUpTeleportTarget.y;
        //    col.gameObject.transform.position = temp;
        //    Debug.Log("testing top");
        //}
        //else if (!goingUpTeleport)
        //{
        //    Vector3 temp = col.gameObject.transform.position;
        //    temp.y = goingDownTeleportTarget.y;
        //    col.gameObject.transform.position = temp;
        //    Debug.Log("testing bottom");
        //}
        Vector3 temp = col.gameObject.transform.position;
        temp.y = targetY;
        col.gameObject.transform.position = temp;
        Debug.Log("teleporting...");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
