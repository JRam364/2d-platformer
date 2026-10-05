using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public void Attack()
    {
        Debug.Log("Player attack");
    }
}