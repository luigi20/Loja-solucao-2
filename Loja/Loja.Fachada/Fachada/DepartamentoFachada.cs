using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Negocio;

namespace Loja.Fachada.Fachada
{
    [DataObject(true)]
    public class DepartamentoFachada
    {
        private static Loja.Negocio.DepartamentoNg DepartamentoNg = new Negocio.DepartamentoNg();

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Loja.Objeto.Models.Departamento Obter(int id)
        {
            return DepartamentoNg.Obter(id);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int Insert(Loja.Objeto.Models.Departamento departamento)
        {
            
             int inserir = DepartamentoNg.Insert2(departamento);
             return inserir;

        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int Insert(string nomeDepartamento, string siglaDepartamento, double percDepartamento)
        {
            Loja.Objeto.Models.Departamento departamento = new Objeto.Models.Departamento();
            departamento.NomeDepartamento = nomeDepartamento;
            departamento.SiglaDepartamento = siglaDepartamento;
            departamento.ComissaoDepartamento = percDepartamento;
            int inserir = DepartamentoNg.Insert2(departamento);
            return inserir;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public static void Update(Loja.Objeto.Models.Departamento departamento)
        {
            DepartamentoNg.Update(departamento);
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static void Delete(Loja.Objeto.Models.Departamento departamento)
        {
            DepartamentoNg.Delete(departamento);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Loja.Objeto.Models.Departamento> listarDepartamento()
        {
            return DepartamentoNg.listarDepartamento();

        }
    }
}