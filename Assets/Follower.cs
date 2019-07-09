using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {

    public GameObject target;

    public float speed = 0.2f;
    public float angleMax = 3f;
    public float rotationSmooth = 0.2f;
    private Vector3 velocity = Vector3.zero;
    // Use this for initialization
    void Start()
    {
    
        transform.position = target.transform.position;
    }
    public void SetupPos()
    {
   
        transform.position = target.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
  
        transform.position = Vector3.SmoothDamp(transform.position, target.transform.position, ref velocity, speed);
        float angle = Quaternion.Angle(transform.rotation, target.transform.rotation);
        if (angle > angleMax)
        {
            float accel = angle - angleMax + 1;
            float step = (rotationSmooth * accel) * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, step);
        }
        
    }
}
