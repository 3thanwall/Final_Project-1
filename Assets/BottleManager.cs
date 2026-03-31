using UnityEngine;

public class BottleManager : MonoBehaviour
{
    public int bottlesGrabbed = 0;

    public Transform player;        // XR Rig (NOT camera)
    public Transform teleportPoint; // where you want to go

    public void BottleGrabbed()
    {
        bottlesGrabbed++;

        Debug.Log("Bottles grabbed: " + bottlesGrabbed);

        if (bottlesGrabbed >= 7)
        {
            TeleportPlayer();
        }
    }

    void TeleportPlayer()
    {
        Debug.Log("TELEPORTING NOW");

        if (player != null && teleportPoint != null)
        {
            player.position = teleportPoint.position;
        }
        else
        {
            Debug.LogWarning("Player or TeleportPoint not assigned!");
        }
    }
}