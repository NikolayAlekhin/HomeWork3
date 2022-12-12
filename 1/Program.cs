/*   Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите  число");
string namberOnerStr = Console.ReadLine() ??"";

if (namberOnerStr[0] == namberOnerStr[4]&& (namberOnerStr[1] == namberOnerStr[3]))
{
 Console.WriteLine( $"{namberOnerStr} = да");
}
else
{
     Console.WriteLine( $"{namberOnerStr} = нет");
}