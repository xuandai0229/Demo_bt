using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer backgroundRenderer;
    public float speed = 0.1f;

    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset +=
            new Vector2(speed * Time.deltaTime, 0);
    }
}
