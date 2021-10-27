using QuanLyRapPhim.UserControls.DataUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.UserControls
{
    public partial class Data_UC : UserControl
    {
        public Data_UC()
        {
            InitializeComponent();
        }

        private void btnScreenTypeUC_Click(object sender, EventArgs e)
        {
            pnData.Controls.Clear();
            ScreenType_UC screen = new ScreenType_UC();
            screen.Dock = DockStyle.Fill;
            pnData.Controls.Add(screen);
        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            pnData.Controls.Clear();
            CinemaRoom_UC cinemaRoom = new CinemaRoom_UC();
            cinemaRoom.Dock = DockStyle.Fill;
            pnData.Controls.Add(cinemaRoom);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            pnData.Controls.Clear();
            FilmGenre_UC filmGenre = new FilmGenre_UC();
            filmGenre.Dock = DockStyle.Fill;
            pnData.Controls.Add(filmGenre);
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            pnData.Controls.Clear();
            Movies_UC movies = new Movies_UC();
            movies.Dock = DockStyle.Fill;
            pnData.Controls.Add(movies);
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {

        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {

        }
    }
}
