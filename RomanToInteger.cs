/* 
Este código implementa a solução para o problema "Roman to Integer" no LeetCode.

https://leetcode.com/problems/roman-to-integer/

O problema é baseado em numerais romanos representados por sete símbolos: I, V, X, L, C, D e M, cada um associado a um valor específico. 
O objetivo é converter um numeral romano em um número inteiro.

Por exemplo:
Entrada: s = "III"
Saída: 3
Explicação: "III" em numeral romano é igual a 3.

Entrada: s = "LVIII"
Saída: 58
Explicação: "LVIII" se traduz para 58 (L = 50, V = 5, III = 3).

Entrada: s = "MCMXCIV"
Saída: 1994
Explicação: "MCMXCIV" é traduzido para 1994 (M = 1000, CM = 900, XC = 90, IV = 4).

Restrições:
s contém apenas os caracteres ('I', 'V', 'X', 'L', 'C', 'D', 'M').

Como foi utilizado Dictionary as letras possuem valores associados a elas.       
Subtração = Acontece quando um valor menor é colocado antes de um valor maior. Isso indica que devemos subtrair o valor menor do valor maior para obter o número representado pelo numeral.    
Exemplo:
Duas letras diferentes nas quais a que representa menor número vem antes da maior, é preciso subtrair os seus valores.
Exemplos:
IV corresponde a 4
IX corresponde a 9                   
*/      

public class Solution {
    public int RomanToInt(string s) {

        char[] valoresemchar = s.ToCharArray();
        IDictionary<char,int> dic = new Dictionary<char,int>();
        dic.Add('I', 1);
        dic.Add('V', 5);
        dic.Add('X', 10);
        dic.Add('L', 50);  
        dic.Add('C', 100);
        dic.Add('D', 500);
        dic.Add('M', 1000);
      
        int saida = 0;

          
      
        for(int i=0; i<valoresemchar.Length;i++){
          if (i+1<valoresemchar.Length && dic[valoresemchar[i+1]]>dic[valoresemchar[i]])
            {
                saida-=dic[valoresemchar[i]];
            }
            else
            {
                saida+=dic[valoresemchar[i]];
            }
        } 
        return saida;
    }
}
