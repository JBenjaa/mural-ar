using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pauseandplay : MonoBehaviour
{
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.

	public VideoPlayer video;
	
	public void play(){
		
		video.Play();
	}
	
	public void Pause(){
		
		video.Pause();
	}
   
}
