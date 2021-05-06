using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ASSEA_Logic
{
     class User
     {
          public const int phy = 1;
          public const int ment = 2;
          /// <summary>
          /// save to file
          /// </summary>
          string userName;
          DateTime mealFirst, mealSec, friendlyBreak;
          eInterset interset;
          eNotificationsLevel notificationsLevel;

          /// <summary>
          /// daily
          /// </summary>
          int physicalScale = 50, mentalScale = 50; //need to be between 0 - 100
          int notificationAnsweredByUser = 0;

          List<string> physicalMsg = new List<string>{"Snack time", "Drink Somthing", "Coffee Time",};
          List<string> mentalMsg = new List<string> { "Fix your posture", "Do some streches", "Wash your face"};
          
          public enum eInterset
          {
               Sport = 0,
               Music = 1,
               News = 2
          }
          
          public enum eNotificationsLevel
          {
               soft = 0,
               normal = 1,
               extreme = 2
          }

          public int selectListMSG()
          {
               if(this.physicalScale < this.mentalScale)
               {
                    return phy;
               }

               return ment;
          }

          public void pickMessage(int listIndecator)
          {
               Random rd = new Random();
               int maxlength = 0;
               string message;
               if(listIndecator == phy)
               {
                    maxlength = physicalMsg.Capacity - 1;
               }
               else
               {
                    maxlength = mentalMsg.Capacity - 1;
               }

               int rand_num = rd.Next(0, maxlength);

               if(listIndecator == phy)
               {
                    message = physicalMsg[rand_num];
               }
               else
               {
                    message = mentalMsg[rand_num];
               }

               //send notification
          }

          public void pickMessage(int listIndecator)
          {
          }
}
