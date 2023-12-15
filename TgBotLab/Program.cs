using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TgBotLab
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var client = new TelegramBotClient("6713303669:AAHRt4oI0yL8bzbAOEIzA4zcKnoO6duJdNE");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message != null && message.Text.ToLower().Contains("/start"))
            {
                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Choose a response",
                    replyMarkup: replyKeyboardMarkup);
            }

            if (message != null)
            {
                if (message.Text.ToLower().Contains("specialties"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "(122) Компютерні науки, " +
                                                                          "(121)Інженерія програмного забезпечення, " +
                                                                          "(124) Системний аналіз," +
                                                                          "(125) Кібербезпека" +
                                                                          "(126) Інформаційні системи та технології");
                    return;
                }

                if (message.Text.ToLower().Contains("educational programs"))
                {
                    Message sentMessage = await botClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: "Choose a response",
                        replyMarkup: replyKeyboardMarkup2);
                    return;
                }

                if (message.Text.ToLower().Contains("(122) computer science"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Рік 1:\r\n\r\nВступ до програмування (введення в базові концепції програмування)\r\nВведення в математику (алгебра та тригонометрія)\r\nВведення в англійську мову та письмо\r\nВведення в інформатику (основи алгоритмів та структур даних)\r\nВступ до операційних систем (основні поняття про ОС)\r\nРік 2:\r\n\r\nПрограмування на високому рівні (Java, C++, або інші мови)\r\nОб'єктно-орієнтоване програмування\r\nВеб-розробка (HTML, CSS, JavaScript)\r\nМатематика для комп'ютерних наук (дискретна математика)\r\nБази даних (SQL та розробка баз даних)\r\nРік 3:\r\n\r\nАлгоритми та структури даних (розширені алгоритми)\r\nМережеві технології та протоколи\r\nПрограмування з використанням фреймворків (наприклад, Spring для Java)\r\nОснови криптографії та безпеки\r\nПроектування програмного забезпечення (проектування архітектури)\r\nРік 4:\r\n\r\nІнтелектуальний аналіз даних (машинне навчання та глибоке навчання)\r\nКомп'ютерна графіка та візуалізація\r\nРозробка мобільних додатків (Android або iOS)\r\nСистемне програмування та операційні системи\r\nПрофесійна практика та стажування");
                }



                if (message.Text.ToLower().Contains("(121) software engineering"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Рік 1:\r\n\r\nВступ до програмування (введення в основи програмування)\r\nВведення в математику (алгебра, геометрія)\r\nВведення в англійську мову та письмо\r\nОснови інженерної графіки\r\nВведення в інформатику (основи алгоритмів та структур даних)\r\nРік 2:\r\n\r\nПрограмування на високому рівні (Java, C++, або інші мови)\r\nОб'єктно-орієнтоване програмування\r\nВеб-розробка (HTML, CSS, JavaScript)\r\nБази даних (SQL та розробка баз даних)\r\nМатематика для комп'ютерних наук (дискретна математика)\r\nРік 3:\r\n\r\nПроектування програмного забезпечення (проектування та архітектура ПЗ)\r\nРозробка інтерфейсів користувача\r\nАлгоритми та структури даних (розширені алгоритми)\r\nБізнес-аналіз та управління проектами\r\nМоделювання та симуляція систем\r\nРік 4:\r\n\r\nІнтелектуальний аналіз даних (машинне навчання та глибоке навчання)\r\nКомп'ютерна безпека та кіберзахист\r\nТестування та якість програмного забезпечення\r\nРозробка мобільних додатків\r\nПрофесійна практика та стажування");
                    return;
                }
                if (message.Text.ToLower().Contains("(124) system analysis"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Рік 1:\r\n\r\nВведення в системний аналіз та ІТ (основи системного підходу)\r\nМатематичний аналіз та диференціальні рівняння\r\nОснови програмування (Java, Python або інші мови)\r\nВведення в інформатику та структури даних\r\nВведення в інженерію програмного забезпечення\r\nРік 2:\r\n\r\nМатематична статистика та теорія ймовірностей\r\nМетоди оптимізації та оптимізаційні моделі\r\nАлгоритми та структури даних (розширені алгоритми)\r\nБази даних та SQL\r\nСистеми керування проектами\r\nРік 3:\r\n\r\nАналіз вимог та функціональний аналіз\r\nМоделювання бізнес-процесів та діаграми потоків\r\nТеорія систем та динамічне моделювання\r\nУправління якістю та тестування\r\nРозробка інтерфейсів користувача та дизайн\r\nРік 4:\r\n\r\nАрхітектура програмних систем\r\nСистеми підтримки прийняття рішень\r\nМоделювання та оптимізація великих систем\r\nІнформаційна безпека та кіберзахист\r\nПроектування експертних систем");
                    return;
                }
                if (message.Text.Contains("(125) Cyber security"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Рік 1:\r\n\r\nОснови інформаційної безпеки (вступ в кібербезпеку)\r\nМатематика та статистика для кібербезпеки\r\nОснови програмування та структури даних\r\nОснови мереж та мережевої безпеки\r\nВведення в кіберзахист і етику\r\nРік 2:\r\n\r\nКриптографія та шифрування\r\nОпераційні системи та безпека ОС\r\nАналіз загроз і вразливостей\r\nМетоди виявлення та відповіді на інциденти безпеки\r\nМатеріальна безпека і управління ризиками\r\nРік 3:\r\n\r\nАудит та сертифікація системи безпеки\r\nЗахист мереж та периметру\r\nКіберзахист веб-додатків\r\nБезпека мобільних і вбудованих систем\r\nУправління доступом та ідентифікацією\r\nРік 4:\r\n\r\nПроектування та розробка безпечних систем\r\nКіберзахист великих даних та хмарних сервісів\r\nІнциденти та відновлення після кібератак\r\nСоціальний інженеринг і боротьба з фішингом\r\nЮридичні та етичні аспекти кібербезпеки");
                    return;
                }
                if (message.Text.Contains("(126) Information systems and technologies"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Рік 1:\r\n\r\nВведення в інформаційні системи та технології\r\nОснови програмування (Java, Python або інші мови)\r\nВведення в математику та статистику\r\nОснови інформатики та структури даних\r\nВведення в бази даних та SQL\r\nРік 2:\r\n\r\nОпераційні системи та мережеві технології\r\nВеб-розробка (HTML, CSS, JavaScript)\r\nАрхітектура інформаційних систем\r\nМетоди проектування та аналізу систем\r\nМатематична моделювання в інформаційних системах\r\nРік 3:\r\n\r\nУправління проектами та розробка програмного забезпечення\r\nАналіз вимог і проектування інформаційних систем\r\nБізнес-аналіз і стратегічне планування ІТ\r\nІнформаційна безпека та кіберзахист\r\nМережева адміністрація та адміністрування баз даних\r\nРік 4:\r\n\r\nРозробка мобільних додатків та веб-сервісів\r\nІнтернет речей (IoT) та вбудовані системи\r\nВеликі дані та обробка даних\r\nІнновації та підприємництво в ІТ\r\nПрофесійна практика та стажування в сфері ІТ");
                    return;
                }





                if (message.Text.ToLower().Contains("military department"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Present🧑‍🚀");
                }


                if (message.Text.ToLower().Contains("how to get there"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "вулиця Князя Романа, 5, Львів, Львівська область, 79000");
                    Message messagePhoto = await botClient.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://lh5.googleusercontent.com/p/AF1QipMq9tjZVtZV_8Gb4kWwuR3IJduQ3uwiF-5mb-VV=w408-h306-k-no"),
                        parseMode: ParseMode.Html);
                }

                if (message.Text.ToLower().Contains("official site"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "https://amath.lp.edu.ua/");
                }
                if (message.Text.ToLower().Contains("back"))
                {
                    Message sentMessageEnd = await botClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: "Back to main keyboard",
                        replyMarkup: replyKeyboardMarkup);
                }
                if (message.Text.ToLower().Contains("exit"))
                {

                    Message sentMessageEnd = await botClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: "Removing keyboard",
                        replyMarkup: new ReplyKeyboardRemove());
                }
            }
        }

        private static async Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {

        }

        private static ReplyKeyboardMarkup replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton[] { "Specialties" },
            new KeyboardButton[] {  "Educational programs" },
            new KeyboardButton[] { "Military department" },
            new KeyboardButton[] {  "How to get there" },
            new KeyboardButton[] { "Official site" },
            new KeyboardButton[] {  "Exit" },
        })
        {
            ResizeKeyboard = true
        };
        private static ReplyKeyboardMarkup replyKeyboardMarkup2 = new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton[] { "(122) Computer Science" },
            new KeyboardButton[] {  "(121) Software engineering" },
            new KeyboardButton[] { "(124) System analysis" },
            new KeyboardButton[] {  "(125) Cyber security" },
            new KeyboardButton[] { "(126) Information systems and technologies" },
            new KeyboardButton[] {  "Back" },
        })
        {
            ResizeKeyboard = true
        };

    }
}
