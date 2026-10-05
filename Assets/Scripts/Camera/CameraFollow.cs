using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
     public float yOffset = 4f;

    void Update()
    {
        transform.position = new Vector3(
            player.position.x,
            player.position.y  + yOffset,
            transform.position.z
        );
    }
}