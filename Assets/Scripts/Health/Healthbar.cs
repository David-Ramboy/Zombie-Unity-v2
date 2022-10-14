using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Healthbar : MonoBehaviour
{
    public static Healthbar instance;

    //[SerializeField] private Health playerHealth;
    [SerializeField] public Image totalhealthBar;
    [SerializeField] public Image currenthealthBar;

    public delegate float PlayerHealth();
    public static event PlayerHealth playerHealth;
       
    public GameObject objectToFind;

    private void Awake()
    {

        // display the empty health/ heart
      if(playerHealth != null)
        {
            totalhealthBar.fillAmount = playerHealth() / 10;
            print(totalhealthBar.fillAmount);

        }
    }

    private void Update()
    {
        //display the current Health
        currenthealthBar.fillAmount = playerHealth()/ 10;

    }
}