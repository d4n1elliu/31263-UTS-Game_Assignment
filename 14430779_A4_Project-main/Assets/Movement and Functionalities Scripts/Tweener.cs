using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    private bool isTweening = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTweens();
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        //Check if there is a active tween
        if (!isTweening)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
            isTweening = true; // Set the flag to indicate an active tween
        }
    }
    public void UpdateTweens()
    {
        if (!isTweening && activeTween != null)
        {
            if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
            {
                float timeFraction = (Time.time - activeTween.StartTime) / activeTween.Duration;
                timeFraction = Mathf.Pow(timeFraction, 3);
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, timeFraction);
            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                isTweening = false; // Reset the flag when the tween is completed
                activeTween = null; // Clear the active tween
            }
        }
    }
}
