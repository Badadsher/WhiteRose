using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcView : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;
    private Transform playerTransform;
    private Transform npcTransform;
    private Vector3 direction;
    private void Start()
    {
       playerTransform = playerObject.transform;
       npcTransform = gameObject.transform;
       direction.x = playerTransform.position.x - npcTransform.position.x;
    }

    private void Update()
    {
        direction.x = playerTransform.position.x - npcTransform.position.x;
        if (direction.x <= -1)
        {
            npcTransform.localScale = new Vector3((float)2.82565, (float)2.857495, 1); // Поворот спрайта NPC по оси X
        }
        else if (direction.x >= 1)
        {
            npcTransform.localScale = new Vector3((float)-2.82565, (float)2.857495, 1); // Возвращение спрайта NPC в исходное состояние
        }

        
    }
}
