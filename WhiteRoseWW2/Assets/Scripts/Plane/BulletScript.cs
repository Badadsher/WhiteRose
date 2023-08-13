using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float maxX;
    [SerializeField] private float speed = 5f;
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (transform.position.x > maxX)
        {
            Destroy(gameObject);
        }
        Vector3 temp = transform.position;
        temp.x += speed* Time.deltaTime;
        transform.position = temp;
    }
    

}
