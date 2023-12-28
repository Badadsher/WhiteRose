using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForOilScript : MonoBehaviour
{
    [SerializeField] private GameObject taskText;
    [SerializeField] private GameObject slotObject;
    [SerializeField] private Animator tankAnim;
    public void Take()
    {
        slotObject.SetActive(true);
        taskText.SetActive(true);
    }

    public void Use()
    {
        slotObject.SetActive(false);
        tankAnim.Play("tankFire");
    }
}
