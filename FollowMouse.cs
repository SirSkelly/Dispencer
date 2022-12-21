using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject ObjectOrigin;
    public AudioSource Source;
    public AudioClip Clip;

    public int CurrentMetalLevel = 0;
    public string Finished = "True";

    public void Start()
    {
        UpdateArrow();
    }

    public void LevelUp()
    {
        if (CurrentMetalLevel > -1 && CurrentMetalLevel < 8 && Finished == "True")
        {
            CurrentMetalLevel++;
            UpdateArrow();
            
        }
        Source.PlayOneShot(Clip);
    }

    public void LevelDown()
    {
        if (CurrentMetalLevel > 0 && CurrentMetalLevel <= 9 && Finished == "True")
        {
            CurrentMetalLevel--;
            Finished= "False";
            UpdateArrow();
        }
    }

    public void UpdateArrow()
    {
        switch (CurrentMetalLevel)
        {
            case 0:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, 87f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f,0f,87f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 1:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, 64.76f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, 64.76f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 2:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, 37.09f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, 37.09f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 3:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, 20f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, 20f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 4:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, 0f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 5:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, -18f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, -18f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 6:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, -38.88f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, -38.88f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 7:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, -67.25f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, -67.25f);
                Invoke("LeanFinished", 1.6f);
                break;

            case 8:
                LeanTween.rotate(ObjectOrigin, new Vector3(0f, 0f, -88.3f), 0.35f);
                //ObjectOrigin.transform.rotation = Quaternion.Euler(0f, 0f, -88.3f);
                Invoke("LeanFinished", 1.6f);
                break;

            default:
                break;
        }
    }

    void LeanFinished()
    {
        Finished = "True";
    }
}
