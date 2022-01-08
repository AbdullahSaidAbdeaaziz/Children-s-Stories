using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class StopAndBackVideo : MonoBehaviour
{
    public VideoPlayer video;

    public void Awake()
    {
        video = GetComponent<VideoPlayer>();
        if (video != null)
        {
            Debug.Log("Video has value");
        }
    }
    public void Back()
    {
        video.Stop();
        SceneManager.LoadScene("Reading 1");
    }
}
