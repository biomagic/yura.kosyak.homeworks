using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
  class Program
  {
    static void Main()
    {
      Messaging msg = new Messaging();
      Capulet Gregory = new Capulet { Name = "Gregory", phrase = new []{ "Хорошо, что ты не рыба, а то был бы ты соленой трескою. Скорей, где твой меч? Вон двое монтекковских.", "Это еще что за разговор? Вперед, пожалуйста.", "Есть о ком беспокоиться!", "Я скорчу злое лицо, когда пройду мимо. Посмотрим, что они сделают.", "", "(вполголоса Самсону)\n\nНи в коем случае.", "Вы набиваетесь на драку, сэр?", "", "(в сторону, Самсону, заметив вдали Тибальта)\n\nГовори – у лучших, вон один из хозяйских." } };
      Capulet Sampson = new Capulet { Name = "Sampson", phrase = new []{ "Готово, меч вынут. Задери их, я тебя не оставлю.", "Обо мне не беспокойся.", "Выведем их из себя. Если они начнут драку первыми, закон будет на нашей стороне.", "Я буду грызть ноготь по их адресу. Они будут опозорены, если пропустят это мимо.", "Грызу ноготь, сэр.", "(вполголоса Грегорио)\n\nЕсли это подтвердить, закон на нашей стороне?", "Нет, я грызу ноготь не на ваш счет, сэр. А грызу, говорю, ноготь, сэр.", "Если набиваетесь, я к вашим услугам. Я проживаю у господ ничуть не хуже ваших.", "У лучших, сэр.", "Деритесь, если вы мужчины. Грегорио, покажи-ка им свой молодецкий удар." } };
      Montague Abraham = new Montague { Name = "Abraham", phrase = new []{ "Не на наш ли счет вы грызете ноготь, сэр?", "Не на наш ли счет вы грызете ноготь, сэр?", "Я, сэр? Нет, сэр.", "Но и не у лучших.", "Вы лжете!" } };


      
      msg.Dialogue += Gregory.Action;
      msg.Dialogue += Sampson.Action;
      for (int i = 0; i < Sampson.phrase.Length; i++)
      {
        
        if (i == 4)
        {
          Console.WriteLine("\nВходят Абрам и Балтазар.");
          msg.Dialogue -= Gregory.Action;
          msg.Provocation += Abraham.Reaction;
          msg.OnProvocation();

        } else if (i == 5)
        {
          msg.OnProvocation();
          msg.Dialogue += Gregory.Action;
        } else if (i == 7)
        {
          msg.OnProvocation();
        } else if (i == 8)
        {
          msg.Dialogue -= Sampson.Action;
          msg.Dialogue += Sampson.Action;
          msg.OnProvocation();
          Console.WriteLine("Входит Бенволио");
          msg.OnDialogue();
          msg.OnProvocation();
          msg.OnDialogue();
          msg.Fight += Sampson.Fighting;
          msg.OnFight();
        }
        msg.OnDialogue();

     }
      Console.ReadLine();
    }
  }
}
