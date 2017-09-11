using System;
using System.Text;
using System.Windows.Forms;

namespace Lab_01

{
    class Game
    {
        private void endGame(int number)
        {
            StringBuilder message = new StringBuilder();
            message.Append("По твоим ответам это должно быть число " + number.ToString()+" !");
            MessageBox.Show("Вариантов больше нет","СТОП!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            MessageBox.Show(message.ToString(), "Загаданное число!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Environment.Exit(0);
            
        }
        

        private void guess(int min, int max)
        {

            int number = 0;

            if (max - min != 0)
                number = min + ((max - min) / 2);

            if (min == max)
                endGame(number);
            StringBuilder message = new StringBuilder();
            message.Append("Ты загадал число " + number.ToString() + " ? " + "\nДиапазон поиска от " + min.ToString() + " до " + max.ToString());

            if (DialogResult.No == MessageBox.Show(message.ToString(), "Ответь на вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                message.Clear();
                message.Append("Подскажи пожалуйста!\nЗагаданное число больше " + number.ToString() + " ?");

                if ((max - min) == 1)
                    endGame(++number);

                if (DialogResult.Yes == MessageBox.Show(message.ToString(), "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    guess(number < max ? ++number : max, max);
                else
                    guess(min, number > min ? --number : min);
            }
            else
                MessageBox.Show("Я угадал твоё число !", "Победа!!");
        }

        public void Run()
        {
            guess(1,2000);
           
        }
    }
}