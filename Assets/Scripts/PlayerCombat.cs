using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Player player;

    public Animator animator;
    public static GameManager instance;



    public Transform attackPoint;
    public Transform attackPoint2;

    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamge = 1;
    private float xrange = -0.93f;



    public int _charIndex;
    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    Transform num;
    private void Awake()
    {



    }

    private void Start()
    {

        //left
        //num.position += new Vector3(-1.87f, 0f, 0f);
    }

    private void FixedUpdate()
    {
    }

    // Start is called before the first frame update

    void Update()
    {

       


        if (player.facingRight)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("Attack");
                Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
                for (int i = 0; i < hitEnemies.Length; i++)
                {
                    hitEnemies[i].GetComponent<Monster>().TakeDamage(attackDamge);
                }
            }
               

        }
        else
        {

            if (Input.GetKeyDown(KeyCode.E))
            { 
                animator.SetTrigger("Attack");
                Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint2.position, attackRange, enemyLayers);
                for (int i = 0; i < hitEnemies.Length; i++)
                {
                    hitEnemies[i].GetComponent<Monster>().TakeDamage(attackDamge);
                }
            }
        }




    }

    void Attack()
    {
        //Play an attack animation



       

        //foreach (Collider2D enemy in hitEnemies)
        // {
        //  enemy.GetComponent<Monster>().TakeDamage(attackDamge);
        //}
        //Detect enemies in range of attack


        // Damage them

    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null && attackPoint2 == null)
            return;        

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        Gizmos.DrawWireSphere(attackPoint2.position, attackRange);

    }
}
