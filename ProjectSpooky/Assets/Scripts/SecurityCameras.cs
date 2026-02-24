using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SecurityCameras : MonoBehaviour
{
    [SerializeField] CanvasGroup SecurityPanel;

    public GameObject BathroomScreen;

    public GameObject LivingRoomScreen;

    public GameObject HallwayScreen;

    public GameObject KitchenScreen;

    public GameObject laundryRoomScreen;

    public void ShowBathroom()
    {
        BathroomScreen.SetActive(true);
        LivingRoomScreen.SetActive(false);
        HallwayScreen.SetActive(false);
        KitchenScreen.SetActive(false);
        laundryRoomScreen.SetActive(false);
    }

    public void ShowLivingRoom()
    {
        BathroomScreen.SetActive(false);
        LivingRoomScreen.SetActive(true);
        HallwayScreen.SetActive(false);
        KitchenScreen.SetActive(false);
        laundryRoomScreen.SetActive(false);
    }

    public void ShowHallway()
    {
        BathroomScreen.SetActive(false);
        LivingRoomScreen.SetActive(false);
        HallwayScreen.SetActive(true);
        KitchenScreen.SetActive(false);
        laundryRoomScreen.SetActive(false);
    }

    public void ShowKitchen()
    {
        BathroomScreen.SetActive(false);
        LivingRoomScreen.SetActive(false);
        HallwayScreen.SetActive(false);
        KitchenScreen.SetActive(true);
        laundryRoomScreen.SetActive(false);
    }

    public void ShowLaundryRoom()
    {
        BathroomScreen.SetActive(false);
        LivingRoomScreen.SetActive(false);
        HallwayScreen.SetActive(false);
        KitchenScreen.SetActive(false);
        laundryRoomScreen.SetActive(true);
    }

    public void DeactivateCameras()
        {
        BathroomScreen.SetActive(false);
        LivingRoomScreen.SetActive(false);
        HallwayScreen.SetActive(false);
        KitchenScreen.SetActive(false);
        laundryRoomScreen.SetActive(false);
    }

    public void Update()
    {
        if (BathroomScreen.activeSelf || LivingRoomScreen.activeSelf || HallwayScreen.activeSelf || KitchenScreen.activeSelf || laundryRoomScreen.activeSelf)
        {
            SecurityPanel.alpha = 0.25f;
        }
        else SecurityPanel.alpha = 1f;

    }

}

