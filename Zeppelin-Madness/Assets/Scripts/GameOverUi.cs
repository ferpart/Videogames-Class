using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverUi : MonoBehaviour
{
    public Texture2D textureToDisplay;
    void OnGUI()
    {
        GUI.Label(new Rect(100, -100, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
    }


    public string SceneToLoad = "Level 1";
    public float DelayTime = 5.0f;
    public void Start()
    {
        StartCoroutine("Wait");
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(DelayTime);

        SceneManager.LoadScene(SceneToLoad, LoadSceneMode.Single);
    }

}
