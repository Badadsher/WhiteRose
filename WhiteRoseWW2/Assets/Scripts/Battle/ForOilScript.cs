using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForOilScript : MonoBehaviour
{
    [SerializeField] private Text taskText;
    [SerializeField] private GameObject slotObject;
    [SerializeField] private Animator tankAnim;
    private int counter;
    [SerializeField]private GameObject polandFirst;
    [SerializeField]private GameObject polandSecond;
    [SerializeField] private GameObject barricade;
    private void Start()
    {
        counter = 0;
        

    }
    public void Take()
    {
        if(counter == 0)
        {
            slotObject.SetActive(true);
            taskText.text = "Найден бензин!";
            taskText.gameObject.SetActive(true);
            counter = 1;

        }
        else
        {
            taskText.text = "Пусто";
            taskText.gameObject.SetActive(true);
        }
       
    }

    public void Use()
    {
        if (slotObject.activeSelf)
        {
            Animator polandFirstan = polandFirst.GetComponent<Animator>();
            Animator polandSecondan = polandSecond.GetComponent<Animator>();
            Animator slotAnim = slotObject.GetComponent<Animator>();
            slotAnim.Play("offSlot");
            polandFirstan.Play("polandDie");
            polandSecondan.Play("polandDie");
            tankAnim.Play("tankFire");
            barricade.SetActive(false);
        }
        else
        {
            taskText.text = "Нет объекта!";
            taskText.gameObject.SetActive(true);
        }


    }
}
