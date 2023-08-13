using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject buttonOpen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            buttonOpen.SetActive(true);
        
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("IsTriggered");
         
        }
    }

    public void OffBt()
    {
        buttonOpen.SetActive(false);   
    }
}
