using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ShootingAntibody;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }
        
    }

    void Shooting()
    {
        Instantiate(ShootingAntibody, firePoint.position, firePoint.rotation);
    }
}
