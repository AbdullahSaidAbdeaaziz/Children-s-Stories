using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StorySelector : MonoBehaviour
{
    public void PlayStory1()
    {
        SceneManager.LoadScene("Story1");
    }
    public void PlayStory2()
    {
        SceneManager.LoadScene("Story2");
    }
    public void PlayStory3()
    {
        SceneManager.LoadScene("Story3");
    }

    public void PlayStory4()
    {
        SceneManager.LoadScene("Story4");
    }

}
