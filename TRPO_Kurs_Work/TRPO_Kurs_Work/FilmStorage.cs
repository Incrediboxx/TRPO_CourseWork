using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public class Film
    {
        string Name;
        int Duration;
        string Maker;
        
        Film(string name,int duration, string maker)
        {
            this.Name = name;
            this.Duration = duration;
            this.Maker = maker;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetDuration()
        {
            return Duration;
        }

        public string GetMaker()
        {
            return Maker;
        }

    }


    public class FilmStorage
    {
        Dictionary<string, Film> filmStorage = new Dictionary<string, Film>();        

        public bool AddFilm(Film film)
        {
            if (!filmStorage.ContainsKey(film.GetName()))
            {
                filmStorage.Add(film.GetName(), film);
                return true;
            }
            else
            {
                MessageBox.Show("Такой фильм уже добавлен",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }

        public IDictionary<string, Film> GetStorage()
        {
            return filmStorage;
        }
    }
}
