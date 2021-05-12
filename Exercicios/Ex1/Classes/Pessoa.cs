using System;

namespace Ex1.Classes
{
    public class Pessoa
    {
        public string primeiroNome; 
        public string sobreNome;

        public Pessoa(){
            
        }
        public Pessoa(string primeiroNome, string sobreNome){
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;

            Console.WriteLine($"Bem Vindo (a) {primeiroNome} {sobreNome}");
        }
    }
}