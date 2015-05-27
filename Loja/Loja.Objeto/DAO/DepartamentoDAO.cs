using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Loja.Objeto.BO;
using System.ComponentModel;
using Loja.Objeto.Models;


namespace Loja.Objeto.DAO
{
   
    public class DepartamentoDAO
    {
        public static void Insert(Departamento departamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Insert into Departamento(Nome_Departamento,Sigla_Departamento,Perc_Departamento,idChefeDepartamento) "
                                   + "values(@nomeDepartamento,@siglaDepartamento,@percComissaoDepartamento,@idChefeDepartamento)";

            comando.Parameters.AddWithValue("@nomeDepartamento", departamento.NomeDepartamento);
            comando.Parameters.AddWithValue("@siglaDepartamento", departamento.SiglaDepartamento);
            comando.Parameters.AddWithValue("@percComissaoDepartamento", departamento.PercComissaoDepartamento);

            comando.Parameters.AddWithValue("@idChefeDepartamento", departamento.ChefeDepartamentoVendedor);
            ConexãoBanco.CRUD(comando);
        }

        public static void Update(Departamento departamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Update Departamento set Nome_Departamento = @nomeDepartamento," +
                                  "Sigla_Departamento = @siglaDepartamento,Perc_Departamento = @percComissaoDepartamento"+
                                  "where idDepartamento = @idDepartamento";
            comando.Parameters.AddWithValue("@nomeDepartamento", departamento.NomeDepartamento);
            comando.Parameters.AddWithValue("@siglaDepartamento", departamento.SiglaDepartamento);
            comando.Parameters.AddWithValue("@percComissaoDepartamento", departamento.PercComissaoDepartamento);
            ConexãoBanco.CRUD(comando);                   
        }

        public static void Delete(Departamento departamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Delete from Departamento where idDepartamento = @idDepartamento";
            comando.Parameters.AddWithValue("@idDepartamento", departamento.IdDepartamento);
            ConexãoBanco.CRUD(comando);    
        }

        public static Departamento BuscarPorId(int idDepartamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = @"Select * from Departamento 
                                        where idDepartamento = @idDepartamento";
            comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            SqlDataReader dr = ConexãoBanco.Selecionar(comando);
            Departamento departamento = new Departamento();
            int departamentoId = dr.GetOrdinal("idDepartamento");
            int nomeDepartamento = dr.GetOrdinal("Nome_Departamento");
            int siglaDepartamento = dr.GetOrdinal("Sigla_Departamento");
            int percDepartamento = dr.GetOrdinal("Perc_Departamento");
            if (dr.HasRows)
            {
                dr.Read();
                departamento.IdDepartamento = dr.GetInt32(departamentoId);
                departamento.NomeDepartamento = dr.GetString(nomeDepartamento);
                departamento.SiglaDepartamento = dr.GetString(siglaDepartamento);
                departamento.PercComissaoDepartamento = dr.GetFloat(percDepartamento);
                //preenche o objeto
            }
            else
            {
                departamento = null;
            }
            return departamento;
        }

        public static List<Departamento> listarTodos(int departamentoId)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = @"Select idDepartamento,Nome_Departamento,Sigla_Departamento, Perc_Departamento,idChefeDepartamento 
                                    from Departamento 
                                    Where (idDepartamento = @idDepartamento) or @idDepartamento is null";

            if (departamentoId <= 0)
            {
                comando.Parameters.AddWithValue("@idDepartamento", DBNull.Value);

            }
            else
            {
                comando.Parameters.AddWithValue("@idDepartamento", departamentoId);
            }
           
            SqlDataReader dr = ConexãoBanco.Selecionar(comando);
            List<Departamento> listaDepartamentos = new List<Departamento>();
            
            if (dr.HasRows)
            {
                int idDepartamento = dr.GetOrdinal("idDepartamento");
                int nomeDepartamento = dr.GetOrdinal("Nome_Departamento");
                int siglaDepartamento = dr.GetOrdinal("Sigla_Departamento");
                int percDepartamento = dr.GetOrdinal("Perc_Departamento");
                int idChefeDepartamento = dr.GetOrdinal("idChefeDepartamento");
              
                while (dr.Read())
                {
                    Departamento departamento = new Departamento();
                    departamento.IdDepartamento = dr.GetInt32(idDepartamento);
                    departamento.NomeDepartamento = dr.GetString(nomeDepartamento);
                    departamento.ChefeDepartamentoVendedor = dr.GetValue(idChefeDepartamento) == DBNull.Value ? -1 : dr.GetInt32(idChefeDepartamento);
                    departamento.PercComissaoDepartamento = dr.GetFloat(percDepartamento);
                    departamento.SiglaDepartamento = dr.GetString(siglaDepartamento);
                    
                    
                    listaDepartamentos.Add(departamento);
                }
            }
            else
            {
                listaDepartamentos = null;
            }
            return listaDepartamentos;
        }
    }
}
