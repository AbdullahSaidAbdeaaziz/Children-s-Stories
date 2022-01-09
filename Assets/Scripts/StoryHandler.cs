using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class StoryHandler : MonoBehaviour
{
    public VideoPlayer video;

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

}
