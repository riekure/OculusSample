using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {

    public GameObject explosion;

    void OnCollisionEnter(Collision collision) 
    {
        // オブジェクトを消す
        Destroy(gameObject);

        // 爆発の prefab
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
    }
}
