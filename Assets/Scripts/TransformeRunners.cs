using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HorseState
{
    Racing,
    Preparing
}

public class TransformeRunners : MonoBehaviour
{
    public HorseState currentState;
    public int HorseName;
    private int nameChange;
    public float Min;   
    public float Max;
    private Vector3 change;
    private static float Aceleration;
    private Rigidbody2D Horse;
    private Animator animator;
    private bool runStarted;
    private float lastChange;
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentState = HorseState.Preparing;
        Horse = GetComponent<Rigidbody2D>();
        runStarted = true;
        Aceleration = 0f;
        nameChange = 0;
        lastChange = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        if ((Aceleration > 0f) && runStarted)
        {
            if (nameChange == 0) {
                switch (HorseName)
                {
                    case 1:
                        gameObject.name = PlayerPrefs.GetString("horse1");
                        Debug.Log(gameObject.name);
                        break;
                    case 2:
                        gameObject.name = PlayerPrefs.GetString("horse2");
                        break;
                    case 3:
                        gameObject.name = PlayerPrefs.GetString("horse3");
                        break;
                    case 4:
                        gameObject.name = PlayerPrefs.GetString("horse4");
                        break;
                    case 5:
                        gameObject.name = PlayerPrefs.GetString("horse5");
                        break;
                    default:
                        break;
                }
                nameChange = 1;
            }
            velocity = 1000f / (Random.Range(Min, Max));
            change.x = Mathf.Lerp(velocity, lastChange, 0.5f);
            HorseMovement();
            lastChange = velocity;
            animator.SetBool("isActive", true);
            animator.SetFloat("Speed", change.x);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("FinishLine"))
        {
            animator.SetBool("isActive", false);
            runStarted = false;
        }

    }
    void HorseMovement()
    {
        Horse.MovePosition(
            transform.position + change * Aceleration * Time.deltaTime 
            );
    }
    public static void StartRun(float changeAceleration)
    {
        TransformeRunners.Aceleration = changeAceleration;
    }
}
