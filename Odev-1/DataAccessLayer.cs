using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_1
{
    public class DataAccessLayer
    {
        SqlConnection connect;
        SqlDataAdapter adapter, updateadap;
        SqlCommandBuilder builder;
        DataSet ds = new DataSet();
        DataSet updateds = new DataSet();
        DataRelation dr;
        string sql = "";
        public DataAccessLayer()
        {
            connect = new SqlConnection("Server=.;Database=IMDB;uid=sa;pwd=9117");
            sql = "Select * from Movies; Select * from Casts; Select * from MovieCastRoleMapping; Select * from Roles; Select * from Images";
            adapter = new SqlDataAdapter(sql, connect);
            adapter.TableMappings.Add("Table", "Movies");
            adapter.TableMappings.Add("Table1", "Casts");
            adapter.TableMappings.Add("Table2", "MovieCastRoleMapping");
            adapter.TableMappings.Add("Table3", "Roles");
            adapter.TableMappings.Add("Table4", "Images");
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            #region Relations
            //DataColumn movie_id = ds.Tables[0].Columns[0];
            //DataColumn image_movieid = ds.Tables[4].Columns[2];
            //dr = new DataRelation("drMovieImage", movie_id, image_movieid);
            //ds.Relations.Add(dr);
            #endregion
            //DBSet();
        }
        public void DBSet()
        {
            adapter = new SqlDataAdapter(sql, connect);
            ds.Tables[0].Rows.Clear();
            ds.Tables[1].Rows.Clear();
            ds.Tables[2].Rows.Clear();
            ds.Tables[3].Rows.Clear();
            ds.Tables[4].Rows.Clear();
            adapter.TableMappings.Add("Table", "Movies");
            adapter.TableMappings.Add("Table1", "Casts");
            adapter.TableMappings.Add("Table2", "MovieCastRoleMapping");
            adapter.TableMappings.Add("Table3", "Roles");
            adapter.TableMappings.Add("Table4", "Images");
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
        }
        public void Save(string tablename)
        {
            //if(tablename=="Movies")
            //    updateadap = new SqlDataAdapter("Select * from Movies", connect);
            //else if (tablename == "Casts")
            //    updateadap = new SqlDataAdapter("Select * from Casts", connect);
            //else if (tablename == "MovieCastRoleMapping")
            //    updateadap = new SqlDataAdapter("Select * from MovieCastRoleMapping", connect);
            updateadap = new SqlDataAdapter("Select * from " + tablename, connect);
            builder = new SqlCommandBuilder(updateadap);
            updateadap.Fill(ds, tablename);
            updateadap.Update(ds, tablename);
        }
        public Movie DBControl(Movie movie)
        {
            DataRow[] result = ds.Tables[0].Select("ImdbId='" + movie.ImdbId + "'");
            if (result.Length > 0)
            {
                Movie film = new Movie();
                film.ID = (int)result[0].ItemArray[0];
                film.Name = result[0].ItemArray[1].ToString();
                film.Description = result[0].ItemArray[2].ToString();
                film.Raiting = result[0].ItemArray[3].ToString();
                film.ImdbId = result[0].ItemArray[4].ToString();
                film.Poster = result[0].ItemArray[5].ToString();
                DataRow[] imagesrow = ds.Tables[4].Select("Movie_ID=" + film.ID);
                foreach (DataRow row in imagesrow)
                {
                    film.Images.Add(row.ItemArray[1].ToString());
                }
                ds.Tables[1].PrimaryKey = new DataColumn[] {ds.Tables[1].Columns["ID"]};  
                Cast cast;
                DataRow[] castsrow = ds.Tables[2].Select("Movie_ID=" + film.ID);
                foreach (DataRow row in castsrow)
                {
                    DataRow foundCast = ds.Tables[1].Rows.Find(row.ItemArray[1]);
                    cast= new Cast();
                    cast.ID =(int)foundCast.ItemArray[0];
                    cast.ImdbId = foundCast.ItemArray[1].ToString();
                    cast.Name = foundCast.ItemArray[2].ToString();

                    DataRow[] foundRole = ds.Tables[2].Select("Cast_ID=" + cast.ID);
                    foreach (DataRow role in foundRole)
                    {
                        if ((int)role.ItemArray[2] == 1)
                            cast.Roles.Add(Role.Director);
                        else if ((int)role.ItemArray[2] == 2)
                            cast.Roles.Add(Role.Actor);
                        else if ((int)role.ItemArray[2] == 3)
                            cast.Roles.Add(Role.Writer);
                    }
                    Cast person = film.Casts.FirstOrDefault(x => x.Name == cast.Name);
                    if (person==null)
                    {
                        film.Casts.Add(cast);
                    }
                    
                }
                return film;
            }
            else { return null; }
        }

        public void MovieSave(Movie movie)
        {
            DataRow row = ds.Tables[0].NewRow();
            row["Name"] = movie.Name;
            row["Description"] = movie.Description;
            row["Raiting"] = movie.Raiting;
            row["ImdbId"] = movie.ImdbId;
            row["Poster"] = movie.Poster;
            ds.Tables[0].Rows.Add(row);
            Save("Movies");
            DBSet();
            foreach (var image in movie.Images)
            {
                DataRow[] movierow = ds.Tables[0].Select("ImdbId='" + movie.ImdbId + "'");
                DataRow[] result = ds.Tables[4].Select("Image='" + image + "'");
                if (result.Length < 1)
                {
                    DataRow imagerow = ds.Tables[4].NewRow();
                    imagerow["Image"] = image.ToString();
                    imagerow["Movie_ID"] = movierow[0].ItemArray[0];
                    ds.Tables[4].Rows.Add(imagerow);
                }
                Save("Images");
                DBSet();
                //MovieImageSave(movie, image);
            }
            MovieCastSave(movie);

        }

        public void MovieCastSave(Movie movie)
        {
            foreach (Cast cast in movie.Casts)
            {
                DataRow[] result = ds.Tables[1].Select("ImdbId='" + cast.ImdbId + "'");
                if (result.Length < 1)
                {
                    DataRow row = ds.Tables[1].NewRow();
                    row["ImdbId"] = cast.ImdbId;
                    row["Name"] = cast.Name;
                    ds.Tables[1].Rows.Add(row);
                }

                Save("Casts");
                DBSet();
                CastRoleSave(cast, movie);
            }
        }

        public void CastRoleSave(Cast cast, Movie movie)
        {
            Dictionary<string, int> myDic = ((Role[])Enum.GetValues(typeof(Role))).ToDictionary(k => k.ToString(), v => (int)v);
            DataRow[] movierow = ds.Tables[0].Select("ImdbId='" + movie.ImdbId + "'");
            DataRow[] castrow = ds.Tables[1].Select("ImdbId='" + cast.ImdbId + "'");
            foreach (Role role in cast.Roles)
            {
                DataRow row = ds.Tables[2].NewRow();
                row["Movie_ID"] = movierow[0].ItemArray[0];
                row["Cast_ID"] = castrow[0].ItemArray[0];
                row["Role_ID"] = (int)myDic[role.ToString()];
                ds.Tables[2].Rows.Add(row);
            }
            Save("MovieCastRoleMapping");
            DBSet();
        }

        public void MovieImageSave(Movie movie, string image)
        {
            DataRow[] movierow = ds.Tables[0].Select("ImdbId='" + movie.ImdbId + "'");
            DataRow[] imagerow = ds.Tables[4].Select("Image='" + image + "'");
            DataRow movieimagerow = ds.Tables[5].NewRow();
            movieimagerow["Movie_ID"] = movierow[0].ItemArray[0];
            movieimagerow["Image_ID"] = imagerow[0].ItemArray[0];
            ds.Tables[5].Rows.Add(movieimagerow);
            Save("MovieImage");
            DBSet();
        }
        //public void LoadMovie(Movie movie)
    }
}
