using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1;

    private void Start()
    {
        GetComponent<AudioSource>().Play();
    }
    void Update()
    {
        transform.position += Vector3.up * flySpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
