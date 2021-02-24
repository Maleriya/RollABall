using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public sealed class DisplayEndGame
    {
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel; 
            _finishGameLabel.text = String.Empty;
        }

        public void GameOver(object o, CaughtPlayerEventArgs args)
        {
            if (o == null || args == null)
                throw new Exception("Для вывода сообщения о кнце игры не хватает данных.");

            _finishGameLabel.text = $"Вы проиграли. Вас убил {((GameObject)o).name} {args.Color} цвета";
        }
    }

}
