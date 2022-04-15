using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneScuola.Entities;

namespace GestioneScuola.Repository
{
    internal class RepositorySudenteADO
    {
        const string connectionString = @"Data Source = Computer di Enrica"; //non troverà mai il collegamento al db
        
        public Studente GetAllStudenti(int idStudente, string nome, string cognome, DateTime dataNascita) 
        {
           Studente student = null;
           SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Studente where IdStudente = @idStudente and Nome = @nome and Cognome = @cognome and DataNascita = @dataNascita";

                command.Parameters.AddWithValue("@idStudente", idStudente);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@cognome", cognome);
                command.Parameters.AddWithValue("@dataNascita", dataNascita);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = (int)reader["IdStudente"];
                    var name = (string)reader["Name"];
                    var surname = (string)reader["Cognome"];
                    var data = (DateTime)reader["DataNascita"];
                    

                    student = new Studente(id, name, surname, data);
                }
                return student;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Problemi con DB. Dettagli: {ex.Message}");
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore generico. Dettagli: {ex}");
                return student;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

       
    }
}
