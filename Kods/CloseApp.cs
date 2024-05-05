using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApp : MonoBehaviour
{   
    /// <summary>
    /// <c>Close()</c>Closes an app
    /// </summary>
    public void Close()
    {
        Transform parentTransform1 = transform.parent;
        Transform parentTransform = parentTransform1.parent;
        Destroy(parentTransform.gameObject);
        GameObject.FindWithTag("Fade").GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
