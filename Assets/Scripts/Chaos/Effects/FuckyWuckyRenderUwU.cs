﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chaos
{
    [Effect("chaos.knightbus", "Mind your head"), ConflictsWith(typeof(DisableShit.Car))] // Thanks to Dit0h for the name
    public class FuckyWuckyRenderUwU : ChaosEffect
    {
        Vector3 og;
        Vector3 target;
        Transform victim;

        private void OnEnable()
        {
            victim = car.transform.GetChild(0);
            og = victim.localScale;
        }

        float time;

        private void Update()
        {
            if (time == 0f) target = Vector3.Scale(og, new Vector3(Random.Range(-3f, 3f), Random.Range(-1f, 3f), Random.Range(-3f, 3f)));
            time += Time.deltaTime;
            victim.localScale = Vector3.Lerp(og, target, Mathf.PingPong(time, 2.5f) / 2.5f);
            if (time > 5f) time = 0f;
        }

        private void OnDisable()
        {
            victim.localScale = og;
        }
    }
}
