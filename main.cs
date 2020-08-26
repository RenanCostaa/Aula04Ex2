using System;
/*
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto e o valor, somente o valor final
*/

class MainClass {

  public static double lancheBom(string item, double quant){
    double valor=0;

    switch (item){
      case "100":
        valor=quant*1.70;
        break;

      case "101":
        valor=quant*2.30;
        break;

      case "102":
        valor=quant*2.60;
        break;

      case "103":
        valor=quant*2.40;
        break;

      case "104":
        valor=quant*2.50;
        break;

      case "105":
        valor=quant*1.00;
        break;
    }
    return valor;
  }
  public static void printaCardapio(){
    Console.WriteLine("---------------------------------");
    Console.WriteLine("100  Cachorro quente   R$ 1,70");
    Console.WriteLine("101   Bauru Simples    R$ 2,30");
    Console.WriteLine("102   Bauru com ovo    R$ 2,60");
    Console.WriteLine("103   Hamburguer       R$ 2,40");
    Console.WriteLine("104   Cheeseburguer    R$ 2,50");
    Console.WriteLine("105   Refrigerante     R$ 1,00");
    Console.WriteLine("---------------------------------");
  }
  public static void Main () {

  }
}