using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsPlaneUPDOWN : MonoBehaviour
{
    public bool moveUp;
    public bool moveDown;
    public void StartMovingUp()
    {
        moveUp = true;
    }

    public void StopMovingUp()
    {
        moveUp = false;
    }

    public void StartMovingDown()
    {
        moveDown = true;
    }

    public void StopMovingDown()
    {
        moveDown = false;
    }
}
