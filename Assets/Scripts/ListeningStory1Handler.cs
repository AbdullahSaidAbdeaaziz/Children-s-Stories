using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ListeningStory1Handler : MonoBehaviour
{
    public RawImage VideoBackground;
    VideoPlayer videoPlayer;
                    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = new VideoPlayer();

        videoPlayer.playOnAwake = false;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.RenderTexture;
        videoPlayer.url = "/home/youssef/Unity Projects/Children-s-Stories/Assets/Videos/Story1-out.webm";
        
        VideoBackground.texture = videoPlayer;

        videoPlayer.Play();
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseVideo() {
        
    }
    public void ResumeVideo() {
         
    }

    public void BackToOralStories(){
        SceneManager.LoadScene("OralStories");
    }
    public void NextStory() {
        // SceneManager.LoadScene("TypesOfStories");
    }
    public void PreviousStory() {
        // SceneManager.LoadScene("TypesOfStories");
    }
    
}
