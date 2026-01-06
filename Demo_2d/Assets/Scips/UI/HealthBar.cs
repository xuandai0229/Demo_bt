using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask;
    public Health health;

    private float originalWidth;

    void Start()
    {
        originalWidth = mask.sizeDelta.x;

        UpdateHealthValue();
        health.onHealthChanged += UpdateHealthValue;
    }

    void UpdateHealthValue()
    {
        Debug.Log("UpdateHealthValue được gọi");

        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }

}
