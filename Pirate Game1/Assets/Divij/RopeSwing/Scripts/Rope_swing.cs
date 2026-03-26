using System;
using UnityEngine;

public class Rope_swing : MonoBehaviour
{
        [SerializeField] private float maxAngle = 45f;
        [SerializeField] private float swingSpeed = 2f;

        private float startRotation;

        private void Start()
        {
                startRotation = transform.eulerAngles.z;
        }

        private void Update()
        {
                float angle = Mathf.Sin(Time.time * swingSpeed) * maxAngle;
                transform.rotation = Quaternion.Euler(0, 0, startRotation + angle);
        }
}
