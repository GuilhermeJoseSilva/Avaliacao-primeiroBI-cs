﻿//ex 3 
Animal animal1 = new Cachorro();
Animal animal2 = new Gato();

animal1.EmitirSom();//latindo
animal2.EmitirSom();//miando

//ex4 
Produto produto = new Produto("Camiseta",29.99,10);

produto.ExibirInfo();

produto.AdicionarUnidade(10);
produto.RemoverUnidade(5);

//ex 5 
Filme filme = new Filme("Titanic","Românce",150);
filme.ExibeInfo();
filme.VerificaDisponibilidade();
filme.RegistrarLocacao();
filme.VerificaDisponibilidade();
filme.RegistrarDevolucao();
filme.VerificaDisponibilidade();