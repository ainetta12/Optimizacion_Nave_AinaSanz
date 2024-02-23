using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
      [SerializeField] float enemySpeed = 5;

    
    void Update()
    {
        transform.position += transform.forward * 2 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision colision)
    {
        gameObject.SetActive(false);
    }
}
