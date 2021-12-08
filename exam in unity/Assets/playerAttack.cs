using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject[] fireball;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer=Mathf.Infinity; 
    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer> attackCooldown)
            Attack();
        cooldownTimer += Time.deltaTime;
    }
    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
        fireball[0].transform.position = firepoint.position;
        fireball[0].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private void FindFireball()
    {
        for(int i=0;i<fireball.Length;i++)
        {
            if (!fireball[i].activeInHierarchy)
            {
               
            }
         
        }
    }
}
