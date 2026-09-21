using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventSystemController : MonoBehaviour
{
    [SerializeField] private Button firstSelectedButton;

    private GameObject previousSelected;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstSelectedButton.gameObject);
        previousSelected = firstSelectedButton.gameObject;
    }

    private void Update()
    {
        GameObject currentSelected = EventSystem.current.currentSelectedGameObject;

        if (currentSelected != null)
            previousSelected = currentSelected;
        else if (previousSelected != null)
            EventSystem.current.SetSelectedGameObject(previousSelected);
    }
}