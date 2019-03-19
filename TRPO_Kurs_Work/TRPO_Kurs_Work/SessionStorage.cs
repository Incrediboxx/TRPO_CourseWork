﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    class Session
    {
        int idSession;
        Film film;
        Hall hall;
        int price;

        Session(int n,Film film,Hall hall,int price)
        {
            this.idSession = n;
            this.film = film;
            this.hall = hall;
            this.price = price;
        }

        public int GetId()
        {
            return idSession;
        }

        public Film GetFilm()
        {
            return film;
        }

        public Hall GetHall()
        {
            return hall;
        }

        public int GetPrice()
        {
            return price;
        }
    }
    class SessionStorage
    {
        Dictionary<int, Session> sessionStorage = new Dictionary<int, Session>();

        public bool AddSession(Session session)
        {
            if (!sessionStorage.ContainsKey(session.GetId()))
            {
                sessionStorage.Add(session.GetId(), session);
                return true;
            }
            else
            {
                MessageBox.Show("Такой сеанс уже добавлен",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }
    }
}
