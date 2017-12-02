using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InitialPlaceByTap : MonoBehaviour, IInputClickHandler
{
    protected AudioSource Sound;
    protected MoveByGaze GazeMover;

    void Start()
    {
        Sound = GetComponent<AudioSource>();
        GazeMover = GetComponent<MoveByGaze>();

        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnInputClicked(InputEventData eventData)
    {
        if (!GazeMover.IsActive)
        {
            return;
        }

        if (Sound != null)
        {
            Sound.Play();
        }

        GazeMover.IsActive = false;
    }

    void IInputClickHandler.OnInputClicked(InputClickedEventData eventData)
    {
        if (!GazeMover.IsActive)
        {
            return;
        }

        if (Sound != null)
        {
            Sound.Play();
        }

        GazeMover.IsActive = false;
    }
}
