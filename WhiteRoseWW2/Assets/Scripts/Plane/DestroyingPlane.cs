using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingPlane : MonoBehaviour
{
    public GameObject explosion;
    bool canBeDestroyed = false;
    private int money;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 6f)
        {
            canBeDestroyed = true;
        }

        if(transform.position.x < -35)
        {
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canBeDestroyed)
        {
            return;
        }
        BulletScript bullet = collision.GetComponent<BulletScript>();

        if (bullet != null)
        {

            EnemyCount.enemys += 1;
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(bullet.gameObject);
            money += 100;
            PlayerPrefs.SetInt("money", money);

            PlayerPrefs.Save();



        }
    }
}
