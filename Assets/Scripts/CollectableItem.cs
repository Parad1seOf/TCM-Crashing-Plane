using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D other) {

        Debug.Log("+1 point!");

        Destroy(gameObject);
    }
}
