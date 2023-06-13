using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public float rotA = -90f;
    public float rotB = 0f;
    public float duration = 0.5f;
    private IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine(RotateX(rotA, rotB, duration));
            yield return StartCoroutine(RotateX(rotB, rotA, duration));
        }
    }

    private IEnumerator RotateX(float startAngle, float endAngle, float duration = 1f)
    {
        float time = 0f;
        while (time < duration)
        {
            float angle = Mathf.Lerp(startAngle, endAngle, time / duration);
            transform.rotation = Quaternion.Euler(angle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = Quaternion.Euler(endAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }


}
