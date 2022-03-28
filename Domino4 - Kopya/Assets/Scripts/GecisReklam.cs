using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GecisReklam : MonoBehaviour
{
    public InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestInterstitial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RequestInterstitial()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4931702315582966/2217758710";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
}
