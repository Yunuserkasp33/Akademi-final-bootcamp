using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Animator anim;
    public Transform target;
    public float attackRange = 5f; 
    public float attackInterval = 1f; 
    private float nextAttackTime = 0f;

    private void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget <= attackRange)
        {
            anim.SetTrigger("run");
            if (Time.time >= nextAttackTime)
            {
                Attack();
                nextAttackTime = Time.time + attackInterval;
            }
        }
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        Debug.Log("Saldırı! Hedefe hasar verildi.");
        
    }
}
