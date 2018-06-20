using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Partiu : MonoBehaviour {

    void Start() {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Run") {
            VuforiaBehaviour.Instance.enabled = false;
        }
    }

    void Update() {
      
    }

    public void sim() {
        SceneManager.LoadScene("Run");
    }

    public void desligaAR() {

    }
}
