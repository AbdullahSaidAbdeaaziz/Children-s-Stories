using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReadingStorySelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayStory1() {
        SceneManager.LoadScene("ReadingStroy1");
    }

    public void PlayStory2() {
        SceneManager.LoadScene("ReadingStroy2");
    }
    public void PlayStory3() {
        SceneManager.LoadScene("ReadingStroy3");
    }
    public void PlayStory4() {
        SceneManager.LoadScene("ReadingStroy4");
    }
    public void PlayStory5()
    {
        SceneManager.LoadScene("ReadingStroy5");
    }

}
