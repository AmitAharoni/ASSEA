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

          List<string> physicalMsgs = new List<string> { "Snack time", "Drink Somthing", "Coffee Time", };
          List<string> mentalMsgs = new List<string> { "Fix your posture", "Do some streches", "Wash your face" };


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

          public enum eQuery
          {
               phy = 0,
               mental = 1,
               breakOrWork = 2
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
               eQuery msgType;
               int maxlength = 0;
               string message;
               maxlength = listIndecator == phy ? (physicalMsgs.Capacity - 1) : (mentalMsgs.Capacity - 1);

               int rand_num = rd.Next(0, maxlength);

               if(listIndecator == phy)
               {
                    message = physicalMsgs[rand_num];
                    msgType = eQuery.phy;
               }
               else
               {
                    message = mentalMsgs[rand_num];
                    msgType = eQuery.mental;

               }

               doWhenMSGready(message, msgType);
          }

          private event Action<string, eQuery> msgNotifier;

          private void doWhenMSGready(string msgToPass, eQuery msgType)
          {
               msgNotifier.Invoke(msgToPass, msgType);
          }

          public void afterMsgAction(eQuery msgType, bool answer)
          {
               if(msgType == eQuery.mental)
               {
                    mentalScale = (answer == true) ? mentalScale += 20 : mentalScale -= 20; 
               }
               else if(msgType == eQuery.phy)
               {
                    physicalScale = (answer == true) ? physicalScale += 20 : physicalScale -= 20;

               }
               else
               {
                    mentalScale = (answer == true) ? mentalScale += 20 : mentalScale -= 20;
                    physicalScale = (answer == true) ? physicalScale += 20 : physicalScale -= 20;
               }
          }

     }
}
