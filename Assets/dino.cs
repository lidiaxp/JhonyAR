using UnityEngine;
using UnityEngine.SceneManagement;

public class dino : MonoBehaviour {
    bool ground;

    public LayerMask oqechao;
    public Transform groundCheck;

    public Animator anime;

    public AudioSource begin;
    public AudioClip pulo;

    void Start () {
		
	}
	
	void Update () {
        ground = Physics2D.OverlapCircle(groundCheck.position, 0.2f, oqechao);
        anime.SetBool("ground", ground);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "attack"){
            SceneManager.LoadScene("scene");
        }
    }

    public void jump() {
        if (ground) {
            transform.Translate(0, 50 * Time.deltaTime, 0);
            begin.clip = pulo;
            begin.Play();
        }
    }
}
