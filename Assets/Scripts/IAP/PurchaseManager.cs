using System;
using UnityEngine;
using UnityEngine.Purchasing;

public class PurchaseManager : MonoBehaviour, IStoreListener
{
    private static PurchaseManager _instance;



    private static IStoreController storeController;            //Unity Purchasing system,
    private static IExtensionProvider storeExtentionProvider;   //Farklı storelar ile konuşma eklentisi

    public static string productIdConsumable = "consumable";
    public static string productIdNonConsumable = "non-consumable";
    public static string productIdSub = "subscription";

    private static string iosProductSubName = "com.unity3d.subscription.new";
    private static string googleProductSubName = "com.unity3d.subscription.original";

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }

    void Start()
    {
        if (storeController == null)
        {
            InitializePurchasing();
        }
    }

    public static PurchaseManager Instance()
    {
        return _instance;
    }

    private void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
        builder.AddProduct(productIdConsumable, ProductType.Consumable);
        builder.AddProduct(productIdNonConsumable, ProductType.NonConsumable);
        builder.AddProduct(productIdSub, ProductType.Subscription, new IDs()
        {
            { iosProductSubName, AppleAppStore.Name},
            { googleProductSubName,GooglePlay.Name},
        });
        UnityPurchasing.Initialize(this, builder);
    }

    private bool IsInitialized()
    {
        return storeController != null && storeExtentionProvider != null;
    }

    public void BuyConsumable()
    {
        BuyProduct(productIdConsumable);
    }

    public void BuySubscription()
    {
        BuyProduct(productIdSub);
    }

    public void BuyNonConsumable()
    {
        BuyProduct(productIdNonConsumable);
    }

    private void BuyProduct(string productID)
    {
        if (IsInitialized())
        {
            Product product = storeController.products.WithID(productID);

            if(product != null && product.availableToPurchase)
            {
                storeController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("cant get item" + product.definition);
            }
        }
        else
        {
            Debug.LogError("Terrible things happened");
        }
    }

    public void RestorePurchase()
    {
        if (!IsInitialized())
        {
            Debug.LogError("Terrible thigns happened again");
            return;
        }

        if(Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("restoring purchase");
            var apple = storeExtentionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((Result) =>
            {
                Debug.Log("restoring bla bla" + Result);
            });

        }
        else
        {
            Debug.Log("we are not in ios");
        }
    }



    #region Interface Build-In functions
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        storeController = controller;
        storeExtentionProvider = extensions;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.LogError("Init failed");
    }

    public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
    {
     
        Debug.LogError("Purchase failed "+ p + " " + "with product" + i.definition.storeSpecificId);
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if(string.Equals(args.purchasedProduct.definition.id, productIdConsumable, StringComparison.Ordinal))
        {
            Debug.Log("product consumable " + args.purchasedProduct.definition + "is bought succesfully");
            //TODO: Give player / user the product
        }
        else if (string.Equals(args.purchasedProduct.definition.id, productIdNonConsumable, StringComparison.Ordinal))
        {
            Debug.Log("product nonconsumable " + args.purchasedProduct.definition + "is bought succesfully");
            //TODO: Give player / user the product
        }
        else if (string.Equals(args.purchasedProduct.definition.id, productIdSub, StringComparison.Ordinal))
        {
            Debug.Log("product sub" + args.purchasedProduct.definition + "is bought succesfully");
            //TODO: Give player / user the product
        }
        else
        {
            Debug.LogError("Undefined product");
        }


        return PurchaseProcessingResult.Complete;

    }
    #endregion


}
