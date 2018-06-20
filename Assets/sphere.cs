using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {
    

    void Start () {
      
    }
	
	void Update () {
        transform.Translate((-6 * Time.deltaTime), 0, 0);

        if (transform.position.x < -6) {
            Destroy(gameObject);
        }
    }
}
