using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using JoalheriaPrimeDAL;

namespace JoalheriaPrimeBLL
{
    public class Usuario
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; } = "";
        public string Funcao { get; set; }
        public string Documento { get; set; }
        public string CPF { get; set; }
        public string Modulos { get; set; }
        public string Observacoes { get; set; }
        public char userPermissao { get; set; }
        public bool Ativo { get; set; }

        public Usuario(DataRow usuario)
        {
            UserID = Int32.Parse(usuario["user_id"].ToString());
            Nome = usuario["user_nome"].ToString();
            Login = usuario["user_login"].ToString();
            Funcao = usuario["user_func"].ToString();
            Documento = usuario["user_document"].ToString();
            Observacoes = usuario["user_obs"].ToString();
            Modulos = usuario["user_modulos"].ToString();
            CPF = usuario["user_cpf"].ToString();
            userPermissao = char.Parse(usuario["user_permissao"].ToString());
            bool ativo;
            Ativo = bool.TryParse(usuario["user_atv"].ToString(), out ativo) ? ativo : false;

        }

        public static List<Usuario> listaNomesUsuarios()
        {
            //Define a instrução SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM  prime.usuario_tb WHERE user_atv=true ORDER BY user_login");
            try
            {
                //executa a instrução
                DataTable result = Acces.ExecuteReader(cmd).Tables[0];

                //cria a lista de retorno
                List<Usuario> ret = new List<Usuario>();
                //percorre a tabela retornada adicionando o nome de cada usuário
                foreach(DataRow row in result.Rows)
                {
                    Usuario novoUsuario = new Usuario(row);
                    ret.Add(novoUsuario);
                }
                //retorna a lista criada
                return ret;

            }
            catch
            {
                return new List<Usuario>();
            }
        }

        public static List<string> ListaTodosOsLogins()
        {
            //Define a instrução SQL
            SqlCommand lCmd = new SqlCommand("SELECT DISTINCT login FROM prime.usuario_tb WHERE user_atv=true ORDER BY user_login");

            try
            {
                //Executa a instrução
                DataTable result = Acces.ExecuteReader(lCmd).Tables[0];

                //Cria a lista de retorno
                List<string> ret = new List<string>();

                //Percorre a tabela retornada adicionando o nome de cada usuário à lista de retorno
                foreach (DataRow row in result.Rows)
                    ret.Add(row["user_login"].ToString());

                //Retorna a lista criada
                return ret;
            }
            catch
            {
                return new List<string>();
            }
        }

        public static List<Usuario> GetActiveUsers()
        {
            string sql = "SELECT * FROM prime.usuario_tb WHERE user_atv = TRUE ORDER BY login;";

            //Define a instrução SQL
            SqlCommand lCmd = new SqlCommand(sql);

            List<Usuario> ret = new List<Usuario>();
            try
            {
                //Executa a instrução
                DataTable result = Acces.ExecuteReader(lCmd).Tables[0];

                //Percorre a tabela retornada adicionando o nome de cada usuário à lista de retorno
                foreach (DataRow row in result.Rows)
                {
                    Usuario usuario = new Usuario(row);
                    ret.Add(usuario);
                }
                //Retorna a lista criada
                return ret;
            }
            catch
            {
                return new List<Usuario>();
            }
        }

        public static Usuario GetByID(int id)
        {
            SqlCommand lCmd = new SqlCommand("SELECT * FROM prime.usuario_tb WHERE id_usuario ='" + id + "';");
            Usuario user = new Usuario();
            DataTable result = Acces.ExecuteReader(lCmd).Tables[0];
            if (result.Rows.Count > 0)
                user = new Usuario(result.Rows[0]);

            return user;
        }

        public Usuario()
        {
            Login = "";
            UserID = -1;
        }

        public static Usuario GetUserByLogin(string login)
        {
            SqlCommand lCmd = new SqlCommand("SELECT * FROM prime.usuario_tb WHERE login ='" + login + "';");
            Usuario user = new Usuario();
            DataTable result = Acces.ExecuteReader(lCmd).Tables[0];
            if (result.Rows.Count > 0)
                user = new Usuario(result.Rows[0]);

            return user;
        }

        public static Usuario GetUserByNome(string nome)
        {
            SqlCommand lCmd = new SqlCommand("SELECT * FROM prime.usuario_tb WHERE UPPER(UNACCENT(nome)) ='" + nome.ToUpper() + "';");
            Usuario user = new Usuario();
            DataTable result = Acces.ExecuteReader(lCmd).Tables[0];
            if (result.Rows.Count > 0)
                user = new Usuario(result.Rows[0]);

            return user;
        }

        //criar usuario
        public static void CriarUsuario(Usuario user, string senha)
        {
            SqlCommand lCmd = new SqlCommand();

            lCmd.CommandText = "CREATE USER \"" + user.Login + "\" WITH PASSWORD $$" + senha + "$$ NOSUPERUSER NOCREATEDB; GRANT escreventes TO \"" + user.Login + "\";";

            Acces.ExecuteNonQuery(lCmd);

            lCmd.CommandText = "INSERT INTO prime.usuario(login, senha, nome ,funcao, documento, cpf, modulos, observacao, permissao, user_atv) VALUES ($$" + user.Login + "$$, $$" + user.Senha + "$$ , $$" + user.Nome + "$$ , $$" + user.Funcao + "$$, $$" + user.Documento + "$$, $$" + user.CPF + "$$, $$"+ user.Modulos + "$$, $$"+ user.Observacoes +"$$, $$" + user.userPermissao + "$$, $$" + user.Ativo + "') RETURNING id_usuario;";

            user.UserID = (int)Acces.ExecuteScalar(lCmd.ToString());

        }


        public bool Save()
        {
            #region Save
            string query;
            SqlCommand lCmd = new SqlCommand();
            if (UserID > 0)
            {

                query = @"UPDATE prime.usuario_tb SET login = @login, senha = @senha, nome = @nome, funcao = @funcao, documento = @documento, cpf = @cpf, modulos = @modulos, observacao = @observacao, permissao = @permissao, user_atv=@user_atv WHERE id_usuario = @id_usuario; ";
                lCmd.Parameters.AddWithValue("id_usuario", UserID);


            }
            else
            {
                query = @"INSERT INTO prime.usuario_tb (login, senha, nome ,funcao, documento, cpf, modulos, observacao, permissao, user_atv) 
                                                  VALUES (@login, @senha, @nome, @funcao, @documento, @cp, @user_cpf, @modulos, @observacao, @permissao, @user_atv) RETURNING id;";
            }

            lCmd.CommandText = query;

            lCmd.Parameters.AddWithValue("login", Login.Trim());
            lCmd.Parameters.AddWithValue("senha", Senha.Trim());
            lCmd.Parameters.AddWithValue("nome", Nome.Trim());
            lCmd.Parameters.AddWithValue("funcao", Funcao.Trim());
            lCmd.Parameters.AddWithValue("documento", Documento.Trim());
            lCmd.Parameters.AddWithValue("cpf", CPF.Trim());
            lCmd.Parameters.AddWithValue("modulos", Modulos.Trim());
            lCmd.Parameters.AddWithValue("observacao", Observacoes);
            lCmd.Parameters.AddWithValue("permissao", userPermissao);         
            lCmd.Parameters.AddWithValue("user_atv", Ativo);
           

            SqlTransaction tx;
            SqlConnection conn = (SqlConnection)Acces.GetConnection();
            conn.Open();
            lCmd.Connection = conn;
            tx = conn.BeginTransaction();
            try
            {
                if (UserID > 0)
                    Acces.ExecuteNonQuery(lCmd);
                else
                    UserID = (int)Acces.ExecuteScalar(lCmd.ToString());


                //foreach (var permissao in PermissoesUsuario.ListaAcessos)
                //{
                //    lCmd.CommandText = "INSERT INTO docwin.aux_aces_tb AS a(ac_user, ac_prog, ac_perm) VALUES (" + UserID + ", '" + permissao.PROG + "', " + permissao.PERM + ") ON CONFLICT(ac_user, ac_prog) DO UPDATE SET ac_perm = " + permissao.PERM + ";";
                //    PGAccess.ExecuteNonQuery(lCmd);
                //}

                tx.Commit();

            }
            catch (Exception ex)
            {

                tx.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
                tx.Dispose();
            }

            return true;
            #endregion
        }

        public bool Delete()
        {
            #region DELETE
            string query;
            SqlCommand lCmd = new SqlCommand();

            if (UserID > 0)
            {
                query = "DELETE FROM prime.usuario_tb WHERE id_usuario = @id_usuario;";
                lCmd.Parameters.AddWithValue("id_usuario", UserID);
            }
            else
                return false;

            lCmd.CommandText = query;


            SqlTransaction tx;
            SqlConnection conn = (SqlConnection)Acces.GetConnection();
            conn.Open();
            lCmd.Connection = conn;
            tx = conn.BeginTransaction();


            try
            {
                Acces.ExecuteNonQuery(lCmd);
                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
                tx.Dispose();
            }
            return true;
            #endregion
        }


    }
}
