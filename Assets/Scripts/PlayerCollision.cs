using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject destroyedVersion;
    public AudioSource source;
    public AudioClip clip1;

    //Скрипт отвечающий за столкновение куба с препятствием.
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            source.PlayOneShot(clip1);
            gameObject.SetActive(false);
            Instantiate(destroyedVersion, transform.position, transform.rotation);
          

            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void Destroy()
    {
        source.PlayOneShot(clip1);
        gameObject.SetActive(false);
        Instantiate(destroyedVersion, transform.position, transform.rotation);


        FindObjectOfType<GameManager>().EndGame();
    }
}
