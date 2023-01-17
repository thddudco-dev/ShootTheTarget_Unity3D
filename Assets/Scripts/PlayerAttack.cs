using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] Transform tranform;
    [SerializeField] private float coolTime;

    [SerializeField] private GameObject turret; // 포신
    [SerializeField] private float deg; // 각도
    [SerializeField] private float turretSpeed; // 포신 스피드

    private bool isPressedElevationUP = false;
    private bool isPressedElevationDown = false;

    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }

        if (isPressedElevationUP)
        {
            deg = deg + Time.deltaTime * turretSpeed;
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, deg);
        }

        if (isPressedElevationDown)
        {
            deg = deg - Time.deltaTime * turretSpeed;
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, deg);
        }

    }

    public void FireBullet()
    {
        if (currentTime <= 0)
        {
            GameObject bulletObject = Instantiate(bullet, transform.position, transform.rotation);
            bulletObject.transform.position = turret.transform.position;
            currentTime = coolTime;
        }
        
    }

    public void PressedElevationUpPressDown()
    {
        isPressedElevationDown = false;
        isPressedElevationUP = true;
    }

    public void PressedElevationUpPressUp()
    {
        isPressedElevationDown = false;
        isPressedElevationUP = false;
    }

    public void PressedElevationDownPressDown()
    {
        isPressedElevationUP = false;
        isPressedElevationDown = true;
    }

    public void PressedElevationDownPressUp()
    {
        isPressedElevationUP = false;
        isPressedElevationDown = false;
    }
}
