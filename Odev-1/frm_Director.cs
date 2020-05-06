using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_1
{
    public partial class frm_Director : Form
    {
        Cast person;       
        Movie filmography;
        public frm_Director(Cast cast)
        {
            person = cast;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void lbl_lnk_seeall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Photos frmphoto = new Photos(person);
            frmphoto.Show();
        }

        private void frm_Director_Load(object sender, EventArgs e)
        {           
            person =  person.Desc(person);
            txt_born.Text = person.Born;
            txt_desc.Text = person.Description;
            lbl_name.Text = person.Name.Contains('(') ? person.Name.Substring(0, person.Name.IndexOf('(')) : person.Name;
            person = person.Poster(person);
            pct_poster.Load(person.ProfileImage);
            ImagesList(person.Photos(person));
            KnownList(person.GetKnownFor(person));
            person = person.Filmography(person, filmography);
            for (int i = 0; i < person.Filmographies.Count; i++)
            {
                if (person.Roles[i] == Role.Director)
                    lst_director.Items.Add(person.Filmographies[i].Name);
                if (person.Roles[i] == Role.Writer)
                    lst_writer.Items.Add(person.Filmographies[i].Name);
                if (person.Roles[i] == Role.Actor)
                    lst_actor.Items.Add(person.Filmographies[i].Name);
            }           
        }
        public void KnownList(List<string> list)
        {
            int x = 20, y = 20, maxHeight = -1;
            foreach (var item in list)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new System.Drawing.Size(140, 160);
                pic.Load(item);
                pic.Location = new Point(x, y);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                x += pic.Width + 10;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                this.panelKnownFor.Controls.Add(pic);
            }


        }
        public void ImagesList(List<string> list)
        {
            int x = 20, y = 20, maxHeight = -1;
            foreach (var item in list)
            {
                PictureBox pic = new PictureBox();
                pic.Load(item);
                pic.Location = new Point(x, y);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new System.Drawing.Size(100, 170);
                x += pic.Width + 10;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                this.panelImage.Controls.Add(pic);
            }

        }

        private void lst_director_SelectedIndexChanged(object sender, EventArgs e)
        {
            string moviename = lst_director.SelectedItem.ToString();
            foreach (var item in person.Filmographies)
            {
                if (item.Name == moviename)
                {
                    string url = item.ImdbId;
                    this.Hide();
                    MovieDetails frm_movies = new MovieDetails(url);
                    frm_movies.Show();
                    break;
                }
            }
        }

        private void lst_writer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string moviename = lst_writer.SelectedItem.ToString();
            foreach (var item in person.Filmographies)
            {
                if (item.Name == moviename)
                {
                    string url = item.ImdbId;
                    this.Hide();
                    MovieDetails frm_movies = new MovieDetails(url);
                    frm_movies.Show();
                    break;
                }
            }
        }

        private void lst_actor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string moviename = lst_actor.SelectedItem.ToString();
            foreach (var item in person.Filmographies)
            {
                if (item.Name == moviename)
                {
                    string url = item.ImdbId;
                    this.Hide();
                    MovieDetails frm_movies = new MovieDetails(url);
                    frm_movies.Show();
                    break;
                }
            }
        }
              
    }

}


