using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var wordlPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);// lay vi tri con tro chu
        wordlPoint.z = 0;// dung de di chuyen tren truc x va y
        transform.position = wordlPoint;// gan vi tri con tro chuot cho vi tri player
    }
}
