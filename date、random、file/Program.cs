using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;


namespace date_random_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            //Console.Write($"請輸入姓名:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi~{name}");
            //Console.ReadKey();

            //2.判斷是否出現在人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。.Contains
            //Console.Write($"請輸入任一字:");
            //string inputword = Console.ReadLine();
            //string str = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //Console.WriteLine(str.Contains(inputword));
            //Console.ReadKey();

            //3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。string.Join
            //Console.Write($"請輸入一段字:");
            //string inputword = Console.ReadLine();
            //char[] chars = inputword.ToCharArray();
            //Console.WriteLine(string.Join("-", chars));
            //Console.ReadKey();

            //4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。.Substring
            //Console.Write($"請輸入一個檔名:");
            //string inputword = Console.ReadLine();
            //string newStr = inputword.Substring(inputword.IndexOf(".") + 1);

            //Console.WriteLine($"副檔名:{newStr}");
            //Console.ReadKey();

            //5.一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。.Length .Substring()
            //Console.Write($"請輸入單字:");
            //string inputword = Console.ReadLine();
            //if (inputword.Length < 5)
            //{
            //    Console.WriteLine($"長度不夠");
            //}
            //else 
            //{
            //    string newStr = inputword.Substring(0,3);
            //    Console.WriteLine($"前三個字為:{newStr}");
            //}
            //Console.ReadKey();

            //6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
            //Console.Write($"請輸入一段字:");
            //string inputword = Console.ReadLine();
            //Console.WriteLine(inputword.Replace("我","小明"));
            //Console.ReadKey();

            //7.輸入一串字，顯示輸入幾個字。Length
            //Console.Write($"請輸入一段字:");
            //string inputword = Console.ReadLine();
            //Console.WriteLine("總共輸入"+inputword.Length+"個字");
            //Console.ReadKey();

            //補充 1.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
            //Console.WriteLine($"請輸入10組字");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"第{i + 1}組字為:");
            //    string inputword = Console.ReadLine();

            //    if (inputword.Contains(inputword))
            //    {
            //        Console.WriteLine($"已經輸入過");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"沒輸入過");
            //    }
            //}
            //Console.ReadKey();

            //補充 2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出Fifa、fIfa、fiFa、fifA
            //Console.Write($"請輸入一段字:");
            //string inputword = Console.ReadLine();
            //char[] chars = inputword.ToCharArray();

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    chars[i] = char.ToUpper(chars[i]);
            //    string word = new string(chars);
            //    Console.Write(word + "、");

            //    chars[i] = char.ToLower(chars[i]);
            //}

            //Console.ReadKey();

            //補充 3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
            //Console.Write($"請輸入時間:");
            //string inputword = Console.ReadLine();
            //string str = inputword.Replace(":", "點");
            //Console.WriteLine(str+"分");
            //Console.ReadKey();

            //補充 4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出<ul><li>
            //Console.Write($"請輸入一段字:");
            //string input = Console.ReadLine();
            //string[] names = input.Split(',');
            //string html = "<ul>";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    html += $"\n\t<li>{names[i].Trim()}</li>";
            //}
            //html += "\n</ul>";
            //Console.WriteLine(html);
            //Console.ReadKey();

            //補充 5.5處數字，用空白隔開並輸出總和
            //Console.WriteLine($"請輸入五個數字:");
            //string input = Console.ReadLine();
            //string[] names = input.Split(' ');

            //Console.ReadKey();

            //補充 6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ。.Reverse().ToArray()
            //Console.Write($"請輸入一段字:");
            //string inputword = Console.ReadLine();
            //string strReverse = new string(inputword.Reverse().ToArray());

            //Console.WriteLine($"反著的輸出為:{strReverse}");
            //Console.ReadKey();


            //中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)
            //string path = @"c:\temp\1.txt";
            //string createText = "可能忙了又忙 可能傷了又傷 可能無數眼淚 在夜晚嚐了又嚐 可是換來成長 可是換來希望 如今我站在台上";
            //File.WriteAllText(path, createText);
            //Console.WriteLine("已寫入");
            //Console.ReadKey();

            //讀取1.txt 顯示在畫面
            //string path = @"c:\temp\1.txt";
            //Console.WriteLine("十年一刻歌詞:");
            //string input = File.ReadAllText(path);
            //Console.WriteLine(input);
            //Console.ReadKey();

            //九九乘法表資料
            //string path = @"c:\temp\99.txt";
            //string[] createLines = new string[9];
            //for (int i = 1; i <= 9; i++)
            //{
            //    string line = "";

            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int result = i * j;
            //        line += $"{i} * {j} = {result}\t";
            //    }

            //    createLines[i - 1] = line;
            //}
            //File.WriteAllLines(path, createLines);
            //Console.WriteLine("已寫入九九乘法表");
            //Console.ReadKey();

            //九九乘法表資料阿拉伯數字，轉換成中文數字
            //string path = @"c:\temp\99.txt";
            //string[] createLines = new string[9];

            ////讀取已存在的文字檔
            //string[] lines = File.ReadAllLines(path);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    createLines[i] = lines[i]
            //        .Replace("0", "零")
            //        .Replace("1", "壹")
            //        .Replace("2", "貳")
            //        .Replace("3", "參")
            //        .Replace("4", "肆")
            //        .Replace("5", "伍")
            //        .Replace("6", "陸")
            //        .Replace("7", "柒")
            //        .Replace("8", "捌")
            //        .Replace("9", "玖");
            //}
            //// 將轉換後的內容寫回檔案
            //File.WriteAllLines(path, createLines);
            //string input = File.ReadAllText(path);
            //Console.WriteLine(input);
            //Console.ReadKey();

            //讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            //string csvPath = @"c:\temp\fc4bb.csv";
            //string htmlPath = @"c:\temp\table.html";
            //// 讀取CSV檔案
            //string[] lines = File.ReadAllLines(csvPath);
            //// 建立HTML表格
            //StringBuilder htmlTable = new StringBuilder();
            //htmlTable.Append("<html><head><title>TABLE</title></head><body><table border='1'>");
            //foreach (string line in lines)
            //{
            //    htmlTable.Append("<tr>");
            //    string[] columns = line.Split(',');

            //    foreach (string column in columns)
            //    {
            //        htmlTable.Append("<td>");
            //        htmlTable.Append(column);
            //        htmlTable.Append("</td>");
            //    }

            //    htmlTable.Append("</tr>");
            //}
            //htmlTable.Append("</table></body></html>");
            //// 將HTML表格儲存到檔案
            //File.WriteAllText(htmlPath, htmlTable.ToString(), Encoding.UTF8);
            //Console.WriteLine("已成功建立HTML檔案，位於：" + htmlPath);
            //Console.ReadKey();

            //亂數Random() .Next(範圍, 範圍)

            //0~99亂數生成1個數字
            //Random rom = new Random();
            //int I = rom.Next(0, 100);
            //Console.WriteLine($"亂數為{I}");
            //Console.ReadKey();

            //0~99亂數生成10個數字
            //Random rom = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int I = rom.Next(0, 100);
            //    Console.WriteLine($"亂數為{I}");

            //}
            //Console.ReadKey();

            //學員產生成績，並寫入文字檔
            //string path = @"c:\temp\grades.txt";
            //string[] createLines = { "阿美", "阿土", "阿明", "小美", "星星", "小小" };
            //File.WriteAllLines(path, createLines);

            //Random random = new Random();
            //string[] lines = new string[createLines.Length];
            //for (int i = 0; i < createLines.Length; i++)
            //{
            //    int score = random.Next(0, 101);
            //    lines[i] = $"{createLines[i]},{score}";
            //}
            //File.WriteAllLines(path, lines);
            //Console.WriteLine($"已成功建立檔案");
            //Console.ReadKey();


            //樂透開獎程式
            //int[] randomBall = new int[6];
            //Random rom = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    randomBall[i] = rom.Next(1, 50);

            //    for (int j = 0; j < i; j++)
            //    {
            //        while (randomBall[j] == randomBall[i])
            //        {
            //            j = 0;
            //            //重新產生，存回陣列，亂數產生的範圍是1~49
            //            randomBall[i] = rom.Next(1, 50);
            //        }
            //    }
            //    Console.WriteLine($"樂透號碼:{randomBall[i]}");
            //}
            //Console.ReadKey();

            //午餐的店家，讀取文字檔，隨機抽出
            //string path = @"c:\temp\shop.txt";
            //string[] createLines = { "美味坊", "創意烘焙工房", "好味屋", "美食探險家", "五星餐飲天地", "和風小館" };
            //File.WriteAllLines(path, createLines);
            //string[] lines = File.ReadAllLines(path);
            //Random random = new Random();
            //int randomIndex = random.Next(0, lines.Length);
            //string lunch = lines[randomIndex];
            //Console.WriteLine($"今天的午餐選擇是:{lunch}");
            //Console.ReadKey();

            //抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            //string path = @"c:\temp\today.txt";
            //string[] students = {"阿美","小明","旺旺","波利","發財","恭喜"};
            //File.WriteAllLines(path, students);

            //Random random = new Random();
            //int randomIndex = random.Next(0, students.Length);
            //string dutyStudent = students[randomIndex];
            //Console.WriteLine($"今天的值日生是：{dutyStudent}");
            //Console.ReadKey();

            //日期
            //現在日期與時間DateTime.Now
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"現在時間{now}");
            //Console.ReadKey();

            //再過30天為哪一天
            //DateTime noww = DateTime.Now;
            //DateTime future = noww.AddMonths(1);
            //Console.WriteLine($"1個月後為{future}");
            //Console.ReadKey();

            //24小時前的年月日時分秒
            //DateTime noww = DateTime.Now;
            //DateTime pastDay = noww.AddDay(-1);
            //Console.WriteLine($"1個月後為{pastDay}");
            //Console.ReadKey();

            //目前是幾月
            //DateTime noww = DateTime.Now;
            //int month = noww.Month;
            //Console.WriteLine($"目前是{month}月");
            //Console.ReadKey();

            //明年是否為閏年
            //DateTime noww = DateTime.Now;
            //DateTime future = noww.AddYears(1);
            //int year = future.Year;
            //if (DateTime.IsLeapYear(year))
            //{
            //    Console.WriteLine("{0}是閏年", year);
            //}

            //else
            //{
            //    Console.WriteLine("{0}不是閏年", year);
            //}
            //Console.ReadKey();

            //離2025年1月1日還有幾天
            //DateTime today = DateTime.Today;
            //DateTime future = today.AddYears(1);
            //DateTime happyday = new DateTime(future.Year, 2, 9);

            //int newyear = (int)(happyday - today).TotalDays;
            //Console.WriteLine($"今天是{today:yyyy年MM月dd日}，距離2025年1月1日還有{newyear}天");
            //Console.ReadKey();

            //日期補充
            //DateTime week = DateTime.Today;
            //DayOfWeek todayweek = week.DayOfWeek;
            //switch (todayweek)
            //{
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine($"星期日，猴子過生日");
            //        break;

            //    case DayOfWeek.Monday:
            //        Console.WriteLine($"星期一，猴子穿新衣");
            //        break;

            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine($"星期二，猴子肚子餓");
            //        break;

            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine($"星期三，猴子去爬山");
            //        break;

            //    case DayOfWeek.Thursday:
            //        Console.WriteLine($"星期四，猴子看電視");
            //        break;

            //    case DayOfWeek.Friday:
            //        Console.WriteLine($"星期五，猴子去跳舞");
            //        break;

            //    case DayOfWeek.Saturday:
            //        Console.WriteLine($"星期六，猴子去斗六");
            //        break;

            //    default:
            //        break;
            //}            
            //Console.ReadKey();

            //輸入兩個日期，輸出兩個日期相差幾天
            //Console.Write("請輸入第一個日期 (yyyy-MM-dd): ");
            //string input1 = Console.ReadLine();
            //DateTime parsedDate = DateTime.Parse(input1);

            //Console.Write("請輸入第二個日期 (yyyy-MM-dd): ");
            //string input2 = Console.ReadLine();
            //DateTime parsedDate2 = DateTime.Parse(input2);

            //Console.WriteLine($"兩個日期相差{(parsedDate2 - parsedDate).Days}天");
            //Console.ReadKey();

            //占卜
            //Random num = new Random();

            //DateTime nowday = DateTime.Now; //當前日期

            //int lucky = num.Next(366); //365天

            //DateTime luckyday = nowday.AddDays(lucky); //取得亂數日期
            //int month = luckyday.Month;
            //int day = luckyday.Day;
            //int s = (month * 2 + day) % 3;
            //switch (s)
            //{
            //    case 0:
            //        Console.WriteLine($"運勢為普通");
            //        break;

            //    case 1:
            //        Console.WriteLine($"運勢為吉");
            //        break;

            //    case 2:
            //        Console.WriteLine($"運勢為大吉");
            //        break;

            //    default:
            //        break;
            //}
            //Console.ReadKey();

            //文字轉成HTML
            //Console.Write("請輸入文字：");
            //string input = Console.ReadLine();
            //Console.WriteLine(ToHtml(input));
            //Console.Read();

            //輸入的值是否數字
            //Console.Write("請隨便輸入：");
            //string userInput = Console.ReadLine(); // 輸入您想要檢查的字串
            //bool isNumeric = IsNume(userInput);

            //if (isNumeric)
            //{
            //    Console.WriteLine($"{userInput}是一個數字。");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput}不是一個數字。");
            //}
            //Console.ReadKey();

            //判斷Email
            //Console.Write("請輸入Email：");
            //string email = Console.ReadLine();
            //Console.WriteLine(EmailCheck(email));
            //Console.Read();

            //判斷手機格式
            //Console.Write("請輸入手機：");
            //string phone = Console.ReadLine();
            //Console.WriteLine(PhoneCheck(phone));
            //Console.Read();

            //判斷身分證字號格式
            //Console.Write("請輸入身分證：");
            //string id = Console.ReadLine();
            //Console.WriteLine(IsIdCheck(id));
            //Console.Read();


            //輸入的文字大於Ｎ個，則超過的字不要，變成點點點


            //輸入一個日期，把該日期轉成民國年.月.日格式
            //Console.Write("請輸入西元日期(yyyy-MM-dd)：");
            //string inputDate = Console.ReadLine();
            //// 轉換日期格式
            //string formattedDate = Calendar(inputDate);
            //Console.WriteLine($"轉換後的民國日期：{formattedDate}");
            //Console.ReadKey();

            //輸入一個日期，把該日期轉成民國年.月.日.星期X
            //Console.Write("請輸入西元日期(yyyy-MM-dd)：");
            //string inputDate = Console.ReadLine();
            //// 轉換日期格式
            //string formattedDate = WeekCalendar(inputDate);
            //Console.WriteLine($"轉換後的民國日期：{formattedDate}");
            //Console.ReadKey();

            //寫一個function，回傳輸入的年是否閏年
            //Console.Write("請輸入年份：");
            //int inputYear = Convert.ToInt32(Console.ReadLine());
            //bool isLeapYear = LeapYear(inputYear);

            //if (isLeapYear)
            //{
            //    Console.WriteLine($"{inputYear} 年是閏年。");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputYear} 年不是閏年。");
            //}
            //Console.ReadKey();

            //寫一個function，輸入手機號碼，回傳今天運勢
            //Console.Write("請輸入手機號碼：");
            //string phone = Console.ReadLine();
            //Console.WriteLine(PhoneLucky(phone));
            //Console.ReadKey();
        }

        public static string IsIdCheck(string id)  // 撰寫方法
        {
            string pattern = @"^[A-Za-z]\d{9}$";
            Regex idcheck = new Regex(pattern);
            if (idcheck.IsMatch(id))
            {
                return "有效的身分證";
            }
            else
            {
                return "可能有地方輸入錯誤的身分證號";
            }
        }
        public static string EmailCheck(string email)  // 撰寫方法
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex emailcheck = new Regex(pattern);
            if (emailcheck.IsMatch(email))
            {
                return "有效的email";
            }
            else
            {
                return "可能有地方輸入錯誤的email格式";
            }
        }
        public static string PhoneCheck(string phone)  // 撰寫方法
        {
            string pattern = @"^09\d{8}$";
            Regex phoneCheck = new Regex(pattern);
            if (phoneCheck.IsMatch(phone))
            {
                return "有效的手機號碼";
            }
            else
            {
                return "可能有地方輸入錯誤的手機號碼格式";
            }
        }
        public static string ToHtml(string input)
        {
            input = input.Replace(">", "&gt;");
            input = input.Replace("<", "&lt;");
            input = input.Replace("\r", "<br>");
            input = input.Replace("\n", "<br>");
            input = input.Replace("|", "&brvbar;");
            input = input.Replace(" ", "&nbsp;");

            return input;
        }
        public static bool IsNume(string input)
        {

            return double.TryParse(input, out _);
        }
        public static string Calendar(string inputDate)
        {
            //DateTime.Parse將字串轉換為 DateTime 物件
            DateTime date = DateTime.Parse(inputDate);
            int rocYear = date.Year - 1911;

            string formattedDate = $"{rocYear}年{date.Month}月{date.Day}日";

            return formattedDate;
        }
        public static string WeekCalendar(string inputDate)
        {
            //DateTime.Parse將字串轉換為 DateTime 物件
            DateTime date = DateTime.Parse(inputDate);

            string formattedDate = $"{ date.Year - 1911}年{date.Month}月{date.Day}日{date.DayOfWeek}";

            return formattedDate;
        }
        public static bool LeapYear(int inputYear)
        {
            return (inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0);
        }
        public static string PhoneLucky(string phone)  // 撰寫方法
        {
            string phoneNum = phone.Substring(6, 4);
            int phoneNumInt = int.Parse(phoneNum);
            double lucky = (phoneNumInt % 80);
            return $"今天的運勢數字是：{lucky}";
        }
    }
    
}
