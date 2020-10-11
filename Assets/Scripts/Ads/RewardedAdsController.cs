using UnityEngine;
using UnityEngine.Advertisements;


namespace Ads
{
    public class RewardedAdsController : MonoBehaviour, IUnityAdsListener
    {
        public void OnUnityAdsDidError(string message)
        {
        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
            Debug.Log("?");
            switch (showResult)
            {
                case ShowResult.Failed:
                    //Dont give reward
                    break;
                case ShowResult.Skipped:
                    //Dont give reward
                    break;
                case ShowResult.Finished:
                    Debug.Log("REWARD TO PLAYER, MONEY TO ME");
                    break;
            }
        }

        public void OnUnityAdsDidStart(string placementId)
        {
            Debug.Log("Ads started");

        }

        public void OnUnityAdsReady(string placementId)
        {

        }

        public void OnDisable()
        {
            Advertisement.RemoveListener(this);
        }
    }
}
