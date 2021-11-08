using System;
using Assets.Function1._03.Scripts.Model;
using UnityEngine;

namespace Assets.Function1._03.Scripts.Controller
{
    public class JiaFenController : Read
    {
        public void Start()
        {
            //判断初始分数多少，是否有可以领取的奖励
            Award();
            rankScore.text = score.text;
            Receive.gameObject.SetActive(false);
            Receive1.gameObject.SetActive(false);
            Receive2.gameObject.SetActive(false);
            Receive3.gameObject.SetActive(false);
            Receive4.gameObject.SetActive(false);
            Receive5.gameObject.SetActive(false);
            Receive6.gameObject.SetActive(false);
            Receive7.gameObject.SetActive(false);
            I = Convert.ToInt32(score.text);
        }

        //加分方法
        public void Jia()
        {
            I += 100;
            Award();
            if (I >= 6000)
            {
                I = 6000;
            }

            score.text = I.ToString();
            rankScore.text = I.ToString();
            if (I >= 4200)
            {
                Receive.gameObject.SetActive(true);
            }

            if (I >= 4400)
            {
                Receive1.gameObject.SetActive(true);
            }

            if (I >= 4600)
            {
                Receive2.gameObject.SetActive(true);
            }

            if (I >= 4800)
            {
                Receive3.gameObject.SetActive(true);
            }

            if (I >= 5200)
            {
                Receive4.gameObject.SetActive(true);
            }

            if (I >= 5400)
            {
                Receive5.gameObject.SetActive(true);
            }

            if (I >= 5600)
            {
                Receive6.gameObject.SetActive(true);
            }

            if (I >= 5800)
            {
                Receive7.gameObject.SetActive(true);
            }

            if (I <= 4000)
            {
                Rank.sprite = primary;

                return;
            }

            if (I < 5000)
            {
                rankScore.gameObject.SetActive(false);
                Rank.sprite = master;
            }
            else
            {
                Rank.sprite = King;
            }
        }

        //更新奖励领取次数
        public void LingQu()
        {
            if (Receive0.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
                return;
            }

            if (Receive11.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive22.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive33.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive44.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive55.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive66.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (Receive77.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }
        }

        //重置方法
        public void Reset()
        {
            //重置奖励领取状态
            Receive00.gameObject.SetActive(false);
            Receive111.gameObject.SetActive(false);
            Receive222.gameObject.SetActive(false);
            Receive333.gameObject.SetActive(false);
            Receive444.gameObject.SetActive(false);
            Receive555.gameObject.SetActive(false);
            Receive666.gameObject.SetActive(false);
            Receive777.gameObject.SetActive(false);
            Receive0.gameObject.SetActive(true);
            Receive11.gameObject.SetActive(true);
            Receive22.gameObject.SetActive(true);
            Receive33.gameObject.SetActive(true);
            Receive44.gameObject.SetActive(true);
            Receive55.gameObject.SetActive(true);
            Receive66.gameObject.SetActive(true);
            Receive77.gameObject.SetActive(true);

            J = Convert.ToInt32(saiJi.text);
            J++;
            saiJi.text = J.ToString();
            if (I >= 4000)
            {
                I = 4000 + ((I - 4000) / 2);
                score.text = I.ToString();
                rankScore.text = I.ToString();
            }

            if (I < 4200)
            {
                Receive.gameObject.SetActive(false);
            }

            if (I < 4400)
            {
                Receive1.gameObject.SetActive(false);
            }

            if (I < 4600)
            {
                Receive2.gameObject.SetActive(false);
            }

            if (I < 4800)
            {
                Receive3.gameObject.SetActive(false);
            }

            if (I < 5200)
            {
                Receive4.gameObject.SetActive(false);
            }

            if (I < 5400)
            {
                Receive5.gameObject.SetActive(false);
            }

            if (I < 5600)
            {
                Receive6.gameObject.SetActive(false);
            }

            if (I < 5800)
            {
                Receive7.gameObject.SetActive(false);
            }

            if (I <= 4000)
            {
                Rank.sprite = primary;

                return;
            }

            if (I < 5000)
            {
                rankScore.gameObject.SetActive(false);
                Rank.sprite = master;
            }
            else
            {
                Rank.sprite = King;
            }
        }

         void Award()
        {
            if (I == 4200)
            {
                Receive.gameObject.SetActive(true);
            }

            if (I == 4400)
            {
                Receive1.gameObject.SetActive(true);
            }

            if (I == 4600)
            {
                Receive2.gameObject.SetActive(true);
            }

            if (I == 4800)
            {
                Receive3.gameObject.SetActive(true);
            }

            if (I == 5200)
            {
                Receive4.gameObject.SetActive(true);
            }

            if (I == 5400)
            {
                Receive5.gameObject.SetActive(true);
            }

            if (I == 5600)
            {
                Receive6.gameObject.SetActive(true);
            }

            if (I == 5800)
            {
                Receive7.gameObject.SetActive(true);
            }

            else
            {
                Debug.Log("分数不匹配");
            }
        }
    }
}
