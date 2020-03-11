using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
