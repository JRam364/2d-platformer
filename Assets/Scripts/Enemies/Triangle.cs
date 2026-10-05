using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float patrolDistance = 3f;

    private float startingX;
    private int direction = 1;

    void Start()
    {
        startingX = transform.position.x;
    }

    void Update()
    {
        // Move enemy
        transform.Translate(
            Vector2.right * direction * speed * Time.deltaTime
        );

        // Reached right side
        if (transform.position.x >= startingX + patrolDistance)
        {
            direction = -1;
        }

        // Reached left side
        if (transform.position.x <= startingX - patrolDistance)
        {
            direction = 1;
        }
    }
}