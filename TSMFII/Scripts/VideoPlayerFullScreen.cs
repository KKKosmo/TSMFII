using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerFullScreen : MonoBehaviour
{
    public RectTransform playButton, pauseButton, stopButton, fullscreenButton;
    public RectTransform rendererImage, slider;

    public RectTransform playButtonO, pauseButtonO, stopButtonO, fullscreenButtonO;
    public RectTransform rendererImageO, sliderO;

    public RectTransform playButtonF, pauseButtonF, stopButtonF, fullscreenButtonF;
    public RectTransform rendererImageF, sliderF;

    public bool fullscreen = false;

    public GameObject background;

    public void FullScreen()
    {
        fullscreen = !fullscreen;
        if (!fullscreen)
        {
            background.SetActive(false);
            rendererImage.rotation = rendererImageO.rotation;
            rendererImage.position = rendererImageO.position;
            rendererImage.localScale = rendererImageO.localScale;
            rendererImage.sizeDelta = rendererImageO.sizeDelta;


            fullscreenButton.position = fullscreenButtonO.position;
            fullscreenButton.rotation = fullscreenButtonO.rotation;

            playButton.position = playButtonO.position;
            playButton.rotation = playButtonO.rotation;

            pauseButton.position = pauseButtonO.position;
            pauseButton.rotation = pauseButtonO.rotation;

            stopButton.position = stopButtonO.position;
            stopButton.rotation = stopButtonO.rotation;

            slider.position = sliderO.position;
            slider.rotation = sliderO.rotation;
            slider.sizeDelta = sliderO.sizeDelta;
            slider.localScale = sliderO.localScale;
        }
        else
        {
            background.SetActive(true);
            rendererImage.rotation = rendererImageF.rotation;
            rendererImage.position = rendererImageF.position;
            rendererImage.localScale = rendererImageF.localScale;
            rendererImage.sizeDelta = rendererImageF.sizeDelta;

            fullscreenButton.position = fullscreenButtonF.position;
            fullscreenButton.rotation = fullscreenButtonF.rotation;

            playButton.position = playButtonF.position;
            playButton.rotation = playButtonF.rotation;

            pauseButton.position = pauseButtonF.position;
            pauseButton.rotation = pauseButtonF.rotation;

            stopButton.position = stopButtonF.position;
            stopButton.rotation = stopButtonF.rotation;

            slider.position = sliderF.position;
            slider.rotation = sliderF.rotation;
            slider.sizeDelta = sliderF.sizeDelta;
            slider.localScale = sliderF.localScale;
        }
    }
}
