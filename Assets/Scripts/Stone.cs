using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Explosion")) {
            Destroy (gameObject);
        }
    }
}