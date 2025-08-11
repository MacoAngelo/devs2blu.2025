using OrientacaoObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    internal class UsuarioSistema : IAutenticavel
    {
        static List<UsuarioSistema> _Autenticacoes = new List<UsuarioSistema>();

        public void Logar(string user, string password)
        {
            UserInfo usuarioSelecionado = null;
            foreach (var userInfo in UserInfo.AllUsers)
            {
                if (userInfo.User == user)
                {
                    usuarioSelecionado = userInfo;
                    break;
                }
            }

            if (usuarioSelecionado == null || usuarioSelecionado.Password != password)
            {
                throw new Exception("Usuário ou senha incorretos!");
            }

            Autenticar();
        }

        public void Autenticar()
        {
            _Autenticacoes.Add(this);
            Console.WriteLine("Autenticado!");
        }

        public void Deslogar()
        {
            _Autenticacoes.Remove(this);
        }
    }
}
