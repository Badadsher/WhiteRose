using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifeOFF : MonoBehaviour
{
    [SerializeField] private GameObject fireAnim;
    public void FireAnimOff()
    {
        fireAnim.SetActive(false);
    }
}
