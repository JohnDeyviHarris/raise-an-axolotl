using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTest : MonoBehaviour
{
    [SerializeField] float minDistance = 1;
    [SerializeField] Collider walkZone;
    private Vector3 target;
    private Animator animator;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        NextPoint();
    }
    void NextPoint()
    {
        target = GetPointInCollider(walkZone);
        agent.SetDestination(target);
    }
    private void FixedUpdate()
    {
        if (agent.velocity.magnitude < 0.3)
        {
            animator.SetBool("walk", false);
        }
        else
        {
            animator.SetBool("walk", true);
        }
        if (agent.velocity.magnitude == 0)
        {
            StartCoroutine(NewTarget());
        }
    }

    Vector3 GetPointInCollider(Collider collider)
    {
        Vector3 localPos;

        localPos.x = Random.Range(-collider.bounds.size.x / 2, collider.bounds.size.x / 2);
        localPos.y = collider.transform.position.y;
        localPos.z = Random.Range(-collider.bounds.size.z / 2, collider.bounds.size.z / 2);


        Vector3 pointPos = collider.transform.position + localPos;

        return pointPos;
    }
    private IEnumerator NewTarget()
    {
        yield return new WaitForSeconds(3);
        if (Vector3.Distance(transform.position, target) < minDistance)
        {
            NextPoint();
        }
    }


}