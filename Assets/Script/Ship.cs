using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField] Transform gunPosition;
    [SerializeField] int bulletType = 0;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(bulletType, gunPosition.position, gunPosition.rotation);
            
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
