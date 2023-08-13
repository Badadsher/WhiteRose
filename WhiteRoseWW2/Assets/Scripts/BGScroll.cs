using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scroll_Speed = 0.1f;
    private float x_Scroll;


    [SerializeField] private GameObject player_Bullet;
    [SerializeField] Transform attack_Point;

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll ()
    {
        x_Scroll = Time.time * scroll_Speed;

        Vector2 offset = new Vector2(x_Scroll, 0f);
    }
}
