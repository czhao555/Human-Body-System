using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public Text currentVideoTime, totalVideoTime;
    public RawImage image;
    public GameObject playIcon;
    public GameObject pauseIcon;
    public GameObject restartIcon;
    public VideoClip[] videoToPlay;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    private AudioSource audioSource;

    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }
    void Update()
    {
        if (videoPlayer.isPlaying)
        {
            SetCurentTimeUI();
        }
        
        videoPlayer.loopPointReached += EndReached;
    }
    IEnumerator playVideo()
    {
        playIcon.SetActive(false);
        pauseIcon.SetActive(true);
        restartIcon.SetActive(false);
        
        //Add VideoPlayer to the GameObject
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        //Add AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        //Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
        //audioSource.Pause();

        videoPlayer.source = VideoSource.VideoClip;


        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.controlledAudioTrackCount = 1;

        //Assign the Audio from Video to AudioSource to be played
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);
        Debug.Log("ShowInfo.PassNumberofVideo:"+ShowInfo.PassNumberofVideo);
        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay[ShowInfo.PassNumberofVideo];
        videoPlayer.Prepare();

        //Wait until video is prepared
        while (!videoPlayer.isPrepared)
        {
            yield return new WaitForEndOfFrame();
        }
        //Assign the Texture from Video to RawImage to be displayed
        image.texture = videoPlayer.texture;
        //Play Video
        videoPlayer.Play();

        //Play Sound
        audioSource.Play();

        SetTotalTimeUI();
    }
    
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
        playIcon.SetActive(false);
        restartIcon.SetActive(true);
        pauseIcon.SetActive(false);
    }
    void SetCurentTimeUI()
    {
        string minutes = Mathf.Floor((int)videoPlayer.time / 60).ToString("00");
        string seconds = ((int)videoPlayer.time % 60).ToString("00");
        currentVideoTime.text = minutes + ":" + seconds;
    }

    void SetTotalTimeUI()
    {
        string minutes2 = Mathf.Floor((int)videoPlayer.clip.length / 60).ToString("00");
        string seconds2 = ((int)videoPlayer.clip.length % 60).ToString("00");
        totalVideoTime.text = minutes2 + ":" + seconds2;
        
    }
    public void Restart()
    {
        StartCoroutine(playVideo());
    }
    public void Play()
    {
        videoPlayer.Play();
        audioSource.Play();
        playIcon.SetActive(false);
        pauseIcon.SetActive(true);

    }
    public void Pause()
    {
        videoPlayer.Pause();
        audioSource.Pause();
        playIcon.SetActive(true);
        pauseIcon.SetActive(false);
    }

}
