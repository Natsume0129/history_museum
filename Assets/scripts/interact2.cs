using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact2 : MonoBehaviour
{
    // Start is called before the first frame update
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
    public AudioSource audioSource20;
    public AudioSource audioSource21;
    public AudioSource audioSource22;
    public AudioSource audioSource23;
    public AudioSource audioSource24;

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
                this.transform.position.z > -3.5&&
                this.transform.position.z<-2.25)
            {
                print("1");
                StopallSound();
                audioSource1.Play();//汉朝的建立
            }
            if (this.transform.position.x < -6.5 &&
                this.transform.position.x > -7.8 &&
                this.transform.position.z > -2.1)
            {
                print("2");
                StopallSound();
                audioSource2.Play();//马踏飞燕
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -2.25&&
                this.transform.position.z < -0.75)
            {
                print("3");
                StopallSound();
                audioSource3.Play();//文景之治
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > -0.75 &&
                this.transform.position.z < 0.8)
            {
                print("4");
                StopallSound();
                audioSource4.Play();//王莽篡汉
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z > 0.8 &&
                this.transform.position.z < 2.1)
            {
                print("5");
                StopallSound();
                audioSource5.Play();//汉朝的灭亡
            }
            if (this.transform.position.x < -3.5 &&
                this.transform.position.x > -5 &&
                this.transform.position.z < 2.3 &&
                this.transform.position.z > 0.8)
            {
                print("6");
                StopallSound();
                audioSource6.Play();//汉服sasa
            }

            if (this.transform.position.x < -3.5 &&
                this.transform.position.x > -5 &&
                this.transform.position.z < -0.8 &&
                this.transform.position.z > -2.3)
            {
                print("7");
                StopallSound();
                audioSource7.Play();//汉朝
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.9 &&
                this.transform.position.z < 1.3 &&
                this.transform.position.z > 0)
            {
                print("8");
                StopallSound();
                audioSource8.Play();//汉朝的科技发明
            }

            if (this.transform.position.x < 2.9&&
                this.transform.position.x > 1.9 &&
                this.transform.position.z < -1 &&
                this.transform.position.z > -2)
            {
                print("9");
                StopallSound();
                audioSource9.Play();//造纸术
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 2 &&
                this.transform.position.z < -5.4 &&
                this.transform.position.z > -11)
            {
                print("10");
                StopallSound();
                audioSource10.Play();//浑天仪
            }
            if (this.transform.position.x < -1.69 &&
                this.transform.position.x > -2.4 &&
                this.transform.position.z < -5.4 &&
                this.transform.position.z > -11)
            {
                print("11");
                StopallSound();
                audioSource11.Play();//地动仪
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 2.5 &&
                this.transform.position.z < -13.4 &&
                this.transform.position.z > -15)
            {
                print("12");
                StopallSound();
                audioSource12.Play();//东晋的政治制度
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 2.5 &&
                this.transform.position.z < -15 &&
                this.transform.position.z > -16.2)
            {
                print("13");
                StopallSound();
                audioSource13.Play();//九品中正制
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 2.5 &&
                this.transform.position.z < -16.2 &&
                this.transform.position.z > -17.4)
            {
                print("14");
                StopallSound();
                audioSource14.Play();//均田制
            }

            if (this.transform.position.x < 2.3 &&
                this.transform.position.x > 0.3 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("15");
                StopallSound();
                audioSource15.Play();//文学艺术发展
            }

            if (this.transform.position.x < 0.3 &&
                this.transform.position.x > -1.7 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("16");
                StopallSound();
                audioSource16.Play();//文学发展2
            }
            if (this.transform.position.x < -1.7 &&
                this.transform.position.x > -3.7 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("17");
                StopallSound();
                audioSource17.Play();//文学发展3
            }
            if (this.transform.position.x < -3.7 &&
                this.transform.position.x > -5.7 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("18");
                StopallSound();
                audioSource18.Play();//文学发展4
            }
            if (this.transform.position.x < -5.7 &&
                this.transform.position.x > -7.7 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("19");
                StopallSound();
                audioSource19.Play();//书法的高峰
            }
            if (this.transform.position.x < -7.7 &&
                this.transform.position.x > -9 &&
                this.transform.position.z < -16.6 &&
                this.transform.position.z > -17.4)
            {
                print("20");
                StopallSound();
                audioSource20.Play();//书法的高峰2
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z < -16.3 &&
                this.transform.position.z > -17.4)
            {
                print("21");
                StopallSound();
                audioSource21.Play();//魏晋南北朝的文学
            }
            if (this.transform.position.x < -9 &&
                this.transform.position.x > -11 &&
                this.transform.position.z < -13.3 &&
                this.transform.position.z > -15)
            {
                print("22");
                StopallSound();
                audioSource22.Play();//文学特点
            }
            if (this.transform.position.x < -3 &&
                this.transform.position.x > -4.8 &&
                this.transform.position.z < -12.9 &&
                this.transform.position.z > -14.1)
            {
                print("23");
                StopallSound();
                audioSource23.Play();//水车
            }
            if (this.transform.position.x < -4.4 &&
                this.transform.position.x > -8.4 &&
                this.transform.position.z < -5.8 &&
                this.transform.position.z > -9.4)
            {
                print("24");
                StopallSound();
                audioSource24.Play();//汉晋馆
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
        audioSource20.Stop();
        audioSource21.Stop();
        audioSource22.Stop();
        audioSource23.Stop(); 
        audioSource24.Stop();
              
    }

}
