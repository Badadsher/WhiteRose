using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletFX;
    [SerializeField] private AudioClip bulletSound;

    public void Fire()
    {
        bulletFX.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(bulletSound);
    }
}
