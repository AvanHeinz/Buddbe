using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    //Вызывает функцию из GameManager с анимацией перехода на следующий уровень
    void OnTriggerEnter(Collider collider)
    {
        gameManager.CompleteLevel();
    }
   
}
