using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;

public class JiaFenController : MonoBehaviour
{
   //声明8个奖励按钮
   public Button receive;
   public Button receive1;
   public Button receive2;
   public Button receive3;
   public Button receive4;
   public Button receive5;
   public Button receive6;
   public Button receive7;
   
   //声明不同段位图片
   [FormerlySerializedAs("Rank")] public Image Rank;
   [FormerlySerializedAs("primary")] public Sprite primary;
   [FormerlySerializedAs("master")] public Sprite master;
   [FormerlySerializedAs("King")] public Sprite King;
   
   //声明分数面板
   public Text score;
   public Text rankScore;
   //声明赛季面板
   public Text saiJi;
   int i;
   private int j;
   public void Start()
   { 
      //判断初始分数多少，是否有可以领取的奖励
      award();
      rankScore.text = score.text;
      receive.gameObject.SetActive(false);
      receive1.gameObject.SetActive(false);
      receive2.gameObject.SetActive(false);
      receive3.gameObject.SetActive(false);
      receive4.gameObject.SetActive(false);
      receive5.gameObject.SetActive(false);
      receive6.gameObject.SetActive(false);
      receive7.gameObject.SetActive(false);
      
      
      i = Convert.ToInt32(score.text);
   }
   
   public void Jia()
   {
      
      i += 100;
      award();
      if (i >= 6000)
      {
         i = 6000;
      }
      score.text = i.ToString();
      rankScore.text = i.ToString();
      if (i >= 4200)
      {
         receive.gameObject.SetActive(true);
      }
      if (i >= 4400)
      {
         receive1.gameObject.SetActive(true);
      }
      if (i >= 4600)
      {
         receive2.gameObject.SetActive(true);
      }
      if (i >= 4800)
      {
         receive3.gameObject.SetActive(true);
      }
      if (i >= 5200)
      {
         receive4.gameObject.SetActive(true);
      }
      if (i >= 5400)
      {
         receive5.gameObject.SetActive(true);
      }
      if (i >= 5600)
      {
         receive6.gameObject.SetActive(true);
      }
      if (i >= 5800)
      {
         receive7.gameObject.SetActive(true);
      }
   }
   public void reset()
   {
      j = Convert.ToInt32(saiJi.text) ;
      j++;
      saiJi.text = j.ToString();
      if (i >= 4000)
      {
         i = 4000 + ((i - 4000) / 2);
         score.text = i.ToString();
         rankScore.text = i.ToString();
      }

      if (i < 4200)
      {
         receive.gameObject.SetActive(false);
      }
      if (i < 4400)
      {
         receive1.gameObject.SetActive(false);
      }
      if (i < 4600)
      {
         receive2.gameObject.SetActive(false);
      }
      if (i < 4800)
      {
         receive3.gameObject.SetActive(false);
      }
      if (i < 5200)
      {
         receive4.gameObject.SetActive(false);
      }
      if (i < 5400)
      {
         receive5.gameObject.SetActive(false);
      }
      if (i < 5600)
      {
         receive6.gameObject.SetActive(false);
      }
      if (i < 5800)
      {
         receive7.gameObject.SetActive(false);
      }
   }

   public void award()
   {
      
      if (i == 4200)
      {
         receive.gameObject.SetActive(true);
      }
      if (i == 4400)
      {
         receive1.gameObject.SetActive(true);
      }
      if (i == 4600)
      {
         receive2.gameObject.SetActive(true);
      }
      if (i == 4800)
      {
         receive3.gameObject.SetActive(true);
      }
      if (i == 5200)
      {
         receive4.gameObject.SetActive(true);
      }
      if (i == 5400)
      {
         receive5.gameObject.SetActive(true);
      }
      if (i == 5600)
      {
         receive6.gameObject.SetActive(true);
      }if (i == 5800)
      {
         receive7.gameObject.SetActive(true);
      }
      
      else
      {
         Debug.Log("分数不匹配");
      }
   }
   public void Update()
   {
      int i;
      i = Convert.ToInt32(score.text);
      if (i <= 4000)
      {
         Rank.sprite = primary;
         
         return;
      }
      if (i < 5000)
      {
         rankScore.gameObject.SetActive(false);
         Rank.sprite = master;
      }
      else 
      {
         Rank.sprite = King;
      }
   }
}
