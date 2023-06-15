using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportExit : MonoBehaviour
{
    [SerializeField] private int _number;
    private void Awake()
    {
        if (Teleport.IsTeleported == true)
        {
            if (Teleport.LastExitNumber == _number)
            {
                PlayerController.Player.transform.position = this.transform.position;
                BlackScreen.ActivateBlackScreen(false);
            }
        }
    }
}
