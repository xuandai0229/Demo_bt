using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;

    public int defaultHealthPoint = 3;
    

    public System.Action onDead;
    public System.Action onHealthChanged;

    public int healthPoint;

    void Start()
    {
        healthPoint = defaultHealthPoint;
        onHealthChanged?.Invoke();
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        Debug.Log("HP hiện tại = " + healthPoint);
        onHealthChanged?.Invoke();

        if (healthPoint <= 0)
        {
            Die();
        }
    }

    


    protected virtual void Die()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        onDead?.Invoke();
    }
}
