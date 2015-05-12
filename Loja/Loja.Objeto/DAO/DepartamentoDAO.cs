﻿using System;
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
            comando.CommandText = "Insert into Departamento(Nome_Departamento,Sigla_Departamento,Comissao_Departamento) "
                                   + "values(@nomeDepartamento,@siglaDepartamento,@comissaoDepartamento)";
            comando.Parameters.AddWithValue("@nomeDepartamento", departamento.NomeDepartamento);
            comando.Parameters.AddWithValue("@siglaDepartamento", departamento.SiglaDepartamento);
            comando.Parameters.AddWithValue("@comissaoDepartamento", departamento.ComissaoDepartamento);
            ConexãoBanco.CRUD(comando);
        }

        public static void Update(Departamento departamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Update Departamento set Nome_Departamento = @nomeDepartamento," +
                                  "Sigla_Departamento = @siglaDepartamento,Comissao_Departamento = @comissaoDepartamento"+
                                  "where idDepartamento = @idDepartamento";
            comando.Parameters.AddWithValue("@nomeDepartamento", departamento.NomeDepartamento);
            comando.Parameters.AddWithValue("@siglaDepartamento", departamento.SiglaDepartamento);
            comando.Parameters.AddWithValue("@comissaoDepartamento", departamento.ComissaoDepartamento);
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
            comando.CommandText = "Select * from Departamento where idDepartamento = @idDepartamento";
            comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            SqlDataReader dr = ConexãoBanco.Selecionar(comando);
            Departamento departamento = Departamento.getInstance;
            int departamentoId = dr.GetOrdinal("idDepartamento");
            int nomeDepartamento = dr.GetOrdinal("Nome_Departamento");
            int siglaDepartamento = dr.GetOrdinal("Sigla_Departamento");
            int percDepartamento = dr.GetOrdinal("Comissao_Departamento");
            if (dr.HasRows)
            {
                dr.Read();
                departamento.IdDepartamento = dr.GetInt32(idDepartamento);
                departamento.NomeDepartamento = dr.GetString(nomeDepartamento);
                departamento.SiglaDepartamento = dr.GetString(siglaDepartamento);
                departamento.ComissaoDepartamento = dr.GetDouble(percDepartamento);
                //preenche o objeto
            }
            else
            {
                departamento = null;
            }
            return departamento;
        }

        public static List<Departamento> listarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Departamentos";
            SqlDataReader dr = ConexãoBanco.Selecionar(comando);
            List<Departamento> listaDepartamentos = new List<Departamento>();
            
            if (dr.HasRows)
            {
                int idDepartamento = dr.GetOrdinal("idDepartamento");
                int nomeDepartamento = dr.GetOrdinal("Nome_Departamento");
                int siglaDepartamento = dr.GetOrdinal("Sigla_Departamento");
                int percDepartamento = dr.GetOrdinal("Comissao_Departamento");
                while (dr.Read())
                {
                    Departamento departamento = Departamento.getInstance;
                    departamento.IdDepartamento = dr.GetInt32(idDepartamento);
                    departamento.NomeDepartamento = dr.GetString(nomeDepartamento);
                    departamento.SiglaDepartamento = dr.GetString(siglaDepartamento);
                    departamento.ComissaoDepartamento = dr.GetDouble(percDepartamento);
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