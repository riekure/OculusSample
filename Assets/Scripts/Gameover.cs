using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    [SerializeField] float backTime = 5.0f;
    void Start()
    {
        Invoke("BackScene", backTime);
    }

    void Update()
    {
        
    }

    void BackScene()
    {
        SceneManager.LoadScene("VRZombiShooting");
    }
}
