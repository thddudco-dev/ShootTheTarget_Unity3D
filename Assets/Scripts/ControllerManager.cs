using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{

    [SerializeField] private PlayerAttack playerAttack;

    private void Update()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            playerAttack.FireBullet();
        }
    }

    public void FireBullet()
    {
        playerAttack.FireBullet();
    }

    public void PressedElevationUpPressDown()
    {
        playerAttack.PressedElevationUpPressDown();
    }

    public void PressedElevationUpPressUp()
    {
        playerAttack.PressedElevationUpPressUp();
    }

    public void PressedElevationDownPressDown()
    {
        playerAttack.PressedElevationDownPressDown();
    }

    public void PressedElevationDownPressUp()
    {
        playerAttack.PressedElevationDownPressUp();
    }
}
