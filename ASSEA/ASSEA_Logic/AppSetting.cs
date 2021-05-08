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
          /// <summary>
          ///appSetting file path is: C:\Users\$UserName\AppData\Roaming\ASSEA
          /// </summary>
          private static readonly string sr_File = sr_FileLocation + "\\AppSettings.txt";
          private static System.Timers.Timer mainTimer;
          private static System.Timers.Timer decreaseTimer;
          private static System.Timers.Timer mealTimer;
          public const int phy = 1;
          public const int ment = 2;
          public int mentalAnswersYes = 2, mentalAnswerNo = 3, physicalAnswerYes = 4, physicalAnswerNo = 1;

          /// <summary>
          /// daily
          /// </summary>
          public int physicalScale { get; set; }
          public bool onBreak = false;
          public int mentalScale { get; set; } 
     
          List<string> physicalMsgs = new List<string> {"Snack time", "Drink Something", "Coffee Time"};
          List<string> mentalMsgs = new List<string> {"Close your eyes and breath", "Put your favorite music and relax", "Wash your face to feel better"};

          public string userName { get; set; }
          public DateTime mealLunch { get; set; }
          public DateTime mealDinner { get; set; }
          public DateTime friendlyBreak { get; set; }
          public eInterset Interest { get; set; }
          public eNotificationsLevel notificationsLevel { get; set; }

          private AppSetting() { }

          public AppSetting(string username, DateTime lunch, DateTime dinner, DateTime friendly, eInterset interest, eNotificationsLevel notification)
          {
               CheckFolder();
               userName = username;
               mealLunch = lunch;
               mealDinner = dinner;
               friendlyBreak = friendly;
               Interest = interest;
               notificationsLevel = notification;
               physicalScale = 50;
               mentalScale = 50;
               setThreads();
          }

          public void setThreads()
          {
               Thread idleThread = new Thread(userIdle);
               idleThread.Start();
               Thread decreaseScalesThread = new Thread(decreaseScales);
               decreaseScalesThread.Start();
               Thread timerThread = new Thread(SetTimer);
               timerThread.Start();
               Thread mealThread = new Thread(setTimerToMeal);
               mealThread.Start();
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

          public void endAndShow()
          {
               onBreak = true;
               mainTimer.Stop();
               decreaseTimer.Stop();
          }

          public void SetTimer()
          {
               int level;
               if (this.notificationsLevel == eNotificationsLevel.soft)
               {
                    level = 600000; //600000
               }
               else if (this.notificationsLevel == eNotificationsLevel.normal)
               {
                    level = 400000; //400000
               }
               else
               {
                    level = 10000; //200000
               }

               mainTimer = new System.Timers.Timer(level);
               mainTimer.Elapsed += OnTimedEvent;
               mainTimer.AutoReset = true;
               mainTimer.Enabled = true;

               while (true)
               {
                    Thread.Sleep(3000);
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

          public void setTimerToMeal()
          {
               DateTime time = DateTime.Now;
               TimeSpan span = mealLunch.Subtract(time);
               int timeDifference = (int)span.TotalMilliseconds;
               timeDifference = timeDifference > 0 ? timeDifference : 10000;

               mealTimer = new System.Timers.Timer(timeDifference);
               mealTimer.Elapsed += remindLunch;
               mealTimer.AutoReset = true;
               mealTimer.Enabled = true;

               Thread.Sleep(timeDifference+1000);
          }

          public void remindLunch(object source, ElapsedEventArgs e)
          {
               string message = "It's time to eat !";
               mainTimer.Stop();
               eQuery query = eQuery.lunchTime;

               doWhenMSGready(message, query);

          }

          public void userIdle()
          {
               while (true)
               {
                    TimeSpan idleTime = InputTimer.GetInputIdleTime();
                    if (idleTime.TotalSeconds >= 17) // 10
                    {
                         //send Message and ask if user went to break
                         while (InputTimer.GetInputIdleTime().TotalSeconds >= 17) // 1
                         {
                              Thread.Sleep(1000);
                         }

                         string askIfUserWentToBreak = "Hello, you were idle, did you were on a break?";
                         if (onBreak == false)
                         {
                              doWhenMSGready(askIfUserWentToBreak, eQuery.idle);
                         }
                    }
               }
          }

          public void decreaseScales()
          {
               decreaseTimer = new System.Timers.Timer(13000);
               decreaseTimer.Elapsed += decreaseEvent;
               decreaseTimer.AutoReset = true;
               decreaseTimer.Enabled = true;


               while (true)
               {
                    Thread.Sleep(10000);
               }
          }

          private void decreaseEvent(Object source, ElapsedEventArgs e)
          {
               changeMentalScale(-2);
               changePhysicalScale(-2);
               updateScales(physicalScale, mentalScale);
          }

          public event Action<int, int> updateScalesNotifier;

          private void updateScales(int physical, int mental)
          {
               if (updateScalesNotifier != null)
               {
                    updateScalesNotifier(physical, mental);
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
               idle = 2,
               lunchTime = 3
          }

          public int selectListMSG()
          {
               if (this.physicalScale < this.mentalScale)
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
               maxlength = listIndecator == phy ? (physicalMsgs.Count - 1) : (mentalMsgs.Count - 1);

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

          // public static event delegate startNotification;
          public event Action<string, eQuery> msgNotifier;

          private void doWhenMSGready(string msgToPass, eQuery msgType)
          {
               if (msgNotifier != null)
               {
                    msgNotifier(msgToPass, msgType);
               }
          }


          public void receiveAnswer(eQuery msgType, bool userAnswerToMSG)
          {
               int change = 10;

               if (userAnswerToMSG == true)
               {
                    if (msgType == eQuery.mental)
                    {
                         mentalAnswersYes++;
                         changeMentalScale(change);
                    }
                    else if (msgType == eQuery.phy)
                    {
                         physicalAnswerYes++;
                         changePhysicalScale(change);
                    }
                    else
                    {
                         if (msgType == eQuery.lunchTime)
                         {
                              change = 20;
                         }

                         changeMentalScale(change);
                         changePhysicalScale(change);
                    }

                    onBreak = true;
                    mainTimer.Stop();
                    decreaseTimer.Stop();
                    updateScales(physicalScale, mentalScale);
               }
               else
               {
                    if (msgType == eQuery.mental)
                    {
                         mentalAnswerNo++;
                    }
                    else if (msgType == eQuery.phy)
                    {
                         physicalAnswerNo++;
                    }
               }
          }

          public void returnFromBreak()
          {
               mainTimer.Start();
               decreaseTimer.Start();
               onBreak = false;
          }

          public static bool UserExist()
          {
               return File.Exists(sr_File);
          }

          public static AppSetting LoadFromFile()
          {
               AppSetting userSetting = null;

               if (File.Exists(sr_File))
               {
                    using (Stream stream = new FileStream(sr_File, FileMode.Open))
                    {
                         XmlSerializer serializer = new XmlSerializer(typeof(AppSetting));
                         userSetting = serializer.Deserialize(stream) as AppSetting;
                    }
               }

               return userSetting;
          }

          public void SaveToFile()
          {
               if (!File.Exists(sr_File))
               {
                    Stream stream = new FileStream(sr_File, FileMode.Create);
                    stream.Dispose();
               }

               using (Stream stream = new FileStream(sr_File, FileMode.Truncate))
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
