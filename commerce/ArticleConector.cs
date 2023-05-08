﻿using System;
using System.Collections.Generic;

namespace domain
{
    public class ArticleConector
    {
        public List<Article> Listar()
        {
            List<Article> ArticlesList = new List<Article>();
            DataAccess data = new DataAccess();

            try
            {
                string query = "SELECT a.ID as artId, a.nombre as name, a.descripcion as artDescrip, a.Codigo as artCode, a.precio as price, c.Descripcion as category, c.Id as categoryId, " +
                    "m.Descripcion as brand, m.id as brandId, STRING_AGG(i.imagenUrl, ',') AS imagen FROM Articulos a LEFT JOIN Imagenes i ON a.ID = i.idArticulo " +
                    "LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN MARCAS m on m.Id = a.IdMarca " +
                    "GROUP BY a.ID, a.nombre, a.Codigo, a.descripcion, a.precio, c.Descripcion, c.Id, m.Descripcion, m.Id order by a.id ";
                data.setQuery(query);
                data.execute();

                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.ArticleId = (!(data.sqlReader["artId"] is DBNull)) ? (int)data.sqlReader["artId"] : 0;
                    aux.Name = (!(data.sqlReader["name"] is DBNull)) ? (string)data.sqlReader["name"] : "";
                    aux.Description = (!(data.sqlReader["artDescrip"] is DBNull)) ? (string)data.sqlReader["artDescrip"] : "";
                    aux.ArticleCode = (!(data.sqlReader["artCode"] is DBNull)) ? (string)data.sqlReader["artCode"] : "";
                    aux.Price = (!(data.sqlReader["price"] is DBNull)) ? (decimal) data.sqlReader["price"] : 0;
                    aux.ArticleCategory = new Category(
                        (!(data.sqlReader["categoryId"] is DBNull)) ? (int)data.sqlReader["categoryId"] : 0,
                        (!(data.sqlReader["category"] is DBNull)) ? (string)data.sqlReader["category"] : ""
                        );
                    aux.ArticleBrand = new Brand(
                        (!(data.sqlReader["brandId"] is DBNull)) ? (int)data.sqlReader["brandId"] : 0,
                        (!(data.sqlReader["brand"] is DBNull)) ?(string)data.sqlReader["brand"] : ""
                        );
                    aux.Image = (!(data.sqlReader["imagen"] is DBNull)) ? (string)data.sqlReader["imagen"] : "";
              
                    ArticlesList.Add(aux);
                }
                return ArticlesList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.close();
            }
        }

        public void Modifity(Article article)
        {
            DataAccess dataAcces = new DataAccess();


            try
            {
                dataAcces.setQuery("update Articulos set Codigo = @cod , Nombre = @name, Descripcion = @description, IdMarca = @idMarca, Precio = @price  where Id= @id");
                dataAcces.setearParametro("@cod", article.ArticleCode);
                dataAcces.setearParametro("@name", article.Name);
                dataAcces.setearParametro("@description", article.Description);
                dataAcces.setearParametro("@idMarca", article.ArticleBrand.Id);
                dataAcces.setearParametro("@id", article.ArticleId);
                dataAcces.setearParametro("@price", article.Price);

                dataAcces.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataAcces.close();
            }

        }

        public int CreateNewArticle(Article newArt)
        {
            DataAccess acces = new DataAccess();

            try
            {
                string query = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, Precio) OUTPUT Inserted.ID values('" + newArt.ArticleCode + "', '" + newArt.Name + "', '" + newArt.Description +"', " + newArt.ArticleBrand.Id + ", " +newArt.Price + ")";
                acces.setQuery(query);
                int newArticleId = (int) acces.executeScalar();
                acces.ClearQuery();

                acces.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) values(" + newArticleId + ", '"+ newArt.Image + "')");
                acces.executeAction();
                return newArticleId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Listar();
                acces.close();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.setQuery("delete from Articulos where id = @id");
                data.setearParametro("@id", id);
                data.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Article> filtrar(string brand, string category, string filtro)
         {
        List<Article> list = new List<Article>();
            DataAccess data = new DataAccess();
            try
            {
                string consulta = "SELECT a.ID as artId, a.nombre as name, a.descripcion as artDescrip, a.Codigo as artCode, a.precio as price, c.Descripcion as category, c.Id as categoryId, " +
                    "m.Descripcion as brand, m.id as brandId, STRING_AGG(i.imagenUrl, ',') AS imagen FROM Articulos a LEFT JOIN Imagenes i ON a.ID = i.idArticulo " +
                    "LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN MARCAS m on m.Id = a.IdMarca " +
                    "GROUP BY a.ID, a.nombre, a.Codigo, a.descripcion, a.precio, c.Descripcion, c.Id, m.Descripcion, m.Id order by a.id ";
                 data.setQuery(consulta);
                data.execute();
                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.ArticleId = (!(data.sqlReader["artId"] is DBNull)) ? (int)data.sqlReader["artId"] : 0;
                    aux.Name = (!(data.sqlReader["name"] is DBNull)) ? (string)data.sqlReader["name"] : "";
                    aux.Description = (!(data.sqlReader["artDescrip"] is DBNull)) ? (string)data.sqlReader["artDescrip"] : "";
                    aux.ArticleCode = (!(data.sqlReader["artCode"] is DBNull)) ? (string)data.sqlReader["artCode"] : "";
                    aux.Price = (!(data.sqlReader["price"] is DBNull)) ? (decimal)data.sqlReader["price"] : 0;
                    aux.ArticleCategory = new Category(
                        (!(data.sqlReader["categoryId"] is DBNull)) ? (int)data.sqlReader["categoryId"] : 0,
                        (!(data.sqlReader["category"] is DBNull)) ? (string)data.sqlReader["category"] : ""
                        );
                    aux.ArticleBrand = new Brand(
                        (!(data.sqlReader["brandId"] is DBNull)) ? (int)data.sqlReader["brandId"] : 0,
                        (!(data.sqlReader["brand"] is DBNull)) ? (string)data.sqlReader["brand"] : ""
                        );
                    aux.Image = (!(data.sqlReader["imagen"] is DBNull)) ? (string)data.sqlReader["imagen"] : "";

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }

    }

    
}

