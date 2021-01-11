using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Travel.Data;

namespace Travel.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPlaceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPlaceContext>>()))
            {
                // Look for any places.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                //добавить строку в таблицу Место
                context.Movie.AddRange(
                    new Place
                    {
                        City = "Ярославль",
                        Address = "пл.Волкова, 2А",
                        Cost = 50,
                        Rate = 9,
                        Time = "1:00-2:00",
                        Status = "Для всей семьи",
                        Type = "Исторический памятник",
                        ReviewPlace = "Ярославль-Знаменская Башня - одно из прекраснейших зданий в центре города. Архитектура, местоположение, красота здания- историческая достопримечательность города Ярославль.",
                        NamePlace = "Знаменская башня",
                    },
                    new Place
                    {
                        City = "Ярославль",
                        Address = "ул. Подзеленье, 1-а",
                        Cost = 1000,
                        Rate = 8,
                        Time = "2:00-4:00",
                        Status = "Для всей семьи",
                        Type = "Парк развлечений",
                        ReviewPlace = "Прекрасное место. Парк в центре города,но с укромным местами на берегу р. Которосли. Здесь есть аттракционы для детей, взрослые могут показаться на велосипедах или просто погулять по пешеходным дорожкам. Красиво.",
                        NamePlace = "Парк на Даманском острове",
                    },
                    new Place
                    {
                        City = "Рыбинск",
                        Address = "Волжская наб. ул., 2",
                        Cost = 150,
                        Rate = 9,
                        Time = "1:00-2:00",
                        Status = "12+",
                        Type = "Музей истории",
                        ReviewPlace = "Музей находиться в красивом здании, построенном в стиле эклектика. Находится в самом центре города, из окон открывается красивый вид на реку Волга. Большое количество экспонатов. Картинная галлерея впечатляет. ",
                        NamePlace = "Рыбинский государственный историко-архитектурный и художественный музей-заповедник",
                    },
                    new Place
                    {
                        City = "Рыбинск",
                        Address = "Стоялая ул., 4",
                        Cost = 500,
                        Rate = 8,
                        Time = "0:30-2:00",
                        Status = "Для всей семьи",
                        Type = "Кафе",
                        ReviewPlace = "Очень вкусные блюда, место приятное. Рекомендую к посещению. Были втроём с ребёнком, все в восторге.",
                        NamePlace = "Двенадцать Стульев",
                    },
                    new Place
                    {
                        City = "Кострома",
                        Address = "ул. Симановского, 1",
                        Cost = 100,
                        Rate = 8,
                        Time = "1:00-2:00",
                        Status = "Для всей семьи",
                        Type = "Музей",
                        ReviewPlace = "Самая большая и шикарная каланча (есть и в Ярославле и в Вологде и в других городах), но тут и колонны и высота впечатляет. Сейчас там располагается МЧС.",
                        NamePlace = "Пожарная каланча",
                    },
                    new Place
                    {
                        City = "Кострома",
                        Address = "ул. Чайковского, 4А",
                        Cost = 0,
                        Rate = 7,
                        Time = "0:30-1:00",
                        Status = "Для всей семьи",
                        Type = "Парк",
                        ReviewPlace = "Шикарный вид открывается сверху на Волгу. Сам парк требует ухода, надеюсь власти займутся облагораживанием. Зимой очень спокойно и уютно, ветвистые сосны украшают аллеи.",
                        NamePlace = "Центральный парк",
                    },
                    new Place
                    {
                        City = "Переславль-Залесский",
                        Address = "ул. Гагарина, 43",
                        Cost = 0,
                        Rate = 9,
                        Time = "0:30-1:00",
                        Status = "Для всей семьи",
                        Type = "Женский монастырь",
                        ReviewPlace = "Монастырь действительно очень красив и ухожен. Так и хочется сказать чувствуется женская рука(он женский))",
                        NamePlace = "Никольский монастырь",
                    },
                    new Place
                    {
                        City = "Переславль-Залесский",
                        Address = "Советская ул., 11",
                        Cost = 300,
                        Rate = 10,
                        Time = "1:30-2:00",
                        Status = "Для всей семьи",
                        Type = "Музей",
                        ReviewPlace = "Это просто обязательное для посещения место! Очень классная экскурсия, живая, с юмором, с возможностью поторговать экспонаты. Кругом интересные экспонаты, юморные подписи.",
                        NamePlace = "Музей Утюга",
                    },
                    new Place //9
                    {
                        City = "Ростов",
                        Address = "Кремль, Ростов",
                        Cost = 0,
                        Rate = 9,
                        Time = "1:00-1:30",
                        Status = "Для всей семьи",
                        Type = "Музей-заповедник",
                        ReviewPlace = "Потрясающее место! Очень люблю посещать этот город именно из-за кремля. Он того стоит. Очень красивое, эпичное и интересное место.",
                        NamePlace = "Государственный музей-заповедник Ростовский кремль",
                    },
                    new Place //10
                    {
                        City = "Ростов",
                        Address = "ул. Петровичева, 1",
                        Cost = 1000,
                        Rate = 9,
                        Time = "1:00-1:30",
                        Status = "Для всей семьи",
                        Type = "Ресторан русской кухни",
                        ReviewPlace = "Очень красивый, настоящий ресторан. Расположен в каменных древних палатах. Меню прекрасное. Приносят быстро, все четко.",
                        NamePlace = "Собрание",
                    },
                    new Place //11
                    {
                        City = "Адлер",
                        Address = "Олимпийский просп., Адлер",
                        Cost = 0,
                        Rate = 9,
                        Time = "1:00-5:00",
                        Status = "Для всей семьи",
                        Type = "Общественный пляж",
                        ReviewPlace = "Хороший пляж, можно арендовать полотенца , шезлонги, беседки. Есть массаж. Детская зона и аниматоры. Много персонала.",
                        NamePlace = "Пляж курорта Роза Хутор",
                    },
                    new Place //12
                    {
                        City = "Адлер",
                        Address = "Олимпийский просп., 21, Сочи",
                        Cost = 1000,
                        Rate = 9,
                        Time = "1:00-2:00",
                        Status = "Для всей семьи",
                        Type = "Культурный центр",
                        ReviewPlace = "В дельфинарий выступает морской котик и тройка дельфинов.Однако немного портит впечатление ведущий.",
                        NamePlace = "Дельфинарий",
                    }
                    /*
                    new User
                    {
                        Email = "i.ivanov@yandex.ru",
                        Password = "12345",
                        Name = "Иванов Иван",
                        Age = 19,
                    },
                    new User
                    {
                        Email = "p.petrov@gmail.com",
                        Password = "qwerty",
                        Name = "Петров Пётр",
                        Age = 21,
                    },
                    new User
                    {
                        Email = "l.tolstoy@yandex.ru",
                        Password = "ytrewq",
                        Name = "Толстой Лев",
                        Age = 50,
                    },
                    new User
                    {
                        Email = "a.pushkin@mail.ru",
                        Password = "54321",
                        Name = "Пушкин Александр",
                        Age = 30,
                    },

                    new Route
                    {
                        RateRoute = 9,
                        ReviewRoute = "Отличный маршрут! Прошли его за день, насладились красотами города и вкусно поели в конце!",
                    },
                    new Route
                    {
                        RateRoute = 5,
                        ReviewRoute = "Не понравилось, что маршрут такой короткий",
                    },
                    new Route
                    {
                        RateRoute = 7,
                        ReviewRoute = "Было здорово!",
                    },

                    new Bunch
                    {
                        PlaceID = 2,
                        //  Place Place,
                        RouteID = 1,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 3,
                        //  Place Place,
                        RouteID = 1,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 4,
                        //  Place Place,
                        RouteID = 1,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 5,
                        //  Place Place,
                        RouteID = 2,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 7,
                        //  Place Place,
                        RouteID = 2,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 1,
                        //  Place Place,
                        RouteID = 3,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 2,
                        //  Place Place,
                        RouteID = 3,
                        //  Route Route,
                    },
                    new Bunch
                    {
                        PlaceID = 4,
                        //  Place Place,
                        RouteID = 3,
                        //  Route Route,
                    },

                    new TimeTable
                    {
                        UserID = 1,
                        // User User
                        RouteID = 1,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 1,
                        // User User
                        RouteID = 2,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 1,
                        // User User
                        RouteID = 3,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 2,
                        // User User
                        RouteID = 3,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 3,
                        // User User
                        RouteID = 1,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 4,
                        // User User
                        RouteID = 1,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 4,
                        // User User
                        RouteID = 2,
                        //Route Route
                    },
                    new TimeTable
                    {
                        UserID = 4,
                        // User User
                        RouteID = 3,
                        //Route Route
                    }*/
                );
                context.SaveChanges();
                if (context.Movie.Any())
                {
                    return;   
                }
                //добавить строку в таблицу Фото(фотографии мест)
                context.Photo.AddRange(
                    new Photo
                    {
                        PlaceID = 1,
                        RPhoto = "photo/photo4.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 1,
                        RPhoto = "photo/photo4.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 1,
                        RPhoto = "photo/photo4.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 1,
                        RPhoto = "photo/photo4.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 2,
                        RPhoto = "photo/photo5.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 2,
                        RPhoto = "photo/photo5.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 2,
                        RPhoto = "photo/photo5.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 2,
                        RPhoto = "photo/photo5.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 3,
                        RPhoto = "photo/photo6.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 3,
                        RPhoto = "photo/photo6.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 3,
                        RPhoto = "photo/photo6.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 3,
                        RPhoto = "photo/photo6.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 4,
                        RPhoto = "photo/photo7.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 4,
                        RPhoto = "photo/photo7.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 4,
                        RPhoto = "photo/photo7.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 4,
                        RPhoto = "photo/photo7.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 5,
                        RPhoto = "photo/photo8.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 5,
                        RPhoto = "photo/photo8.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 5,
                        RPhoto = "photo/photo8.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 5,
                        RPhoto = "photo/photo8.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 6,
                        RPhoto = "photo/photo9.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 6,
                        RPhoto = "photo/photo9.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 6,
                        RPhoto = "photo/photo9.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 6,
                        RPhoto = "photo/photo9.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 7,
                        RPhoto = "photo/photo10.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 7,
                        RPhoto = "photo/photo10.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 7,
                        RPhoto = "photo/photo10.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 7,
                        RPhoto = "photo/photo10.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 8,
                        RPhoto = "photo/photo11.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 8,
                        RPhoto = "photo/photo11.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 8,
                        RPhoto = "photo/photo11.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 8,
                        RPhoto = "photo/photo11.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 9,
                        RPhoto = "photo/photo12.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 9,
                        RPhoto = "photo/photo12.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 9,
                        RPhoto = "photo/photo12.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 9,
                        RPhoto = "photo/photo12.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 10,
                        RPhoto = "photo/photo13.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 10,
                        RPhoto = "photo/photo13.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 10,
                        RPhoto = "photo/photo13.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 10,
                        RPhoto = "photo/photo13.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 11,
                        RPhoto = "photo/photo14.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 11,
                        RPhoto = "photo/photo14.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 11,
                        RPhoto = "photo/photo14.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 11,
                        RPhoto = "photo/photo14.3.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 12,
                        RPhoto = "photo/photo15.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 12,
                        RPhoto = "photo/photo15.1.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 12,
                        RPhoto = "photo/photo15.2.jpg",
                    },
                    new Photo
                    {
                        PlaceID = 12,
                        RPhoto = "photo/photo15.3.jpg",
                    }
                   );
                context.SaveChanges();
            }
        }
    }
}
