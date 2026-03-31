using UnityEngine;

public class BottleGrabHandler : MonoBehaviour
{
    public BottleManager manager;
    private bool alreadyGrabbed = false;

    // Called when you FIRST grab
    public void OnGrab()
    {
        if (alreadyGrabbed) return;

        alreadyGrabbed = true;
        manager.BottleGrabbed();
    }

    // 👇 NEW: called when you LET GO
    public void OnRelease()
    {
        Destroy(gameObject);
        // OR use this instead if you prefer:
        // gameObject.SetActive(false);
    }
}