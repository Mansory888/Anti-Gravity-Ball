using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class admanager : MonoBehaviour
{
    public static admanager instance;


    

    private BannerView banner;
    private string bannerID = "ca-app-pub-3641798613541233/5244479866";

    private InterstitialAd fullsceen;
    private string fullscreenID = "ca-app-pub-3641798613541233/5456039330";


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        Requestfullscreenad();
        MobileAds.Initialize(initStatus => { });
    }

    public void requestbanner()
    {
        banner = new BannerView(bannerID, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        banner.LoadAd(request);

        banner.Show();

    }

    public void hidebanner()
    {
        banner.Hide();
    }
    public void showbanner()
    {
        banner.Show();
    }
    public void destroyban()
    {
        banner.Destroy();
    }

    public void Requestfullscreenad()
    {
        fullsceen = new InterstitialAd(fullscreenID);

        AdRequest request =new AdRequest.Builder().Build();

        fullsceen.LoadAd(request);


    }


    public void Showfullscreenad()
    {
        if (fullsceen.IsLoaded())
        {
            fullsceen.Show();
            gamemenusk.numerofdeaths = 0;

        }
        else {
            Debug.Log("full screen ad not loaded");


        }

    }


}
