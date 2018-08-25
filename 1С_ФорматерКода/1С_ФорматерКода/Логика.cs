using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _1С_ФорматерКода
{
    public partial class Form1
    {
        string Форматировать(string Code)
        {
            Code = УдалитьФорматирование(Code);
            Code = ДобавитьПереносыСтрок(Code);
            Code = УбратьЛишниеПробелыВНачалеИКонцеСтрок(Code);
            Code = ДобавитьОтступы(Code);

            return Code;
        }

        string ЗавернутьКомментарии(string Value)
        {
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну("//.*?(\r|\n)", "/*", Value, "*/");//Регулярное выражение
            Value = Value.Replace("//", "");

            return Value;
        }
        string РазвернутьКомментарии(string Value)
        {
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"\*/", "", Value, "\r\n");//Регулярное выражение
            Value = Value.Replace("*/", "");
            Value = Value.Replace("/*", "//");

            return Value;
        }
        string УдалитьФорматирование(string Value)
        {
            //Добавить лишние пробелы вначале строк
            //Value = Value.Replace("\r", "\r ");
            //Value = Value.Replace("\n", "\n ");

            Value = ЗавернутьКомментарии(Value);

            //удалить перенос строк
            Value = Value.Replace("\r", "");
            Value = Value.Replace("\n", "");

            //Заменить знаки табуляции на пробелы
            Value = Value.Replace("\t", " ");

            //Заменить лишние (двойные) пробелы на одинарные
            while (Value.Contains("  "))
            {
                Value = Value.Replace("  ", " ");
            }

            return Value;
        }

        string ДобавитьПереносыСтрок(string Value)
        {
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Процедура\s.*?\(.*?\)", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"КонецПроцедуры", "", Value, "\r\n\r\n");//Регулярное выражение

            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Функция\s.*?\(.*?\)", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"КонецФункции", "", Value, "\r\n\r\n");//Регулярное выражение

            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Для\sСчетчик\s.*?\sЦикл", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Для\sКаждого\s.*?\sЦикл", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Пока\s.*?\sЦикл", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"КонецЦикла;", "", Value, "\r\n");//Регулярное выражение


            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"(\s|\r|\n|\t)Если\s.*?\sТогда", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"ИначеЕсли\s.*?\sТогда", "", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Иначе\s", "", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"КонецЕсли;", "", Value, "\r\n");//Регулярное выражение

            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Попытка", "\r\n", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"Исключение", "", Value, "\r\n");//Регулярное выражение
            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@"КонецПопытки;", "", Value, "\r\n");//Регулярное выражение

            Value = ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(@";", "", Value, "\r\n");//Регулярное выражение

            Value = РазвернутьКомментарии(Value);

            return Value;
        }
        string ДобавитьТекстВНачалоИКонецСтрокиПоПаттерну(string pattern, string InsertBefore, string Value, string InsertAfter)
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            int Position = 0;

            while (true)
            {
                Match match = regex.Match(Value, Position);
                if (!match.Success)
                    break;

                Value = Value.Insert(match.Index + match.Length, InsertAfter);
                Value = Value.Insert(match.Index, InsertBefore);

                Position = match.Index + match.Length + InsertBefore.Length + InsertAfter.Length;
            }

            return Value;
        }

        string УбратьЛишниеПробелыВНачалеИКонцеСтрок(string Value)
        {
            Value = Value.Replace("\r\n ", "\r\n");
            Value = Value.Replace(" \r\n", "\r\n");

            return Value;
        }

        string ДобавитьОтступы(string Value)
        {
            string[] list = РазбитьСтрокуНаПодСтроки(Value);

            int TabLevel = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (СтрокаНачинаетсяС(list[i], "Попытка") ||
                    СтрокаНачинаетсяС(list[i], "Пока") ||
                    СтрокаНачинаетсяС(list[i], "Для Счетчик") ||
                    СтрокаНачинаетсяС(list[i], "Для Каждого") ||
                    СтрокаНачинаетсяС(list[i], "Процедура") ||
                    СтрокаНачинаетсяС(list[i], "Функция") ||
                    СтрокаНачинаетсяС(list[i], "Если"))
                {
                    list[i] = ДобавитьОтступ(list[i], TabLevel);
                    TabLevel++;
                }
                else if (СтрокаНачинаетсяС(list[i], "Исключение") ||
                    СтрокаНачинаетсяС(list[i], "Иначе"))
                {
                    TabLevel--;
                    list[i] = ДобавитьОтступ(list[i], TabLevel);
                    TabLevel++;
                }
                else if (СтрокаНачинаетсяС(list[i], "Конец"))
                {
                    TabLevel--;
                    list[i] = ДобавитьОтступ(list[i], TabLevel);
                }
                else
                    list[i] = ДобавитьОтступ(list[i], TabLevel);
            }

            Value = СобратьПодСтрокиВСтроку(list);
            return Value;
        }
        string[] РазбитьСтрокуНаПодСтроки(string Value)
        {
            return Value.Split('\n');
        }
        string СобратьПодСтрокиВСтроку(string[] list)
        {
            string result = "";

            foreach (string line in list)
                result += line + "\n";

            return result;
        }
        string ДобавитьОтступ(string Value, int TabLevel)
        {
            for (int i = 0; i < TabLevel; i++)
                Value = Value.Insert(0, "\t");

            return Value;
        }
        bool СтрокаНачинаетсяС(string Value, string StartWith)
        {
            return Value.StartsWith(StartWith, StringComparison.OrdinalIgnoreCase);
        }
    }
}
