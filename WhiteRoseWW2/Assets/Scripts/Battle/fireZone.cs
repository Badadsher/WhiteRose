using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireZone : MonoBehaviour
{
    [SerializeField] private GameObject gun;
    private Animator gunAn;
    [SerializeField] private GameObject fire;
    [SerializeField] private PlayerHealth health;
    private void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gunAn = gun.GetComponent<Animator>();
        if (collision.CompareTag("Player"))
        {
            gunAn.Play("startFire");
           
            InvokeRepeating("minusCall", 0f,2f);
        }
    }

    void onAnimfire()
    {
        fire.SetActive(true);

    }

    private void minusCall()
    {
        if(health.healthBar.value > 0f)
        {
            health.MinusHealh(50);
        }
        else
        {
            gunAn.Play("battlePulemet");
        }
    }
}
