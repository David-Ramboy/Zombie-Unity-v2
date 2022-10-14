using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float startingHealth;

    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    private string ENEMY_TAG = "Enemy";

    // get the damage of the gameobject monster using delegates
    public delegate float MonsterDamage();
    public static event MonsterDamage monsterDamage;

    private Monster mons;

    private void Awake()
    {

        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        mons = GetComponent<Monster>();

    }

    private void Start()
    {
        Healthbar.playerHealth += playerHealthSend;

    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth == 0)
        {
            Destroy(gameObject);
            
            //iframes
        }

    
    }
    public void AddHealth(float _value)
    {
        //currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    float playerHealthSend()
    {
        return currentHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            TakeDamage(monsterDamage());
        }
    }
}