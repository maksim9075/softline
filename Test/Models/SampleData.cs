using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public static class SampleData
    {
        public static void Initialize(CompanyDB context)
        {
            if (!context.People.Any())
            {
                context.People.AddRange
                (
                    new InfoPerson("Петров Андрей Игоревич","Бухгалтер",new DateTime(1995,4,16),"Комментарий отсутствует",false),
                    new InfoPerson("Афанасьева Элиза Робертовна", "Аудитор", new DateTime(1995, 1, 20), "Комментарий отсутствует", false),
                    new InfoPerson("Ким-тян Луиза Олеговна", "Инженер", new DateTime(2002, 6, 17), "Комментарий отсутствует", false),
                    new InfoPerson("Давыдова Анастасия Филипповна", "Специалист", new DateTime(1997, 3, 25), "Комментарий отсутствует", false),
                    new InfoPerson("Негребо Оксана Викторовна", "Диспетчер", new DateTime(1996, 8, 6), "Отличный сотрудник", true),
                    new InfoPerson("Овечкин Олег Васильевич", "Документовод", new DateTime(1989, 12, 6), "Комментарий отсутствует", false),
                    new InfoPerson("Стерлецкий Григорий Сергеевич", "Бухгалтер", new DateTime(1998, 03, 4), "Комментарий отсутствует", false),
                    new InfoPerson("Антипова Марина Ивановна", "Брокер", new DateTime(2000, 06, 5), "Комментарий отсутствует", true),
                    new InfoPerson("Травин Степан Маркович", "Специалист", new DateTime(2001, 09, 1), "Готовится к отпуску", false),
                    new InfoPerson("Левина Мария Александровна", "Лаборант", new DateTime(1996, 03, 13), "Комментарий отсутствует", true)
                );
                context.SaveChanges();
            }
        }
    }
}
