using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Loja.Negocio
{
    public class VendedorNg
    {
        public Loja.Objeto.Models.Vendedor Obter(int id)
        {
            return Loja.Objeto.DAO.VendedorDAO.BuscarPorId(id);
        }
        public List<Loja.Objeto.Models.Vendedor> listarVendedor()
        {
            return Loja.Objeto.DAO.VendedorDAO.listarTodos();
        }

        public List<Loja.Objeto.Models.Vendedor> listarPossiveisChefes()
        {
            return Loja.Objeto.DAO.VendedorDAO.listarTodosPossiveisChefes();
        }

        public void Insert(Loja.Objeto.Models.Vendedor vendedor)
        {
            Loja.Objeto.DAO.VendedorDAO.Insert(vendedor);
        }


        public int Insert2(Loja.Objeto.Models.Vendedor vendedor)
        {
            ConnectionStringSettingsCollection strConnection = ConfigurationManager.ConnectionStrings;
            SqlConnection conn = new SqlConnection(strConnection["ConnectionString"].ConnectionString);
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                Loja.Objeto.BO.VendedorBO.Gravar(vendedor);

                // regra de negócio
                // atualizações, deleções, inserções

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }

            return 1;
        }

        public void Update(Loja.Objeto.Models.Vendedor vendedor)
        {
            Loja.Objeto.BO.VendedorBO.Gravar(vendedor);
        }

        public void Delete(Loja.Objeto.Models.Vendedor vendedor)
        {
            Loja.Objeto.BO.VendedorBO.Apagar(vendedor);
        }
    }
}