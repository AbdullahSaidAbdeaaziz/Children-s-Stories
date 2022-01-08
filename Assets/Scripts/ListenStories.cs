using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ListenStories : MonoBehaviour
{
    public void playListenStory1()
    {
        SceneManager.LoadScene("listenStory1");
    }
    public void playListenStory2()
    {
        SceneManager.LoadScene("listenStory2");
    }
    public void playListenStory3()
    {
        SceneManager.LoadScene("listenStory3");
    }
    public void Back()
    {
        SceneManager.LoadScene("TypesOfStories");
    }

}
