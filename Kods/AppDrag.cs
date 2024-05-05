using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AppDrag : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public RectTransform app;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvas = FindFirstObjectByType<Canvas>();
        canvasGroup = FindFirstObjectByType<CanvasGroup>();
    }

    /// <summary>
    /// <c>OnPointerDown</c>Change app's order in layer when clicked
    /// </summary>
    public void OnPointerDown(PointerEventData eventData)
    {
        app.transform.SetAsLastSibling();
        canvasGroup.blocksRaycasts = false;
    }

    /// <summary>
    /// <c>OnDrag</c>Secures app-drag so the window can be moved
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        app.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    /// <summary>
    /// <c>OnPointerUp</c>Blocks raycasts of an app
    /// </summary>
    public void OnPointerUp(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }
}
