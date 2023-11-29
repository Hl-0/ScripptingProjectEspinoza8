using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UIElements;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;
<<<<<<< HEAD
    public int maxHealth = 5;
    public int health { get { return currentHealth; } }
    int currentHealth;
           

=======

    public int maxHealth = 5;

    public GameObject projectilePrefab;

    public float timeInvincible = 2;
    public int health { get { return currentHealth; } }
    int currentHealth;

    bool isInvincible;
    float invincibleTimer;
>>>>>>> d2f4d342615badfcba1b4c8a584162529d0fed83

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
=======

    Animator animator;
    Vector2 lookdirection = new Vector2(1,0);

    // Start is called before the first frame update
    void Start()
    {
     rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        
>>>>>>> d2f4d342615badfcba1b4c8a584162529d0fed83
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
<<<<<<< HEAD
        vertical = Input.GetAxis("Vertical");
    }

=======
         vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f) )
        {
            lookdirection.Set(move.x, move.y);
            lookdirection.Normalize();
        }
        animator.SetFloat("Look X", lookdirection.x);
        animator.SetFloat("Look Y", lookdirection.y);
        animator.SetFloat("Speed", move.magnitude);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if(invincibleTimer > 0 )
            {
                isInvincible = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }
    }
   
   
>>>>>>> d2f4d342615badfcba1b4c8a584162529d0fed83
    void FixedUpdate()
    {

        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);

    }
    public void ChangeHealth(int amount)
    { 
<<<<<<< HEAD
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
    
=======
        if(amount < 0)
        {
            animator.SetTrigger("Hit");

            if(isInvincible)
            {
                return;
            }
            isInvincible = true;
            invincibleTimer = timeInvincible;

        }
    currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(lookdirection, 300);

        animator.SetTrigger("Launch");
    }
>>>>>>> d2f4d342615badfcba1b4c8a584162529d0fed83
}
