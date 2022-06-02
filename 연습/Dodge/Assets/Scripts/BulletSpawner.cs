using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     // 탄알의 원본 프리맵
    public float spawnRateMin = 0.5f;   // 최소 생성 주기
    public float spawnRateMax = 3f;     // 최대 생성 주기

    private Transform target;           // 발사할 대상
    private float spawnRate;            // 생성 주기
    private float timeAfterSpawn;       // 최근 생성 시점에서 지난 시간

    void Start()
    {
        // 스폰 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        // 탄알 생성 간격을 spawnRateMin과 spawnRateMax 사이에서 랜덤 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 설정
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        // timeAfterSpawn 갱신
        // Time.deltaTime 이전 프레임과 현재 프레임 사이의 시간 간격 자동으로 계산.
        // Time.deltaTime == like as 1/60 or 1/120, etc ...
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            // 현재 오브젝트 위치 (transform.position) 현재 오브젝트 회전 (transform.rotation)
            // 으로 bullet 생성
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // 생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
