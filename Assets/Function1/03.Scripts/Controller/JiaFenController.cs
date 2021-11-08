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
            receive.gameObject.SetActive(false);
            receive1.gameObject.SetActive(false);
            receive2.gameObject.SetActive(false);
            receive3.gameObject.SetActive(false);
            receive4.gameObject.SetActive(false);
            receive5.gameObject.SetActive(false);
            receive6.gameObject.SetActive(false);
            receive7.gameObject.SetActive(false);
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
                receive.gameObject.SetActive(true);
            }

            if (I >= 4400)
            {
                receive1.gameObject.SetActive(true);
            }

            if (I >= 4600)
            {
                receive2.gameObject.SetActive(true);
            }

            if (I >= 4800)
            {
                receive3.gameObject.SetActive(true);
            }

            if (I >= 5200)
            {
                receive4.gameObject.SetActive(true);
            }

            if (I >= 5400)
            {
                receive5.gameObject.SetActive(true);
            }

            if (I >= 5600)
            {
                receive6.gameObject.SetActive(true);
            }

            if (I >= 5800)
            {
                receive7.gameObject.SetActive(true);
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
        public void Receive()
        {
            if (receive0.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
                return;
            }

            if (receive11.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive22.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive33.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive44.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive55.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive66.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive77.gameObject.activeSelf == false)
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
            receive00.gameObject.SetActive(false);
            receive111.gameObject.SetActive(false);
            receive222.gameObject.SetActive(false);
            receive333.gameObject.SetActive(false);
            receive444.gameObject.SetActive(false);
            receive555.gameObject.SetActive(false);
            receive666.gameObject.SetActive(false);
            receive777.gameObject.SetActive(false);
            receive0.gameObject.SetActive(true);
            receive11.gameObject.SetActive(true);
            receive22.gameObject.SetActive(true);
            receive33.gameObject.SetActive(true);
            receive44.gameObject.SetActive(true);
            receive55.gameObject.SetActive(true);
            receive66.gameObject.SetActive(true);
            receive77.gameObject.SetActive(true);

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
                receive.gameObject.SetActive(false);
            }

            if (I < 4400)
            {
                receive1.gameObject.SetActive(false);
            }

            if (I < 4600)
            {
                receive2.gameObject.SetActive(false);
            }

            if (I < 4800)
            {
                receive3.gameObject.SetActive(false);
            }

            if (I < 5200)
            {
                receive4.gameObject.SetActive(false);
            }

            if (I < 5400)
            {
                receive5.gameObject.SetActive(false);
            }

            if (I < 5600)
            {
                receive6.gameObject.SetActive(false);
            }

            if (I < 5800)
            {
                receive7.gameObject.SetActive(false);
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

        public void Award()
        {
            if (I == 4200)
            {
                receive.gameObject.SetActive(true);
            }

            if (I == 4400)
            {
                receive1.gameObject.SetActive(true);
            }

            if (I == 4600)
            {
                receive2.gameObject.SetActive(true);
            }

            if (I == 4800)
            {
                receive3.gameObject.SetActive(true);
            }

            if (I == 5200)
            {
                receive4.gameObject.SetActive(true);
            }

            if (I == 5400)
            {
                receive5.gameObject.SetActive(true);
            }

            if (I == 5600)
            {
                receive6.gameObject.SetActive(true);
            }

            if (I == 5800)
            {
                receive7.gameObject.SetActive(true);
            }

            else
            {
                Debug.Log("分数不匹配");
            }
        }
    }
}