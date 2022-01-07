using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Selector : MonoBehaviour
{
    public void Listen()
    {
        SceneManager.LoadScene("Listen");
    }
    public void Reading()
    {
        SceneManager.LoadScene("Reading");
    }
    public void Menu()
    {
        SceneManager.LoadScene("TypesOfStories");
    }
    public void ReadingStory1()
    {
        SceneManager.LoadScene("Stroy1");
    }
    public void ReadingStory2()
    {
        SceneManager.LoadScene("Stroy2");
    }
    public void ReadingStory3()
    {
        SceneManager.LoadScene("Stroy3");
    }
    public void ReadingStory4()
    {
        SceneManager.LoadScene("Stroy4");
    }
    public void ReadingStory5()
    {
        SceneManager.LoadScene("Stroy5");
    }
    //---------------------------------------
    public void AudioStory1()
    {
        SceneManager.LoadScene("AudioStroy1");
    }
    public void AudioStory2()
    {
        SceneManager.LoadScene("AudioStroy2");
    }
    public void AudioStory3()
    {
        SceneManager.LoadScene("AudioStroy3");
    }

    public void BackToTypesOfStories()
    {
        SceneManager.LoadScene("TypesOfStories");
    }
    
}
