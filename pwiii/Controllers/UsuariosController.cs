using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using pwiii.entidades;
using System.Collections.Generic;

namespace pwiii.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly string connectionString = "Server=localhost;Database=aulabd2;Uid=root;Pwd=;";
        public IActionResult Index()
        {
            List<usuarioentidade> model = new List<usuarioentidade>();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            var cmd = new MySqlCommand("SELECT id, email FROM usuarios", connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuarioentidade u = new usuarioentidade();
                u.Id = reader.GetInt32("id");
                u.Email = reader.GetString("email");
                model.Add(u);
            }
            connection.Close();
            return View(model);
        }
    }
}
