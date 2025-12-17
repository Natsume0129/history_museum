using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact1 : MonoBehaviour
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
            if (this.transform.position.x < -8.3 && 
                this.transform.position.x>-10&&
                this.transform.position.z>0)
            {
                print("yes");
                StopallSound();
                audioSource1.Play();//青铜钟
            }
            if (this.transform.position.x < -5.2 &&
                this.transform.position.x > -8.3 &&
                this.transform.position.z > 0)
            {
                print("2");
                StopallSound(); 
                audioSource2.Play();//陶器
            }
            if (this.transform.position.x < -2.7 &&
                this.transform.position.x > -5.2 &&
                this.transform.position.z > 0)
            {
                print("3");
                StopallSound();
                audioSource3.Play();//青铜爵
            }
            if (this.transform.position.x < 3 &&
                this.transform.position.x > -2.7 &&
                this.transform.position.z > 0)
            {
                print("4");
                StopallSound();
                audioSource4.Play();//编钟响声
            }
            if (this.transform.position.x < -2.8 &&
                this.transform.position.x > -4.9 &&
                this.transform.position.z < -1 &&
                this.transform.position.z > -3)
            {
                print("5");
                StopallSound();
                audioSource5.Play();//夏商周
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -4.5 &&
                this.transform.position.z > -6.5)
            {
                print("6");
                StopallSound();
                audioSource6.Play();//春秋五霸
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -6.5 &&
                this.transform.position.z > -8.8)
            {
                print("7");
                StopallSound();
                audioSource7.Play();//战国七雄
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -8.8 &&
                this.transform.position.z > -11)
            {
                print("8");
                StopallSound();
                audioSource8.Play();//百家争鸣
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -13.6&&
                this.transform.position.z > -14.9)
            {
                print("9");
                StopallSound();
                audioSource9.Play();//儒家
            }

            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -14.9 &&
                this.transform.position.z > -16.2)
            {
                print("10");
                StopallSound();
                audioSource10.Play();//法家
            }
            if (this.transform.position.x < 2.9 &&
                this.transform.position.x > 1.8 &&
                this.transform.position.z < -16.2 &&
                this.transform.position.z > -17.3)
            {
                print("11");
                StopallSound();
                audioSource11.Play();//道家
            }
            if (this.transform.position.x < 1.7 &&
                this.transform.position.x > 0.5 &&
                this.transform.position.z < -16.2 &&
                this.transform.position.z > -17.3)
            {
                print("12");
                StopallSound();
                audioSource12.Play();//秦的历史贡献
            }

            if (this.transform.position.x < -4.8 &&
                this.transform.position.x > -7.1 &&
                this.transform.position.z < -16.2 &&
                this.transform.position.z > -17.3)
            {
                print("13");
                StopallSound();
                audioSource13.Play();//焚书坑儒
            }
            if (this.transform.position.x < -9&&
                this.transform.position.x > -10.1 &&
                this.transform.position.z < -16.5 &&
                this.transform.position.z > -17.3)
            {
                print("14");
                StopallSound();
                audioSource14.Play();//泽山刻石
            }

            if (this.transform.position.x < -9 &&
                this.transform.position.x > -10.1 &&
                this.transform.position.z < -13.4 &&
                this.transform.position.z > -15.1)
            {
                print("15");
                StopallSound();
                audioSource15.Play();//儒家
            }

            if (this.transform.position.x < -3 &&
                this.transform.position.x > -4.8 &&
                this.transform.position.z < -12.9 &&
                this.transform.position.z > -14.1)
            {
                print("16");
                StopallSound();
                audioSource16.Play();//法家
            }
            if (this.transform.position.x < -4.4 &&
                this.transform.position.x > -8.4 &&
                this.transform.position.z < -5.8 &&
                this.transform.position.z > -9.4)
            {
                print("17");
                StopallSound();
                audioSource17.Play();//道家
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
    }

}
