using System;
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

        public void Receive()
        {
            if (receive00.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
                return;
            }

            if (receive111.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive222.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive333.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive444.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive555.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive666.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
            }

            if (receive777.gameObject.activeSelf == false)
            {
                Z = Convert.ToInt32(Sum.text);
                Z++;
                Sum.text = Z.ToString();
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