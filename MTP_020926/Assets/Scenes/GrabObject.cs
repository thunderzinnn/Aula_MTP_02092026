
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(XRGrabInteractable))]
public class GrabObject : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private XRGrabInteractable grabInteractable;


    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }
    private void OnEnable()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
        grabInteractable.selectExited.RemoveListener(OnRelease);
    }
    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
        grabInteractable.selectExited.RemoveListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {

        obj.transform.localScale = new Vector3(20, 20, 20);
        Debug.Log("Obj foi pego");
        Debug.Log("controle: " + args.interactorObject.transform.name);
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        {
            obj.transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("Obj foi solto");

        }
    }
}



