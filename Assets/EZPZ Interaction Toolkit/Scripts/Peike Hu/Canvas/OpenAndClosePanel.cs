using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClosePanel : MonoBehaviour
{
    public GameObject PanelToOpen;
    public GameObject PanelToClose;

    public void PanelOpen()
    {
        if (PanelToOpen != null)
        {
            PanelToOpen.SetActive(true);
        }
    }
    public void PanelClose()
    {
        if (PanelToClose != null)
        {
            PanelToClose.SetActive(false);
        }
    }
}