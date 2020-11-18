using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpowner : MonoBehaviour
{
  public GameObject platform;
  public GameObject GoldCoin;

  Vector3 lastPos;
  float size;
    // Start is called before the first frame update
    void Start()
    {
      lastPos = platform.transform.position;
      size = platform.transform.localScale.x;
       for(int i=0;i<5;i++)
       {
         spawnPlatform();
       }

       InvokeRepeating("spawnPlatform",2.0f,0.7f);
    }

    // Update is called once per frame
    void Update()
    {
      if(GameManager.instance.gameOver == true)
      {
        CancelInvoke("spawnPlatform");
      }

    }
    void spawnPlatform()
    {
      int rand = Random.Range(0,7);
      if(rand < 3)
      {
        SpawnX();
        SpawnX();
      }
      else
      {
        SpawnZ();
        SpawnZ();
      }
    }

    void SpawnX()
    {
      Vector3 pos =  lastPos;
      pos.x += size;
      lastPos = pos;
      Instantiate(platform ,pos, Quaternion.identity);

      int rand = Random.Range(0,4);
      if(rand<2)
      {
        Instantiate(GoldCoin,new Vector3(pos.x,pos.y + 1.5f,pos.z),GoldCoin.transform.rotation);
      }
    }
    void SpawnZ()
    {
      Vector3 pos = lastPos;
      pos.z += size;
      lastPos = pos;
      Instantiate(platform ,pos, Quaternion.identity);

      int rand = Random.Range(0,4);
      if(rand<2)
      {
          Instantiate(GoldCoin,new Vector3(pos.x,pos.y + 1.5f,pos.z),GoldCoin.transform.rotation);
      }
    }
}
