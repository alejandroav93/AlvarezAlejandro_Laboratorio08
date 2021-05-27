using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public Object playerPrefab;
    public Transform spawnPoint;
    GameObject player;
    bool score = false;
    public GameObject flash; 
    public Text scoreText;
    public string status = "ON";
    bool isPaused = true;
    public bool Score
    {
        get { return score; }
        set { score = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        if (playerPrefab)
        {
            player = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if (playerPrefab && !player && Input.GetKeyDown(KeyCode.Return))
        {
            player = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
        }
        scoreText.text = "Score: " + score.ToString();*/

        if (Input.GetMouseButtonDown(0))
        {
            ToggleFlash();
        }
        if (score == false)
        {
            status = "ON";
            scoreText.text = "Flashlight: " + status;
        }
        if (score == true)
        {
            status = "OFF";
            scoreText.text = "Flashlight: " + status;
        }
    }
    public void ToggleFlash()
    {
        GameObject.FindObjectOfType<AudioManager>().PlayToggleFlash();

        isPaused = !isPaused;

        flash.SetActive(isPaused);
        score = !score;

    }

    public void RestartScene()
    {
        //SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene(0);
    }


}
