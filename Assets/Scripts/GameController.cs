using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public GameObject Player;

   private bool playingC = false;
   private bool playingA = false;
   private bool playingG = false;
   private bool playingE = false;
   private bool playingD = false;


   public AudioSource c;
   public AudioSource a;
   public AudioSource g;
   public AudioSource e;
   public AudioSource d;

   public GameObject PointerC;
   public GameObject PointerA;
   public GameObject PointerG;
   public GameObject PointerE;
   public GameObject PointerD;

   public GameObject t1;
   public GameObject t2;
   public GameObject t3;
   public GameObject t4;
   public GameObject t5;
   public GameObject t6;
   public GameObject t7;
   public GameObject t8;
   public GameObject t9;

   private bool firstC = false;


   private void Start()
   {
      t1.SetActive(true);
   }

   private void Update()
   {
      if (Input.GetKeyDown("c"))
      {
         StopAllCoroutines();
         if(firstC==false)
         {
            Player.GetComponent<Animator>().Play("c");
            playingC = true;
            firstC = true;

         }
         if (playingA==true&&firstC==true)
         {
            Debug.Log("AHDFASGHDASDGHASDGASDGJKSADGHSADGJKASDGJASDSADGJASDGHASDJK");
            Player.GetComponent<Animator>().Play("a-c");
            playingC = true;
            playingA = false;
         }
         if (playingG)
         {
            Player.GetComponent<Animator>().Play("g-c");
            playingC = true;
            playingG = false;
         }
         if (playingE)
         {
            Player.GetComponent<Animator>().Play("e-c");
            playingC = true;
            playingE = false;
         }
         if (playingD)
         {
            Player.GetComponent<Animator>().Play("d-c");
            playingC = true;
            playingD = false;
         }
         
         
        
         StartCoroutine(PressC());
        


      }
      if (Input.GetKeyDown("a"))
      {
         StopAllCoroutines();
         if (playingC)
         {
            Debug.Log("c dogruyken a bastın");
            Player.GetComponent<Animator>().Play("c-a");
            playingA = true;
            playingC = false;
            firstC = true;
            Debug.Log(firstC);
         }
         if (playingG)
         {
            Player.GetComponent<Animator>().Play("g-a");
            playingA = true;
            playingG = false;
         }
         if (playingE)
         {
            Player.GetComponent<Animator>().Play("e-a");
            playingA = true;
            playingE = false;
         }
         
         if (playingD)
         {
            Player.GetComponent<Animator>().Play("d-a");
            playingA = true;
            playingD = false;
         }
         /*else
         {
            Player.GetComponent<Animator>().Play("a");
            playingA = true;
         }*/
        
         
         StartCoroutine(PressA());
        

      }
      if (Input.GetKeyDown("g"))
      {
         StopAllCoroutines();
         if (playingC)
         {
            Player.GetComponent<Animator>().Play("c-g");
            playingG = true;
            playingC = false;
         }
         if (playingA)
         {
            Player.GetComponent<Animator>().Play("a-g");
            playingG = true;
            playingA = false;
         }
         if (playingE)
         {
            Player.GetComponent<Animator>().Play("e-g");
            playingG = true;
            playingE = false;
         }
         
         if (playingD)
         {
            Player.GetComponent<Animator>().Play("d-g");
            playingG = true;
            playingD = false;
         }
         
        /* else
         {
            Player.GetComponent<Animator>().Play("g");
            playingG = true;
         }*/

        StartCoroutine(PressG());
       
      }
      if (Input.GetKeyDown("e"))
      {
         StopAllCoroutines();
         if (playingC)
         {
            Player.GetComponent<Animator>().Play("c-e");
            playingE = true;
            playingC = false;
         }
         if (playingA)
         {
            Player.GetComponent<Animator>().Play("a-e");
            playingE = true;
            playingA = false;
         }
         if (playingG)
         {
            Player.GetComponent<Animator>().Play("g-e");
            playingE = true;
            playingG = false;
         }
         
         if (playingD)
         {
            Player.GetComponent<Animator>().Play("d-e");
            playingE = true;
            playingD = false;
         }


         /*else
         {
            Player.GetComponent<Animator>().Play("e");
            playingE = true;
         }*/
         StartCoroutine(PressE());
         
        
      }
      if (Input.GetKeyDown("d"))
      {
         StopAllCoroutines();
         if (playingC)
         {
            Player.GetComponent<Animator>().Play("c-d");
            playingD = true;
            playingC = false;
         }
         if (playingA)
         {
            Player.GetComponent<Animator>().Play("a-d");
            playingD = true;
            playingA = false;
         }
         if (playingG)
         {
            Player.GetComponent<Animator>().Play("g-d");
            playingD = true;
            playingG = false;
         }
         
         if (playingE)
         {
            Player.GetComponent<Animator>().Play("e-d");
            playingD = true;
            playingE = false;
         }
         
        /* else
         {
            Player.GetComponent<Animator>().Play("d");
            playingD = true;
         }*/
        StartCoroutine(PressD());
        
        
      }
      
   }

   IEnumerator PressC()
   {
      yield return new WaitForSeconds(0f);
      PointerC.SetActive(true);
      PointerA.SetActive(false);
      PointerG.SetActive(false);
      PointerE.SetActive(false);
      PointerD.SetActive(false);
      yield return new WaitForSeconds(1.6f);
      c.Play();
     
      if (t1 != null && t2 != null)
      {
         Destroy(t1);
         t2.SetActive(true);
      }
   }
   IEnumerator PressA()
   {
      yield return new WaitForSeconds(0f);
      PointerC.SetActive(false);
      PointerA.SetActive(true);
      PointerG.SetActive(false);
      PointerE.SetActive(false);
      PointerD.SetActive(false);
      
      
      yield return new WaitForSeconds(1.6f);
      a.Play();
      
      if (t2 != null && t3 != null)
      {
         Destroy(t2);
         t3.SetActive(true);
      }
   }
   IEnumerator PressG()
   {
      yield return new WaitForSeconds(0f);
      PointerC.SetActive(false);
      PointerA.SetActive(false);
      PointerG.SetActive(true);
      PointerE.SetActive(false);
      PointerD.SetActive(false);
      
      
      yield return new WaitForSeconds(1.6f);
      g.Play();
      
      if (t3 != null && t4 != null)
      {
         Destroy(t3);
         t4.SetActive(true);
      }
   }
   IEnumerator PressE()
   {
      yield return new WaitForSeconds(0f);
      PointerC.SetActive(false);
      PointerA.SetActive(false);
      PointerG.SetActive(false);
      PointerE.SetActive(true);
      PointerD.SetActive(false);
      
      
      yield return new WaitForSeconds(1.6f);
      e.Play();
      
      if (t4 != null && t5 != null)
      {
         Destroy(t4);
         t5.SetActive(true);
      }
   }
   IEnumerator PressD()
   {
      yield return new WaitForSeconds(0f);
      PointerC.SetActive(false);
      PointerA.SetActive(false);
      PointerG.SetActive(false);
      PointerE.SetActive(false);
      PointerD.SetActive(true);
      
      
      yield return new WaitForSeconds(1.7f);
      d.Play();


      if (t5 != null && t6 != null)
      {
         Destroy(t5);
         t6.SetActive(true);
      }
     
   }
}
