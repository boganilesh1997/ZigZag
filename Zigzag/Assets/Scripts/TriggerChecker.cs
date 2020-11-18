using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit(Collider col)
    {
      if(col.gameObject.tag == "Ball")
      {
        //Invoke("fallDown",0.5f);
      fallDown();
      }
    }
    void fallDown()
    {
      GetComponentInParent<Rigidbody>().useGravity= true;
      GetComponentInParent<Rigidbody>().isKinematic= false;
//Console.WriteLine("trigger fallDown");
    Destroy(transform.parent.gameObject,2f);
    }
}
