using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLRBT : MonoBehaviour
{
    public bool isMoveLeft;
    public bool isMoveRight;
    
    public void DownLeft()
    {
        isMoveLeft = true;
    }
    public void UpLeft()
    {
        isMoveLeft = false;
    }
    public void DownRight()
    {
        isMoveRight = true;
    }
    public void UpRight()
    {
        isMoveRight = false;
    }
}
