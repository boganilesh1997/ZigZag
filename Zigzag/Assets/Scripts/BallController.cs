using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallController : MonoBehaviour
{
  //  [SerializeField]
    private float speed = 8.0f ;
    bool GameOver;
    Rigidbody rb;
    bool GameStarted;
    public GameObject partical;
    void Awake(){
      rb = GetComponent<Rigidbody>();
    }
      // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameStarted)
        {
            if(Input.GetMouseButtonDown(0))
            {
            rb.velocity = new Vector3 (0,0,speed);
            GameStarted = true;
            GameManager.instance.StartGame();
          }
        }
        if(!Physics.Raycast (transform.position, Vector3.down, 1f))
        {
          GameOver = true;
          rb.velocity = new Vector3(0,-25f,0);
          Camera.main.GetComponent<CameraFollow> ().gameOver = true;
          GameManager.instance.GameOver();
        }
        if(Input.GetMouseButtonDown(0) && !GameOver)
        {
          SwitchDirection();
        }
    }
    void SwitchDirection()
    {
        if(rb.velocity.z > 0)
        {
          rb.velocity= new Vector3 (speed,0,0);
        }
        else if(rb.velocity.x > 0)
        {
          rb.velocity = new Vector3(0,0,speed);
        }
      //  Debug.Log("inside SwitchDirection");
    }

    void OnTriggerEnter(Collider col)
    {
    //   Debug.Log("conin trigger inside Trigger ");
      if(col.gameObject.tag == "Goldcoin")
      {
    //    Debug.Log("conin trigger ");
    GameObject part = Instantiate(partical,col.gameObject.transform.position, Quaternion.identity) as GameObject;
       Destroy(col.gameObject);
        Destroy(part,1f);

      }
    }
}
