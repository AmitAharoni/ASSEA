using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ASSEA_Logic
{
     class User
     {
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
     }
}
