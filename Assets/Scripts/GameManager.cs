using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text deathText;
    public static int death { get; private set; }
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    
    public void CompleteLevel ()
    {
        //Функция с анимацией перехода на следующий уровень
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        //Отвечает за добавление единички к переменной death после смерти и перезапускает уровень
        if (gameHasEnded == false)
        {
            FindObjectOfType<GameManager>().Death();
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }


    public void Update()
    {
        //Отображает количество смертей по центру экрана
        deathText.text = death.ToString();
    }

    public void Death()
    {
        //Добавляет единицу после каждой смерти к переменной
        deathText.text = death++.ToString();
    }

    void Restart ()
    {
        //Перезагружает сцену, то бишь уровень
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
