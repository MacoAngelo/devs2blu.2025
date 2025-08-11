using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor.Entidades
{
    public enum StatusMissao
    {
        AguardandoLancamento,
        Sucesso,
        Falha,
        EmLancamento,
    }

    public enum DestinoMissao
    {
        Indefinido,
        Lua,
        Marte,
    }
}