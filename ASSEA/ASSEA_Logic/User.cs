using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;

namespace ASSEA_Logic
{
     class User
     {
          public const int phy = 1;
          public const int ment = 2;
          
        public User(string username, DateTime lunch, DateTime dinner, DateTime friendly, eInterset interest, eNotificationsLevel notification)
        {
            string userName = username;
            string mealFirst = lunch.ToLongTimeString();
            string mealSec = dinner.ToLongTimeString();
            string friendlyBreak = friendly.ToLongTimeString();
            eInterset interset = interest;
            eNotificationsLevel notificationsLevel = notification;

            Thread thread = new Thread(userIdle);
            thread.Start();
        }

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
          
        public static class InputTimer
        {
            public static TimeSpan GetInputIdleTime()
            {
                var plii = new NativeMethods.LastInputInfo();
                plii.cbSize = (UInt32)Marshal.SizeOf(plii);

                if (NativeMethods.GetLastInputInfo(ref plii))
                {
                    return TimeSpan.FromMilliseconds(Environment.TickCount - plii.dwTime);
                }
                else
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
            }

            public static DateTimeOffset GetLastInputTime()
            {
                return DateTimeOffset.Now.Subtract(GetInputIdleTime());
            }

            private static class NativeMethods
            {
                public struct LastInputInfo
                {
                    public UInt32 cbSize;
                    public UInt32 dwTime;
                }

                [DllImport("user32.dll")]
                public static extern bool GetLastInputInfo(ref LastInputInfo plii);
            }
        }

  public void userIdle()
        {
            while (true)
            {
                TimeSpan idleTime = InputTimer.GetInputIdleTime();
                if (idleTime.TotalMinutes >= 10)
                {
                    //send Message and ask if user went to break
                    while (InputTimer.GetInputIdleTime().Minutes > 1)
                    {
                        Thread.Sleep(30000);
                        continue;
                    }

                    string askIfUserWentToBreak = "Hello, you were idle, did you were on a break?";

                    //doWhenMsgReady
                }
            }
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
