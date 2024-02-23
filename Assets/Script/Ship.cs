using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField] Transform gunPosition;
    [SerializeField] int bulletType = 0;
    public float speed = 5f;

  
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3  movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement*speed*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }


    void Shot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager2.Instance.GetPooledObjects(bulletType, gunPosition.position, gunPosition.rotation);
            
            if(bullet != null)
             {   
                bullet.SetActive(true);
             }
             else 
             {
                Debug.LogError("Pool demasiado pequeño");
             }
        }
    }
}
