using UnityEngine;
using System.Collections;

public class spawnController : MonoBehaviour {
    public GameObject rock;

    float currentTime = 0;
    float rateSpawn = 2f;

    void Start() {
        
    }

    void Update() {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn) {
            currentTime = 0;
            Instantiate(rock, transform.position, transform.rotation);
        }
    }
}
