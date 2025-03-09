using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADManager : Singleton<ADManager>
{
    string gameId = "1234567";
    string myPlacementId = "rewardedVideo";
    bool testMode = true;

    /// <summary>
    /// Initialize the Ads listener and service
    /// </summary>
    void Start()
    {
     
    }
    
    
    /*/// <summary>
    /// Rewarded video ads
    /// </summary>
    public void ShowRewardedVideo(Action<ShowResult> action)
    {
        this.action = action;

        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }*/

    /// <summary>
    /// Implement IUnityAdsListener interface methods
    /// </summary>
   
}


