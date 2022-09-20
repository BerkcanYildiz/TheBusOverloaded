using UnityEngine;
using UnityEngine.UI;

public class GamePlayScript : MonoBehaviour
{
    public static int clickCounter = 0;
    public static int busCounter = 1;
    [SerializeField] private static int levelPoints = 0;
    [SerializeField] private GameObject gameObj;
    [SerializeField] private GameObject busPrefab;
    [SerializeField] private Text scoreText;
    

    private void Update()
    {
       GamePlay();
    }

    public void GamePlay()
    {
        if (busCounter < 6)
        {
            if (Input.GetMouseButton(0))
            {
                clickCounter++;
                Debug.Log(clickCounter);
                if (clickCounter == 1000)
                {
                    Destroy(gameObj);
                    busCounter++;
                    levelPoints += clickCounter;
                    scoreText.text = "SCORE : " + levelPoints;
                    clickCounter = 0;
                    Instantiate(busPrefab, new Vector3(0, 1, 1), Quaternion.identity);
                }
            }
            else
            {
                clickCounter++;
                Debug.Log(clickCounter);
                if (clickCounter == 300)
                {
                    Destroy(gameObj);
                    busCounter++;
                    levelPoints += clickCounter;
                    scoreText.text = "SCORE : " + levelPoints;
                    clickCounter = 0;
                    Instantiate(busPrefab, new Vector3(0, 1, 1), Quaternion.identity);
                }
            }
        }
        else
        {
            Debug.Log("Game Finished.");
            Debug.Log(levelPoints);
        }
    }
}
