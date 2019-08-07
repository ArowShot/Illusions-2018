using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTeleportScript : MonoBehaviour
{
    public Transform dest;
    public float targetY;
    bool wall = false;
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
        if (col.gameObject.tag == "Player" && wall) {
            GameObject player = col.gameObject;
            //Vector3 temp = new Vector3(col.gameObject.transform.position.x, targetY, col.gameObject.transform.position.z);
            //temp.y = targetY;
            //col.gameObject.transform.position = temp;
            col.gameObject.transform.position = new Vector3(dest.position.x, player.transform.position.y, player.transform.position.z);
            Debug.Log("teleporting..." + this.gameObject.name);
            wall = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        wall = true;
    }
}
