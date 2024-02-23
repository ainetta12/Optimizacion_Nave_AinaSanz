using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    [SerializeField] float bulletSpeed = 5;

    
    void Update()
    {
        transform.position += transform.forward * 2 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision colision)
    {
        gameObject.SetActive(false);
    }


}
