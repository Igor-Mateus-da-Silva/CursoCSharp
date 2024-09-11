using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                // Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro com Valor Padrao - Classes e Métodos", ParametroPadrao.Executar},

                // Classes e Metodos
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas Delegate - Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Metodos e Funções", UsandoDelegates.Executar},
                {"Delegates com Funções Anonimas - Metodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates Como Parametros - Metodos e Funções", DelegatesComoParametros.Executar},
                {"Metodos De Extensao - Metodos e Funções", MetodosDeExtensao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}