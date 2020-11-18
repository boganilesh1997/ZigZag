using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball ;
    Vector3 offset ;
    // offset will be distance of camera and ball
    public float lerpRate;
    public bool gameOver;
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }
    // Update is called once per frame
    void Follow()
    {
      Vector3 pos = transform.position;
      Vector3 targetPos = ball.transform.position - offset;
      pos = Vector3.Lerp(pos,targetPos,lerpRate*Time.deltaTime);
      transform.position = pos;
    }
    void Update()
    {
        if(!gameOver)
        {
        Follow();
        }
    }
}
