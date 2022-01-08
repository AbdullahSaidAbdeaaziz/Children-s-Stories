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
        

        /*videoPlayer.playOnAwake = false;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.RenderTexture;
        videoPlayer.url = "/home/youssef/Unity Projects/Children-s-Stories/Assets/Videos/Story1-out.webm";
        
        VideoBackground.texture = videoPlayer;*/

        
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void BackToReading1(){
        SceneManager.LoadScene("Reading 1");
    }
   
}
