using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    //Переменные, отвечающие за чувствительность езды. 
    //Чем больше значение - тем больше двигается куб при нажатии
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()

    //Управление кубом посредством применения "силы" на него, если нажата клавиша. 
    //Тут же строка отвечающая за смерть от падения
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0.99f)
        {
            //FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<PlayerCollision>().Destroy();
        }
    }
}
