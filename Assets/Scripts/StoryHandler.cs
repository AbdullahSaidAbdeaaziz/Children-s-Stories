using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class StoryHandler : MonoBehaviour
{
    public VideoPlayer video;

    void Start() {
        
    }

    public void Back()
    {
        video.Stop();

        SceneManager.LoadScene("Stories");
    }
    
    public void ResumeVideo() {
        video.Play();
    }
    
    public void PauseVideo() {
        video.Pause();
    }
    public void PreviousStory() {
        if(!(SceneManager.GetActiveScene().name == "Story1")){
            video.Stop();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void NextStory() {
        if(!(SceneManager.GetActiveScene().name == "Story4")){
            video.Stop();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
