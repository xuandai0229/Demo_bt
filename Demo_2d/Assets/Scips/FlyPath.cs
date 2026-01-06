using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    void Reset()
    {
        waypoints = GetComponentsInChildren<Waypoint>();
    }
}
