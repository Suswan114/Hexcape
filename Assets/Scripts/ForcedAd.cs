using UnityEngine;
using UnityEngine.Advertisements;

public class ForcedAd : MonoBehaviour{
    string gameId = "3713997";
    bool testMode = false;
    void Start(){
        Advertisement.Initialize(gameId, testMode);
    }
    public void ShowInterstitialAd(){
        if (Advertisement.IsReady())
        { 
            if(collisionmenu.p%5==0)
            { 
                Advertisement.Show();
            }
        }
    }
}