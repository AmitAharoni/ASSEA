using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Timers;

namespace ASSEA_Logic
{
     public class AppSetting
     {
          // file folder and details
          private static readonly string sr_FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ASSEA";
          private static readonly string sr_File = sr_FileLocation + "\\AppSettings.txt";
          private static System.Timers.Timer mainTimer;
          private static System.Timers.Timer decreaseTimer;

          public const int phy = 1;
          public const int ment = 2;

          /// <summary>
          /// daily
          /// </summary>
          int physicalScale = 50, mentalScale = 50; //need to be between 0 - 100
          int notificationAnsweredByUser = 0;

          List<string> physicalMsgs = new List<string> { "Snack time", "Drink Somthing", "Coffee Time", };
          List<string> mentalMsgs = new List<string> { "Fix your posture", "Do some streches", "Wash your face" };
               
          string userName;
          string mealLunch;
          string mealDinner;
          string friendlyBreak;
          eInterset Interest;
          eNotificationsLevel notificationsLevel;

          private AppSetting() { }

          public AppSetting(string username, DateTime lunch, DateTime dinner, DateTime friendly, eInterset interest, eNotificationsLevel notification)
          {
               CheckFolder();
               userName = username;
               mealLunch = lunch.ToLongTimeString();
               mealDinner = dinner.ToLongTimeString();
               friendlyBreak = friendly.ToLongTimeString();
               Interest = interest;
               notificationsLevel = notification;

               Thread idleThread = new Thread(userIdle);
               idleThread.Start();
               Thread decreaseScalesThread = new Thread(decreaseScales);
               decreaseScalesThread.Start();
               SetTimer();
          }

          public enum eInterset
          {
               Sport = 0,
               Music = 1,
               News = 2,
               All = 3

          }

          public enum eNotificationsLevel
          {
               soft = 0,
               normal = 1,
               extreme = 2
          }

          public void exitApplication()
          {
               mainTimer.Stop();
               mainTimer.Dispose();
               System.Environment.Exit(-1);
          }

          public void SetTimer()
          {
               int level;
               if (this.notificationsLevel == eNotificationsLevel.soft)
               {
                    level = 6000; //600000
               }
               else if (this.notificationsLevel == eNotificationsLevel.normal)
               {
                    level = 4000; //400000
               }
               else
               {
                    level = 2000; //200000
               }

               mainTimer = new System.Timers.Timer(level);
               mainTimer.Elapsed += OnTimedEvent;
               mainTimer.AutoReset = true;
               mainTimer.Enabled = true;

               while (true)
               {
               }
          }

          private void OnTimedEvent(Object source, ElapsedEventArgs e)
          {
               int list = selectListMSG();
               pickMessage(list);
          }

          public static class InputTimer
          {
               public static TimeSpan GetInputIdleTime()
               {
                    var plii = new NativeMethods.LastInputInfo();
                    plii.cbSize = (UInt32)Marshal.SizeOf(plii);

                    if(NativeMethods.GetLastInputInfo(ref plii))
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
               while(true)
               {
                    TimeSpan idleTime = InputTimer.GetInputIdleTime();
                    if(idleTime.TotalMinutes >= 10)
                    {
                         //send Message and ask if user went to break
                         while(InputTimer.GetInputIdleTime().Minutes > 1)
                         {
                              Thread.Sleep(30000);
                              continue;
                         }

                         string askIfUserWentToBreak = "Hello, you were idle, did you were on a break?";
                         doWhenMSGready(askIfUserWentToBreak, eQuery.idle);
                    }
               }
          }

          public void decreaseScales()
          {
               while (true)
               {

               }
          }
          public void changeMentalScale(int change)
          {
               lock (this)
               {
                    mentalScale += change;

                    if (mentalScale > 100)
                         mentalScale = 100;
                    if (mentalScale < 0)
                         mentalScale = 0;
               }

          }

          public void changePhysicalScale(int change)
          {
               lock (this)
               {
                    physicalScale += change;

                    if (physicalScale > 100)
                         physicalScale = 100;
                    if (physicalScale < 0)
                         physicalScale = 0;
               }

          }

          public enum eQuery
          {
               phy = 0,
               mental = 1,
               idle = 2
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

               if (listIndecator == phy)
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


          public void receiveAnswer(eQuery msgType, bool userAnswerToMSG)
          {
               int change;
               if (msgType == eQuery.mental)
               {
                    change = (userAnswerToMSG == true) ? 10 : -10;
                    changeMentalScale(change);
               }
               else if (msgType == eQuery.phy)
               {
                    change = (userAnswerToMSG == true) ? 10 : -10;
                    changePhysicalScale(change);
               }
               else
               {
                    change = (userAnswerToMSG == true) ? 10 : -10;
                    changeMentalScale(change);
                    change = (userAnswerToMSG == true) ? 10 : -10;
                    changePhysicalScale(change);
               }

               if (userAnswerToMSG == true)
               {

                    mainTimer.Stop();
               }
          }

          public void returnFromBreak()
          {
               mainTimer.Start();
          }

          public static bool UserExist()
          {
               return File.Exists(sr_File);
          }

          public static AppSetting LoadFromFile()
          {
               AppSetting userSetting = null;

               if(File.Exists(sr_File))
               {
                    using(Stream stream = new FileStream(sr_File, FileMode.Open))
                    {
                         XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                         userSetting = serializer.Deserialize(stream) as AppSetting;
                    }
               }

               return userSetting;
          }

          public void SaveToFile()
          {
               if(!File.Exists(sr_File))
               {
                    Stream stream = new FileStream(sr_File, FileMode.Create);
                    stream.Dispose();
               }

               using(Stream stream = new FileStream(sr_File, FileMode.Truncate))
               {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
               }
          }

          public void CheckFolder()
          {
               if (!Directory.Exists(sr_FileLocation))
               {
                    Directory.CreateDirectory(sr_FileLocation);
               }
          }
     }
}
