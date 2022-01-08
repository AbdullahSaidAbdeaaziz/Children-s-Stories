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


    public void BackToTypesOfStories()
    {
        SceneManager.LoadScene("TypesOfStories");
    }
    
}
