/* 날짜 및 시간 서식화 */
using System.Globalization;

DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt); // 12시간 형식: 2023-03-04 오후 11:18:22 (토)
Console.WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt); // 24시간 형식: 2023-03-04 23:18:22 (토요일)

CultureInfo ciKo = new CultureInfo("ko-KR");
Console.WriteLine();
Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo)); // 2023-03-04 오후 11:18:22 (토)
Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo)); // 2023-03-04 23:18:22 (토요일)
Console.WriteLine(dt.ToString(ciKo)); // 2023-03-04 오후 11:18:22
