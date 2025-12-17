using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact3 : MonoBehaviour
{
    public GameObject b;
    public Vector3 localPosition;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
    public AudioSource audioSource6;
    public AudioSource audioSource7;
    public AudioSource audioSource8;
    public AudioSource audioSource9;
    public AudioSource audioSource10;
    public AudioSource audioSource11;
    public AudioSource audioSource12;
    public AudioSource audioSource13;
    public AudioSource audioSource14;
    public AudioSource audioSource15;
    public AudioSource audioSource16;
    public AudioSource audioSource17;
    public AudioSource audioSource18;
    public AudioSource audioSource19;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("success");
            print(this.transform.position);
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -3.8&&
                this.transform.position.z < -2.6)
            {
                print("1");
                StopallSound();
                audioSource1.Play();//隋朝
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -2.6 &&
                this.transform.position.z < -1.4)
            {
                print("2");
                StopallSound();
                audioSource2.Play();//佛教兴盛
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -1.4 &&
                this.transform.position.z < -0.3)
            {
                print("3");
                StopallSound();
                audioSource3.Play();//莫高窟
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -0.3 &&
                this.transform.position.z < 1)
            {
                print("4");
                StopallSound();
                audioSource4.Play();//京杭大运河
            }
            if (this.transform.position.x < -2.7 &&
                this.transform.position.x > -4.9 &&
                this.transform.position.z > -2.4 &&
                this.transform.position.z < -0.8)
            {
                print("5");
                StopallSound();
                audioSource5.Play();//隋朝短命的原因
            }
            if (this.transform.position.x < -0.81 &&
                this.transform.position.x > -2.3 &&
                this.transform.position.z < -4.87 &&
                this.transform.position.z > -10.64)
            {
                print("6");
                StopallSound();
                audioSource6.Play();//唐朝2
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -5.7 &&
                this.transform.position.z > -7.68)
            {
                print("7");
                StopallSound();
                audioSource7.Play();//唐三彩
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -7.68 &&
                this.transform.position.z > -9.59)
            {
                print("8");
                StopallSound();
                audioSource8.Play();//唐诗
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -9.59 &&
                this.transform.position.z > -11.4)
            {
                print("9");
                StopallSound();
                audioSource9.Play();//贞观之治
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -13.24 &&
                this.transform.position.z > -15.17)
            {
                print("10");
                StopallSound();
                audioSource10.Play();//安史之乱
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -15.17 &&
                this.transform.position.z > -17.4)
            {
                print("11");
                StopallSound();
                audioSource11.Play();//唐朝的灭亡
            }
            if (this.transform.position.x < 2.7 &&
                this.transform.position.x > 1.4 &&
                this.transform.position.z < -16.4 &&
                this.transform.position.z > -17.4)
            {
                print("12");
                StopallSound();
                audioSource12.Play();//宋朝的儒家发展
            }

            if (this.transform.position.x < -0.48 &&
                this.transform.position.x > -1.49 &&
                this.transform.position.z < -16.4 &&
                this.transform.position.z > -17.4)
            {
                print("13");
                StopallSound();
                audioSource13.Play();//宋朝的科技
            }
            if (this.transform.position.x < -3.7 &&
                this.transform.position.x > -5.4 &&
                this.transform.position.z < -16.4 &&
                this.transform.position.z > -17.4)
            {
                print("14");
                StopallSound();
                audioSource14.Play();//宋词
            }

            if (this.transform.position.x < -7 &&
                this.transform.position.x > -8.7 &&
                this.transform.position.z < -16.4 &&
                this.transform.position.z > -17.4)
            {
                print("15");
                StopallSound();
                audioSource15.Play();//宋朝的艺术发展
            }

            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -17.4 &&
                this.transform.position.z < -15.9)
            {
                print("16");
                StopallSound();
                audioSource16.Play();//靖康之变
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -15 &&
                this.transform.position.z < -13.5)
            {
                print("17");
                StopallSound();
                audioSource17.Play();//南宋的灭亡
            }
            if (this.transform.position.x < -2.7 &&
                this.transform.position.x > -4.9 &&
                this.transform.position.z > -14 &&
                this.transform.position.z < -12.9)
            {
                print("18");
                StopallSound();
                audioSource18.Play();//宋朝
            }
            if (this.transform.position.x < -4.4 &&
                this.transform.position.x > -8.4 &&
                this.transform.position.z < -5.8 &&
                this.transform.position.z > -9.4)
            {
                print("19");
                StopallSound();
                audioSource19.Play();//隋唐宋
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        print("success");
    }
    private void StopallSound()
    {
        audioSource1.Stop();
        audioSource2.Stop();
        audioSource3.Stop();
        audioSource4.Stop();
        audioSource5.Stop();
        audioSource6.Stop();
        audioSource7.Stop();
        audioSource8.Stop();
        audioSource9.Stop();
        audioSource10.Stop();
        audioSource11.Stop();
        audioSource12.Stop();
        audioSource13.Stop();
        audioSource14.Stop();
        audioSource15.Stop();
        audioSource16.Stop();
        audioSource17.Stop();
        audioSource18.Stop();
        audioSource19.Stop();


    }

}
