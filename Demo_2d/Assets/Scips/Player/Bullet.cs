using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;


    private void Start()
    {
        
    }
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += flySpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}
