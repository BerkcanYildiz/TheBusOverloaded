using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayScript : MonoBehaviour
{
    public static int clickCounter = 0;
    public static int busCounter = 1;
    public float decimalHealth;
    
    [SerializeField] private static float levelPoints = 0;
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
                decimalHealth += 1 * Time.deltaTime;
                clickCounter = Mathf.RoundToInt(decimalHealth);
                Debug.Log(clickCounter);
                if (clickCounter == 30)
                {
                    Destroy(gameObj);
                    busCounter++;
                    clickCounter = 0;
                }
            }
            if (Input.GetMouseButtonUp(0) && clickCounter < 10)
            {
                levelPoints += 100;
                Destroy(gameObj);
                busCounter++;
                scoreText.text = "SCORE : " + levelPoints;
                clickCounter = 0;
                Instantiate(busPrefab, new Vector3(0, 1, 1), Quaternion.identity);
            }
            else if (Input.GetMouseButtonUp(0) && clickCounter > 10)
            {
                levelPoints += 200;
                Destroy(gameObj);
                busCounter++;
                scoreText.text = "SCORE : " + levelPoints;
                clickCounter = 0;
                Instantiate(busPrefab, new Vector3(0, 1, 1), Quaternion.identity);
            }
            else if (Input.GetMouseButtonUp(0) && clickCounter > 20)
            {
                levelPoints += 300;
                Destroy(gameObj);
                busCounter++;
                scoreText.text = "SCORE : " + levelPoints;
                clickCounter = 0;
                Instantiate(busPrefab, new Vector3(0, 1, 1), Quaternion.identity);
            }
        }
        else if(busCounter  == 6 && levelPoints == 1000 )
        {
            Debug.Log("Level completed successfully.");
            Debug.Log(levelPoints); 
        }
        else
        {
            Debug.Log("Game Failed.");
            Debug.Log(levelPoints);   
        }
    }
}

/* else
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
            } */