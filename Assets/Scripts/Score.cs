using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public static float score { get; private set; }

    
    void FixedUpdate()
    {
        score = player.position.z;
        scoreText.text = score.ToString("0");
    }
}
