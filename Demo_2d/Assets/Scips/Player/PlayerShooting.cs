using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
