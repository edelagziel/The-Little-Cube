using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MYYLevelLoder : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] private int LevelNum; 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void loadLevels(int LevelNum)
    {
        SceneManager.LoadScene(LevelNum);
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void OpenUrl(string WebsiteAdress)
    {
        Application.OpenURL(WebsiteAdress);
    }
}
