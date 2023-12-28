using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public Slider healthBar;
    [SerializeField] private GameObject dieIcon;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.value = 100;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(healthBar.value == 0)
        {
            Animator anim = gameObject.GetComponent<Animator>();
            anim.Play("playerDying");
        }
        
    }

    public void MinusHealh(int damage)
    {
        healthBar.value -= damage;
        spriteRenderer.color = Color.red;

        StartCoroutine(ChangeColorWithDelay());
    }

    IEnumerator ChangeColorWithDelay()
    {
        yield return new WaitForSeconds(1f); // �������� � 2 �������

       spriteRenderer.color = Color.white; // �������� ���� ������� �� �������
    }


    public void Die()
    {
        dieIcon.SetActive(true);
    }
}
