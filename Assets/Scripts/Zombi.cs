using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombi : MonoBehaviour
{
    Animator animator;
    GameObject player;
    [SerializeField] float attackDistance = 1.0f;
    [SerializeField] float gameoverTime = 1.0f;
    [SerializeField] float destroyTime = 1.0f;
    public bool CanWalk { get; private set; }

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
        CanWalk = true;
    }


    void Update()
    {
        var playerPosition = player.transform.position;
        var zombiPosition = transform.position;
        var offset = Mathf.Abs(playerPosition.z - zombiPosition.z);

        if (offset <= attackDistance)
        {
            Attack();
            Invoke("Gameover", gameoverTime);
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    void Gameover()
    {
        SceneManager.LoadScene("GameOver");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if (collision.gameObject.tag == "Bullet")
        {
            FallDown();
        }
    }

    void FallDown()
    {
        CanWalk = false;
        animator.SetTrigger("FallDown");
        Invoke("DestroyZombi", destroyTime);
    }

    void DestroyZombi()
    {
        Destroy(gameObject);
    }
}
