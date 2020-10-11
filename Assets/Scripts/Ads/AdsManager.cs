#define TEST
using UnityEngine;
using UnityEngine.Advertisements;

namespace Ads
{
    public class AdsManager : MonoBehaviour, IUnityAdsListener
    {

        #if UNITY_IOS
        private string _gameId = "3858119";
        #elif UNITY_ANDROID
        private string _gameId = "3858118";
        #else
        private string _gameId = "1234567";

        #endif

        #if TEST
        private bool _isTest = true;
#else
        private bool _isTest = false;
#endif


        private void Start()
        {
            Advertisement.Initialize(_gameId, _isTest);
            Advertisement.AddListener(this);

            //_rewardedAdsListener = transform.GetChild(0).GetComponent<IUnityAdsListener>();

        }

        private void OnEnable()
        {
            EventManager.PlayAdsEvent += ShowAds;
        }

        private void OnDisable()
        {
            EventManager.PlayAdsEvent -= ShowAds;
        }


        private void ShowAds(AdsPlacementType adsType)
        {
            switch (adsType)
            {
                case AdsPlacementType.rewardedVideo:
                    if (Advertisement.IsReady(adsType.ToString()))
                    {
                        Advertisement.Show(adsType.ToString());
                    }
                    else
                    {
                        Debug.LogWarning("Don't have any rewarded ads in the pool");
                    }
                    break;
                case AdsPlacementType.bannerPlacement:
                    Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
                    Advertisement.Banner.Show(adsType.ToString());
                    break;
                case AdsPlacementType.intersitialAds:
                    if (Advertisement.IsReady())
                    {
                        Advertisement.Show();
                    }
                    else
                    {
                        Debug.LogWarning("havuz boş");
                    }
                    break;
            }
        }

        public void OnUnityAdsReady(string placementId)
        {
        }

        public void OnUnityAdsDidError(string message)
        {
        }

        public void OnUnityAdsDidStart(string placementId)
        {
        }

        public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
        {
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
    }
}