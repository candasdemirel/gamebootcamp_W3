using System.Collections;
using System.Collections.Generic;
using UISystems;
using UnityEngine;

public class StorePanelController : GenericUIPanelController
{

    private PurchaseManager purchaseManager;

    private void Start()
    {
        purchaseManager = PurchaseManager.Instance();
    }

    public override void ClosePanel()
    {
        UIManager.Instance().ClosePanel(UIPanelTypes.creditsPanel);

    }

    public override void OpenPanel()
    {
        gameObject.SetActive(true);


    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            ClosePanel();
        }
    }

    public void BuyConsumable()
    {
        purchaseManager.BuyConsumable();
    }

    public void BuyNonConsumable()
    {
        purchaseManager.BuyNonConsumable();
    }

    public void BuySubscription()
    {
        purchaseManager.BuySubscription();
    }
}
