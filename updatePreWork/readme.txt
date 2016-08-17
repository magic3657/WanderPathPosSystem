20160722更新說明: (此更新檔版本為 Ver3.0)

1.DB加入一個欄位customer_amt紀錄消費者當下拿出的金額多少,以利追蹤
2.於查詢帳款功能中新增(實付金額)欄位呈現


更新程式流程(提醒攻城師):
1. 務必先備份使用者電腦中原先的db file & exe 至 backup
2. 執行alter_charge_customer_amt.txt (語法請分段做,因為sqliteStudio怪怪der)

特別說明怎麼還原上一版(如果使用者遇到突發狀況需要自行還原上一版本的程式時請務必看這點):

1. 此更新檔案中有一個資料夾名為 (backup),用途為備份程式更新前客戶PC的程式執行檔及db file
   以利特殊情況可即時進行還原作業, 當你遇到突發狀況看到這個文件時, backup資料夾內的程式就是上一版(Ver2.0)的程式,
   還原的方式請看下一步

2. 由於此次有更新資料庫,於charge資料表有新增欄位customer_amt(實收金額), 故若是需要還原, 切記必須備份當下的db file,
   db file指的是 C:\sqlite3\myposdb.sl3 檔案
 
   備份方式: (務必先做第1點和第2點)
   1. 將當下 C:\sqlite3\myposdb.sl3 檔案重新命名為 myposdb_當天日期  ex: myposdb_20160722.sl3 (.sl3是附檔名,需保留)
   2. 將桌面上的WanderPath.exe重新命名,重新命名方式同db file的模式 ex: WanderPath_20160722.exe (.exe是附檔名,需保留)
   3. 最後再將資料夾(20160722_Modify)中backup資料夾裡面的myposdb.sl3 複製到 C:\sqlite3\myposdb.sl3 
      將執行程式(WanderPath.exe)複製到桌面