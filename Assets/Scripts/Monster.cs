using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
<<<<<<< HEAD
    public static Monster instance;
=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255

    [HideInInspector]
    public float speed;

<<<<<<< HEAD
    [SerializeField] 
    public float damage;

    private Rigidbody2D myBody;

    //Health of Enemy
    public int maxHealth = 1;

    int enemyCoin = 1;

    int currentHealth;

    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
        Health.monsterDamage += monsterDamageSend;
    }

=======
    private Rigidbody2D myBody;



    // Start is called before the first frame update
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // velocity forces the character to move left and right/ up and down
        // speed param is to be able to push player to move and myBody.velocity.y to move left and right because of Y-axis
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
<<<<<<< HEAD

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            print("dd");
        }
    }

    float monsterDamageSend()
    {
        return damage;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Play hurt animation

        if(currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        print("Enemy Died");
        //print(returnCoin());
        CoinsCollector.Coin += enemyCoin;
        Destroy(gameObject);    
    }
=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
}
