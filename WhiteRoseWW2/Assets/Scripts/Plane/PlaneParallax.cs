using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneParallax : MonoBehaviour
{
    public float speed = 1.0f;
    public float distation = 13.0f;

    void Update()
    {
        // ���������� ������ �� �����������
        transform.position += Vector3.left * speed * Time.deltaTime;

        // ���� ������ ����� �� ������� ������, �� ���������� �� �������
        if (transform.position.x > distation)
        {
            transform.position = new Vector3(+distation, transform.position.y, transform.position.z);
        }
    }
}

