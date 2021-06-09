﻿using UnityEngine;

// Token: 0x02000040 RID: 64
public class RandomSfx : MonoBehaviour
{
    // Token: 0x06000151 RID: 337 RVA: 0x00007921 File Offset: 0x00005B21
    private void Awake()
    {
        s = base.GetComponent<AudioSource>();
        if (playOnAwake)
        {
            Randomize();
        }
    }

    // Token: 0x06000152 RID: 338 RVA: 0x00007940 File Offset: 0x00005B40
    public void Randomize()
    {
        s.clip = sounds[UnityEngine.Random.Range(0, sounds.Length - 1)];
        s.pitch = UnityEngine.Random.Range(minPitch, maxPitch);
        s.Play();
    }

    // Token: 0x0400015A RID: 346
    public AudioClip[] sounds;

    // Token: 0x0400015B RID: 347
    [Range(0f, 2f)]
    public float maxPitch = 0.8f;

    // Token: 0x0400015C RID: 348
    [Range(0f, 2f)]
    public float minPitch = 1.2f;

    // Token: 0x0400015D RID: 349
    private AudioSource s;

    // Token: 0x0400015E RID: 350
    public bool playOnAwake = true;
}
