using System;
using System.Collections.Generic;

namespace PortalRandkowy.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        // Postawowe informacje
        public string Gender { get; set; }          // Płeć
        public DateTime DateOfBirth { get; set; }   // Data urodzenia
        public string ZodiacSign { get; set; }      // Znak zodiaku
        public DateTime Created { get; set; }       // Data utworzenia/rejestracji
        public DateTime LastActive { get; set; }    // Ostatnia aktywność
        public string City { get; set; }            // Miasto
        public string Country { get; set; }         // Kraj

        // Zakładka Info
        public string Growth { get; set; }          // Wygląd - wzrost
        public string EyeColor { get; set; }        // Wygląd - kolor oczu
        public string HairColor { get; set; }       // Wygląd - kolor włosów
        public string MartialStatus { get; set; }   // Formalne - stan cywilny
        public string Education { get; set; }       // Formalne - wykształcenie
        public string Profession { get; set; }      // Formalne - zawód
        public string Children { get; set; }        // Dzieci
        public string Languages { get; set; }       // Języki obce


        // Zakłada  O mnie
        public string Motto { get; set; }           // Motto życiowe
        public string Description { get; set; }     // Opis
        public string Personality { get; set; }     // Osobowość
        public string LookingFor { get; set; }      // Szukam


        // Zakłaka Pasje, zaiteresowania
        public string Interests { get; set; }       // Zainteresowania
        public string FreeTime { get; set; }        // Czas wolny
        public string Sport { get; set; }           // Sport
        public string Movies { get; set; }          // Filmy
        public string Music { get; set; }           // Muzyka


        // Zakładka Preferencje
        public string ILike { get; set; }           // Lubię
        public string IdoNotLike { get; set; }      // Nie lubię
        public string MakesMeLaugh { get; set; }    // Rozśmiesza mnie
        public string ItFeelsBestIn { get; set; }   // Najlepiej czuję się w
        public string FriendeWouldDescribeMe { get; set; }  // Przyjaciele opisali by mnie


        // Zakładka zdjecia
        public ICollection<Photo> Photos { get; set; }      // Zdjęcia użytkownika
    }
}