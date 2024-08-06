using System;
using System.Collections;
using UnityEngine;


namespace CBGames
{
    public class AdmobController : MonoBehaviour
    {
        private void Awake()
        {
        }

        private void Start()
        {
        }


        /// <summary>
        /// Hide the current banner ad
        /// </summary>
        public void HideBanner()
        {
        }


        /// <summary>
        /// Load and show a banner ad
        /// </summary>
        /// <summary>
        /// Request interstitial ad
        /// </summary>
        public void RequestInterstitial()
        {
        }

        /// <summary>
        /// Request rewarded video ad
        /// </summary>
        public void RequestRewardedVideo()
        {
        }

        /// <summary>
        /// Determine whether the interstitial ad is ready
        /// </summary>
        /// <returns></returns>
        public bool IsInterstitialReady() => true;

        /// <summary>
        /// Show interstitial ad with given delay time
        /// </summary>
        /// <param name="delay"></param>
        public void ShowInterstitial(float delay)
        {
        }

        /// <summary>
        /// Determine whether the rewarded video ad is ready
        /// </summary>
        /// <returns></returns>
        public bool IsRewardedVideoReady()
        {
            return false;
        }

        /// <summary>
        /// Show rewarded video ad with given delay time 
        /// </summary>
        /// <param name="delay"></param>
        public void ShowRewardedVideo(float delay)
        {
        }

        //Events callback
        public void LoadAndShowBanner(int i)
        {
            
        }
    }
}