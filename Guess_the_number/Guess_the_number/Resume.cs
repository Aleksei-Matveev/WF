﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab_01

{
    class Resume
    {
        public void Run()
        {
            string messageOne = "Образцов Сергей Владимирович\n" + "Личные данные:\nвозраст: 32 года\nсемейное положение: женат\n"+
                "Контактная информация:\nАдрес: 127063, г.Москва, Дмитровское шоссе 137, кв. 231\n" +
                "Телефон: +7(972)134 - 48 - 235\n" +
                "E - mail: obrazetc @yandeks.ru\n";
            string messageTwo = "Цель:\n"+"Устроиться на интересную работу с достойной оплатой и перспективой карьерного роста в сфере экономики, банковской сфере или логистики."+
                        "Образование:\n"+
                        "2004 - 2009 - Московский государственный университет."+
                        "Специальность:\n"+
                        "Математические методы и модели исследования операций в экономике"+
                        "Средний балл зачетной книжки: 4,0.\n"+
                        "2000 - 2003 - Лицей информационных технологий.\n"+
                        "Опыт работы и профессиональные навыки:\n"+
                        "2007; 2017 гг. «Аэронавигация Московской области». Стажер(производственная практика), инженер, начальник отдела:\n" +
                        "-исследовал анализ уровней и закономерностей развития экономических систем и отдельных процессов, нашел метод их объективной оценки, выполнил планирование и прогнозирование развития отраслей и предприятий с применением математических методов и информационных технологий;\n" +
                        "-провел комплексный анализ хозяйственной деятельности предприятия современными средствами анализа и прогнозирования финансово - экономических ситуаций.";
            string messageThere = "Дополнительные навыки и интересы:\n" +
                        "Английский язык – средний уровень(перевожу технические тексты и свободно говорю);\n" +
                        "Опытный пользователь ПК.Работаю в программах: КОМПАС; AutoCad; ANSYS и др.\n" +
                        "Имею водительские права категории В.\n" +
                        "Личные достижения:\n" +
                        "Победитель олимпиады «1С - Карьера» г.Москва 2009.\n" +
                        "Занял 2 место в олимпиаде по математике МГУ, 2005г.\n" +
                        "Имею 1 разряд по шахматам.\n" +
                        "Личные качества:\n" +
                        "Ответственный, легко обучаемый, имею организаторские способности. Веду здоровый образ жизни.";
            string patern = @"[^\n\t]";
            

            int length = Regex.Matches(messageOne + messageTwo + messageThere, patern).Count;
           // length = messageOne.Length + messageTwo.Length + messageThere.Length;
            string text = "Среднее число символов равно " + length;

            MessageBox.Show(messageOne);
            MessageBox.Show(messageTwo);
            MessageBox.Show(messageThere, text);

        }
    }
}
