using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeOnATrackScript : MonoBehaviour
{
    

    public Transform point1;
    public Transform point2;

    public float speed = 1.0f;

    private float startTime;
    private float journeyLength;

    public bool left = true;
    // Start is called before the first frame update
    void Start()
    {
        GetStartTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            float fracJourney = getDistCovered() / GetDistance(point1, point2);
            transform.position = Vector3.Lerp(point1.position, point2.position, fracJourney);
        }
        else
        {
            float fracJourney = getDistCovered() / GetDistance(point1, point2);
            transform.position = Vector3.Lerp(point2.position, point1.position, fracJourney);
        }
        
        if(transform.position == point2.position)
        {
            left = false;
            GetStartTime();
        }
        if(transform.position == point1.position)
        {
            left = true;
            GetStartTime();
        }
        
        //transform.position = new Vector3(Mathf.PingPong(Time.time, distance), transform.position.y, transform.position.z);
    }
    float GetStartTime()
    {
        startTime = Time.time;

        return startTime;
    }
    float GetDistance(Transform current, Transform dest)
    {
        return Vector3.Distance(current.position, dest.position);
    }
    float getDistCovered()
    {
        float distanceCovered = (Time.time - startTime) * speed ;
        return distanceCovered;
    }
    
}
