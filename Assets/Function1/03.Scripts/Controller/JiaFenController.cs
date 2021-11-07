using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._03.Scripts.Controller
{
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
      //声明已领取文本
      public Text receive0;
      public Text receive11;
      public Text receive22;
      public Text receive33;
      public Text receive44;
      public Text receive55;
      public Text receive66;
      public Text receive77;
      //声明领取
      public Text receive00;
      public Text receive111;
      public Text receive222;
      public Text receive333;
      public Text receive444;
      public Text receive555;
      public Text receive666;
      public Text receive777;
      
      

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
      private int _i;
      private int _j;
      private int _z;
      public Text Sum;
      public void Start()
      { 
         //判断初始分数多少，是否有可以领取的奖励
         Award();
         rankScore.text = score.text;
         receive.gameObject.SetActive(false);
         receive1.gameObject.SetActive(false);
         receive2.gameObject.SetActive(false);
         receive3.gameObject.SetActive(false);
         receive4.gameObject.SetActive(false);
         receive5.gameObject.SetActive(false);
         receive6.gameObject.SetActive(false);
         receive7.gameObject.SetActive(false);
      
      
         _i = Convert.ToInt32(score.text);
      }
   
      public void Jia()
      {
      
         _i += 100;
         Award();
         if (_i >= 6000)
         {
            _i = 6000;
         }
         score.text = _i.ToString();
         rankScore.text = _i.ToString();
         if (_i >= 4200)
         {
            receive.gameObject.SetActive(true);
         }
         if (_i >= 4400)
         {
            receive1.gameObject.SetActive(true);
         }
         if (_i >= 4600)
         {
            receive2.gameObject.SetActive(true);
         }
         if (_i >= 4800)
         {
            receive3.gameObject.SetActive(true);
         }
         if (_i >= 5200)
         {
            receive4.gameObject.SetActive(true);
         }
         if (_i >= 5400)
         {
            receive5.gameObject.SetActive(true);
         }
         if (_i >= 5600)
         {
            receive6.gameObject.SetActive(true);
         }
         if (_i >= 5800)
         {
            receive7.gameObject.SetActive(true);
         }
      }

      public void Receive()
      {
         if (receive00.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
            return;
         }
         if (receive111.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive222.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive333.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive444.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive555.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive666.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
         if (receive777.gameObject.activeSelf == false)
         {
            _z = Convert.ToInt32(Sum.text) ;
            _z++;
            Sum.text = _z.ToString();
         }
      }
      public void Reset()
      {
         //重置领取状态
         receive0.gameObject.SetActive(false);
         receive11.gameObject.SetActive(false);
         receive22.gameObject.SetActive(false);
         receive33.gameObject.SetActive(false);
         receive44.gameObject.SetActive(false);
         receive55.gameObject.SetActive(false);
         receive66.gameObject.SetActive(false);
         receive77.gameObject.SetActive(false);
         receive00.gameObject.SetActive(true);
         receive111.gameObject.SetActive(true);
         receive222.gameObject.SetActive(true);
         receive333.gameObject.SetActive(true);
         receive444.gameObject.SetActive(true);
         receive555.gameObject.SetActive(true);
         receive666.gameObject.SetActive(true);
         receive777.gameObject.SetActive(true);
         
         _j = Convert.ToInt32(saiJi.text) ;
         _j++;
         saiJi.text = _j.ToString();
         if (_i >= 4000)
         {
            _i = 4000 + ((_i - 4000) / 2);
            score.text = _i.ToString();
            rankScore.text = _i.ToString();
         }

         if (_i < 4200)
         {
            receive.gameObject.SetActive(false);
         }
         if (_i < 4400)
         {
            receive1.gameObject.SetActive(false);
         }
         if (_i < 4600)
         {
            receive2.gameObject.SetActive(false);
         }
         if (_i < 4800)
         {
            receive3.gameObject.SetActive(false);
         }
         if (_i < 5200)
         {
            receive4.gameObject.SetActive(false);
         }
         if (_i < 5400)
         {
            receive5.gameObject.SetActive(false);
         }
         if (_i < 5600)
         {
            receive6.gameObject.SetActive(false);
         }
         if (_i < 5800)
         {
            receive7.gameObject.SetActive(false);
         }
      }

     public void Award()
      {
      
         if (_i == 4200)
         {
            receive.gameObject.SetActive(true);
         }
         if (_i == 4400)
         {
            receive1.gameObject.SetActive(true);
         }
         if (_i == 4600)
         {
            receive2.gameObject.SetActive(true);
         }
         if (_i == 4800)
         {
            receive3.gameObject.SetActive(true);
         }
         if (_i == 5200)
         {
            receive4.gameObject.SetActive(true);
         }
         if (_i == 5400)
         {
            receive5.gameObject.SetActive(true);
         }
         if (_i == 5600)
         {
            receive6.gameObject.SetActive(true);
         }if (_i == 5800)
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
         int toInt32;
         toInt32 = Convert.ToInt32(score.text);
         if (toInt32 <= 4000)
         {
            Rank.sprite = primary;
         
            return;
         }
         if (toInt32 < 5000)
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
}
