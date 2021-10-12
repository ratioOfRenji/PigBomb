using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject losePannel;
   public void LoadLvlOne()
    {
        
        StartCoroutine (waitBeforeLoad());
    }
    private IEnumerator waitBeforeLoad()
    {
        yield return new WaitForSeconds(.6f);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    private void Update()
    {
        if(Player == null)
        {
            losePannel.SetActive(true);
        }
    }
}
